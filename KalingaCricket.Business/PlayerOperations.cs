using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KalingaCricket.DataAccess;
using KalingaCricket.Exceptions;

namespace KalingaCricket.Business
{
    public class PlayerOperations
    {

        private KalingaCricketDBOperations dbOperations = null;

        public PlayerOperations()
        {
            dbOperations = new KalingaCricketDBOperations();
        }

        public int CreatePlayer(tbl_Player playerObject)
        {
            if (playerObject != null)
            {
                if (playerObject.Player_Age > 14)
                {
                    int createStatus = dbOperations.CreatePlayer(playerObject);
                    if (createStatus > 0)
                        return 1;
                    else return 0;
                }
                else
                    throw new AgeNotSupportedException("Age is less than 14");

            }
            else
                throw new CannotCreatePlayer("Player Cannot be null");
        }

        public List<tbl_Player> DisplayPlayers()
        {
            return dbOperations.DisplayPlayers();
        }

        public List<tbl_Player> DisplayPlayersByStatus()
        {
            return dbOperations.DisplayPlayersByStatus();
        }

        public List<tbl_Type> DisplayTypes()
        {
            return dbOperations.DisplayTypes();
        }
    }
}
