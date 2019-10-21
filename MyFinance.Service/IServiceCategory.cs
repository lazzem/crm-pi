using MyFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Service
{
    public interface IServiceCategory
    {
        void AddCategory(Category c);
        void RemoveCategory(Category c);
    }
}
