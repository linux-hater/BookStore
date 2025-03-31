using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASP_NET_core_Project.Models;

namespace Project.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepo<Category>
    {
        void Update(Category obj);
    }
}
