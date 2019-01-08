using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KalingaCricket.DataAccess;

namespace KalingaCricket.Business
{
   public class TeamOperations
    {
        private KalingaCricketDBOperations dataAccess = null;
        public TeamOperations()
        {
            dataAccess = new KalingaCricketDBOperations();
        }

        public int CreateTeam(string[] playerList, string Country)
        {
            int createStatus = dataAccess.CreateTeam(playerList, Country);
            return createStatus;
        }


    }
}
