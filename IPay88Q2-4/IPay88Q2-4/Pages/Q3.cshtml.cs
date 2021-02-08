using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using IPay88Q2_4API.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace IPay88Q2_4.Pages
{
    public class Q3Model : PageModel
    {
        private readonly ILogger<Q3Model> _logger;
        private readonly IPayContext _db;
        public string[] Doctor;
        public string[] Professor;
        public string[] Singer;
        public string[] Actor;
        public int max = 0;

        public Q3Model(ILogger<Q3Model> logger, IPayContext db)
        {
            _logger = logger;
            _db = db;
        }

        public void OnGet()
        {
            string[] type = { "Doctor", "Professor", "Singer", "Actor" };
            Doctor = _db.Occupations.Where(e => e.Type == "Doctor").OrderBy(e => e.Name).Select(e => e.Name).ToArray();
            Professor = _db.Occupations.Where(e => e.Type == "Professor").OrderBy(e => e.Name).Select(e => e.Name).ToArray();
            Singer = _db.Occupations.Where(e => e.Type == "Singer").OrderBy(e => e.Name).Select(e => e.Name).ToArray();
            Actor = _db.Occupations.Where(e => e.Type == "Actor").OrderBy(e => e.Name).Select(e => e.Name).ToArray();

            max = Math.Max(Math.Max(Doctor.Length, Professor.Length), Math.Max(Singer.Length, Actor.Length));
        }
    }
}
