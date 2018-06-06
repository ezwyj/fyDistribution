using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fyDistribution.Domain.Entity
{
    /// <summary>
    /// 预约
    /// </summary>
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public string ClientName { get; set;}
        public string Target { get; set; }
        

        public DateTime InputTime { get; set; }
        public int InputUser { get; set; }
    }
}
