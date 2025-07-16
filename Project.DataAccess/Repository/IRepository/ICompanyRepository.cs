using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Models;

namespace Project.DataAccess.Repository.IRepository
{
    public interface ICompanyRepository : IRepo<Company>
    {
        void Update(Company obj);
    }
}
