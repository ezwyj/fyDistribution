using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fyDistribution.Domain.Entity
{
    public class Follow
    {
        public int Id { get; set; }
        public string Contnet { get; set; }
        public int InputUser { get; set; }
        public DateTime InputTime { get; set; }
        
    }
}
