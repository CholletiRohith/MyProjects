using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalingaCricket.Entities
{
   public class Team
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key()]
        public int Team_Id { get; set; }

        public int Team_Players { get; set; }

        [ForeignKey("Team_Players")]
        public virtual List<Player> Players { get; set; }
        public string Country { get; set; }


    }
}
