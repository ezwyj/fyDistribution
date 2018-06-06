using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fyDistribution.Domain.Entity
{
    public class Estate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Developers { get; set; }
        public string City { get; set; }
        public float Commission { get; set; }
        public string CommissionRemark { get; set; }
        public float Price { get; set; }
        public string Unit { get; set; }
        public string Remark { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public string PropertyType { get; set; }
        /// <summary>
        /// 用途
        /// </summary>
        public string PropertyUsage { get; set; }

        public string CompleteYear { get; set; }

    }
}
