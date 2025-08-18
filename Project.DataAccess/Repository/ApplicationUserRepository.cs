using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Project.Models;
using Project.DataAccess.Repository.IRepository;
using Project.DataAcess.Data;

namespace Project.DataAccess.Repository
{
    public class ApplicationUserRepository : Repo<ApplicationUser>, IApplicationUserRepository
    {
        private ApplicationDbContext _db;
        public ApplicationUserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
