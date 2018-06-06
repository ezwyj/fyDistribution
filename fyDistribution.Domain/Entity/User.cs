using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fyDistribution.Domain.Entity
{
    public class User
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String LoginId { get; set; }
        public string Passowrd { get; set; }
        public DateTime LastLoginTime { get; set; }
        public DateTime RegTime { get; set; }
        public int CompanyId { get; set; }

    }
}
