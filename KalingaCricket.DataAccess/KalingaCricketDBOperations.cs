using KalingaCricket.Entities;
using KalingaCricket.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalingaCricket.DataAccess
{


    public class KalingaCricketDBOperations
    {
        private KalingaCricketDBEntities1 context = null;

        public KalingaCricketDBOperations()
        {
            context = new KalingaCricketDBEntities1();
        }

        public int CreatePlayer(tbl_Player PlayerObject)
        {
            if (PlayerObject != null)
            {
                context.tbl_Player.Add(PlayerObject);
                int createStatus = context.SaveChanges();
                return createStatus;
            }
            else
                throw new CannotCreatePlayer("Error Creating Player");
        }

        public List<tbl_Player> DisplayPlayers()
        {
            return (context.tbl_Player.OrderByDescending(batting => batting.Player_Batting_Avg).ToList());
        }

        public List<tbl_Player> DisplayPlayersByStatus()
        {
            return (context.tbl_Player.Where(status=>status.Player_Status==false).OrderByDescending(batting => batting.Player_Batting_Avg).ToList());
        }


        public List<tbl_Type> DisplayTypes()
        {
            return context.tbl_Type.ToList();
        }

        //------------End of Player Operations----------------
        //------------Team Operations------------------

        public int CreateTeam(string[] playerList, string Country)
        {
            tbl_Team teamObject = new tbl_Team();
            teamObject.Team_Country = Country;
            context.tbl_Team.Add(teamObject);
            context.SaveChanges();
            foreach (string playerId in playerList) {
               
                    Player_Team playerteamObject = new Player_Team();
                    playerteamObject.Player_Id = int.Parse(playerId);
                    playerteamObject.Team_Id = context.tbl_Team.Where(country => country.Team_Country == Country)
                                                .SingleOrDefault().Team_Id;
                    teamObject.Player_Team.Add(playerteamObject);
              var PlayerObject =  context.tbl_Player.Find(int.Parse(playerId));
               PlayerObject.Player_Status = true;
            }
            int createStatus = context.SaveChanges();
            if (createStatus > 0)
                return 1;
            else
                throw new CannotCreatePlayer("Cannot Create Team");
        }
    }
}
