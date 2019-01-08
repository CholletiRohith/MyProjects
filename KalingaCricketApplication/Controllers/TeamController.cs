using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KalingaCricket.Business;
using KalingaCricket.Exceptions;

namespace KalingaCricketApplication.Controllers
{
    public class TeamController : Controller
    {
        private KalingaCricket.Business.TeamOperations  teamOperationObject = null;
        PlayerOperations playerOperationObject = new PlayerOperations();

        public TeamController()
        {
            teamOperationObject = new TeamOperations();
        }
        // GET: Team
        public ActionResult CreateTeam()
        {
            return View(playerOperationObject.DisplayPlayersByStatus());
        }

        [HttpPost]
        public ActionResult CreateTeam(string[] playerList, string Country)
        {
            try
            {
                teamOperationObject.CreateTeam(playerList, Country);
                return RedirectToAction("Index", "Player");
            }
            catch(CannotCreatePlayer e)
            {
                return Content(e.Message);
            }
        }
    }
}