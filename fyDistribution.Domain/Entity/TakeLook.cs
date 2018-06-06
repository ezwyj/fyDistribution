using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fyDistribution.Domain.Entity
{
    /// <summary>
    /// 带看
    /// </summary>
    public class TakeLook
    {
        public int Id { get; set; }
        public string Client { get; set; }
        public DateTime LookTime { get; set; }
        
    }
}
