﻿using MyFinance.Domain.Entities;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Service
{
    public interface IServiceProduct : IService<Product>
    {
    }
}
