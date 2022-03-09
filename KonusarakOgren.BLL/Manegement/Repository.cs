using KonusarakOgren.BLL.Service;
using KonusarakOgren.DAL.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KonusarakOgren.BLL.Manegement
{
    public class Repository<T> : IRepository<T>
         where T : class
    {
        protected readonly Context _dbContext;

        protected DbSet<T> DbSet;



        public Repository(Context dbContext)
        {
            _dbContext = dbContext;
            DbSet = _dbContext.Set<T>();
        }


        public IQueryable<T> GetAll()
        {
            var Db = DbSet;
            return Db;
        }


    }
}
