using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fyDistribution.Domain.Interface
{
    interface IAccount
    {
        void RegisterCompany();
        void ChangeCompanyManager();
        void AddCompanyUser();
       
    }
}
