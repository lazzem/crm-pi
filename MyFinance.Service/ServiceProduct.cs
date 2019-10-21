using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFinance.Domain.Entities;
using MyFinance.Data;
using Data.Infrastructure;
using System.Linq.Expressions;
using ServicePattern;

namespace MyFinance.Service
{
    public class ServiceProduct : Service<Product>, IServiceProduct
    {
        private static DatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork uow = new UnitOfWork(dbf);
        //private IRepositoryBase<Product> repo = new RepositoryBase<Product>(dbf);
        //MyFinanceContext ctx;
        public ServiceProduct() : base(uow)
        {
            //ctx = new MyFinanceContext();
            //ctx = dbf.DataContext;
        }
    }

}
