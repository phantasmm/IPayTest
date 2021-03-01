using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IPay88Q2_4API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MongoDB.Bson;
using MongoDB.Driver;

namespace IPay88Q2_4.Pages
{
    public class Q5Model : PageModel
    {
        private readonly MongoDB _db;
        public List<Person> personList;
        public string FisrtName;
        public string LastName;

        public Q5Model()
        {
            _db = new MongoDB("PersonDB");
        }
        public void OnGet()
        {
            personList = _db.LoadRecords<Person>("Person");
        }

        public IActionResult OnPostSave(string FisrtName, string LastName)
        {
            _db.InsertReord("Person", new Person { FirstName = FisrtName, LastName = LastName });
            OnGet();
            return Page();
        }

        public IActionResult OnPostDelete(Guid id)
        {
            _db.DeleteRecord<Person>("Person", id);
            OnGet();
            return Page();
        }
    }

    public class MongoDB
    {
        private IMongoDatabase _db;

        public MongoDB(string database)
        {
            var client = new MongoClient();
            _db = client.GetDatabase(database);
        }

        public void InsertReord<T>(string table, T record)
        {
            var collection = _db.GetCollection<T>(table);
            collection.InsertOne(record);
        }

        public List<T> LoadRecords<T>(string table)
        {
            var collection = _db.GetCollection<T>(table);
            return collection.Find(new BsonDocument()).ToList();
        }

        public void DeleteRecord<T>(string table, Guid id)
        {
            var collection = _db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);
            collection.DeleteOne(filter);
        }
    }
}
