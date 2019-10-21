using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Data.CustomConventions
{
    class IntConventions : Convention
    {
        public IntConventions()
        {
            Properties<int>().Where(p=>p.Name.EndsWith("Cote")).Configure(p => p.IsKey());
        }
    }
}
