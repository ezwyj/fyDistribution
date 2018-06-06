using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fyDistribution.Domain.Entity
{
    public class Company
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int ManagerId { get; set; }
        public String Address { get; set; }
    }
}
