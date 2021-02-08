using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using IPay88Q2_4API.DataAccess;
using Microsoft.EntityFrameworkCore;
using IPay88Q2_4API.Models;

namespace IPay88Q2_4.Pages
{
    public class Q4Model : PageModel
    {
        private readonly ILogger<Q4Model> _logger;
        private readonly IPayContext _db;

        public Bank result;
        public int? search = null;

        public Q4Model(ILogger<Q4Model> logger, IPayContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult OnPost(long search)
        {
            search /= 10000000000;
            if (ModelState.IsValid == false || search < 100000)
            {
                return Page();
            }
            result = _db.Bank.FirstOrDefault(e => e.typeNumber == search);
            return Page();

            // return RedirectToPage("./Index");
        } 
    }
}
