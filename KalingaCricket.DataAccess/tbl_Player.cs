//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KalingaCricket.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Player
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Player()
        {
            this.Player_Team = new HashSet<Player_Team>();
        }
    
        public int Player_Id { get; set; }
        public string Player_Name { get; set; }
        public int Player_Type { get; set; }
        public double Player_Batting_Avg { get; set; }
        public double Player_Bowling_Avg { get; set; }
        public int Player_Age { get; set; }
        public bool Player_Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Player_Team> Player_Team { get; set; }
    }
}
