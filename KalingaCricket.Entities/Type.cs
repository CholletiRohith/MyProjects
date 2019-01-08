using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalingaCricket.Entities
{
   public class CricketType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key()]
        public int Type_Id { get; set; }

        public string Type_Name { get; set; }
    }
}
