using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFinance.Domain.Entities;
using Data.Infrastructure;
using MyFinance.Data;
using ServicePattern;

namespace MyFinance.Service
{
    public class ServiceCategory : Service<Category>,IServiceCategory
    {
        private static DatabaseFactory dbf = new DatabaseFactory();
        //MyFinanceContext ctx;
        //private IRepositoryBase<Category> repo = new RepositoryBase<Category>(dbf);
       
        private static IUnitOfWork uow = new UnitOfWork(dbf);
        
        public ServiceCategory() : base(uow)
        {
            //ctx = dbf.DataContext;
        }
        public void AddCategory(Category c)
        {
            //ctx.Set<Category>().Add(c);
            uow.getRepository<Category>().Add(c);
        }

        public void RemoveCategory(Category c)
        {
            //ctx.Set<Category>().Remove(c);
            uow.getRepository<Category>().Delete(c);
        }
    }
}
