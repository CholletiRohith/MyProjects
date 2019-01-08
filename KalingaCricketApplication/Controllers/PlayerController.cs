using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KalingaCricket.Business;
using KalingaCricket.DataAccess;
using KalingaCricket.Exceptions;

namespace KalingaCricketApplication.Controllers
{
    public class PlayerController : Controller
    {
        private KalingaCricket.Business.PlayerOperations playerOperationsObject = null;

        public PlayerController()
        {
            playerOperationsObject = new PlayerOperations();
        }
        // GET: Player

        public ActionResult Index()
        {
            return View(playerOperationsObject.DisplayPlayers());
        }

        public ActionResult CreatePlayer()
        {
            var listOfTypes = playerOperationsObject.DisplayTypes();
            SelectList dropdownList = new SelectList(listOfTypes, "Type_Id", "Type_Name");
            ViewBag.listOfTypes = dropdownList;
            return View();
        }

        [HttpPost]
        public ActionResult CreatePlayer(tbl_Player playerObject)
        {
            try
            {
                playerOperationsObject.CreatePlayer(playerObject);
                return RedirectToAction("Index");
            }
            catch (AgeNotSupportedException e)
            {
                ViewBag.ErrorMessage = e.Message;
                return Content(e.Message);
            }
            catch (CannotCreatePlayer e)
            {
                ViewBag.ErrorMessage = e.Message;
                return Content(e.Message);

            }

        }
    }
}