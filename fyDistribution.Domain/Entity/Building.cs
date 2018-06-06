using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fyDistribution.Domain.Entity
{
    public class Building
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public BuildingEnum Status { get; set; }


    }
    public enum BuildingEnum
    {
        未处理=0,
        已处理=1
    }
}
