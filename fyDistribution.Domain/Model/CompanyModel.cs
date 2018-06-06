using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fyDistribution.Domain.Model
{
    public class CompanyModel
    {
        public Entity.Company Company { get; set; }
        public Entity.User Manager { get; set; }
        public List<Entity.User> Users { get; set; }
    }
}
