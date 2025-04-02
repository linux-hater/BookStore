using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASP_NET_core_Project.Models;

namespace Project.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepo<Product>
    {
        void Update(Category obj);
    }
}
