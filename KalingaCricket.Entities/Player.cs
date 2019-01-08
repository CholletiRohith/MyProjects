using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalingaCricket.Entities
{
    public class Player
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key()]
        public int Player_Id { get; set; }

        public string Player_Name { get; set; }
        public string Type { get; set; }
        public double Player_BattingAvg { get; set; }

        public double Player_BowlingAvg { get; set; }
        public int Age { get; set; }
        public bool Allocated { get; set; }
    }
}
