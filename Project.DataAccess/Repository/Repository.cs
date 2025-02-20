//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Project.DataAccess.Repository.IRepository;

//namespace Project.DataAccess.Repository
//{
//    public class Repository<T> : IRepository<T> where T : class
//    {
//        private readonly ApplicationDbContext _db;
//        internal DbSet<T> dbSet;
//        public Repository(ApplicationDbCOntext db)
//        {
//            _db = db;
//            this.dbSet = _db.Set<T>();
//            //_db.Categories ==dbSet
//        }

//        public void Add(T entity)
//        {
//            dbSet.Add(entity);
//        }

//        public T Get(Expression<Func<T, bool>> filter)
//        {
//            IQueryable<T> query = dbSet;
//            query = query.Where(filter);
//            return query.FirstOrDefault();
//        }
//    }
//}
