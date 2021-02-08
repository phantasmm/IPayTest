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
    public class Q2Model : PageModel
    {
        private readonly ILogger<Q2Model> _logger;
        private readonly IPayContext _db;
        public string[] result;
        public Q2Model(ILogger<Q2Model> logger, IPayContext db)
        {
            _logger = logger;
            _db = db;
        }

        public void OnGet()
        {
            var friendList = _db.Friend.Include(x => x.My).Include(x => x.Friends).ToArray();
            var salaryList = _db.Packages.Include(x => x.My).ToArray();

            var JoinTable = (from f in friendList
                          join s in salaryList on f.My.ID equals s.My.ID
                          join s2 in salaryList on f.Friends.ID equals s2.My.ID
                          select new
                          {
                              f.My.Name,
                              s.Salary,
                              friendSalary = s2.Salary
                          }).ToList();
            result = JoinTable.Where(r => r.friendSalary > r.Salary).OrderBy(o => o.friendSalary).Select(e => e.Name).ToArray();
        }
    }
}
