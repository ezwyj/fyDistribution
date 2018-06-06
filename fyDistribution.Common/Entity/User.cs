using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fyDistribution.Common.Entity
{
    [TableName("Right_User")]
    [PrimaryKey("Id", AutoIncrement = true)]
    public class User 
    {


        public int Id { get; set; }
        public string UserName { get; set; }
        public string Badge { get; set; }
        public string Department { get; set; }
    }
}
