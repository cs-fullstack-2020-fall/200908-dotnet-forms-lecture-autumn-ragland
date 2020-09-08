using Lecture.Models;
using Lecture.DAO;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Lecture.Controllers
{
    public class HouseParty : Controller
    {
        private readonly InviteContext _context;
        public HouseParty(InviteContext context)
        {
            _context = context;
        }
        public IActionResult ViewInvite(int inviteID)
        {
            Invite matchingInvite = _context.Invites.FirstOrDefault(inv => inv.id == inviteID);
            if(matchingInvite != null)
            {
                return View(matchingInvite);
            } else 
            {
                ViewData["error"] = "No matching invite found";
                return View("Error");
            }
        }
        public IActionResult ListInvites()
        {
            return View(_context);
        }
        [HttpPost]
        public IActionResult AddInvite(Invite newInvite)
        {
            _context.Invites.Add(newInvite);
            _context.SaveChanges();
            return RedirectToAction("ViewInvite", "HouseParty", new {inviteID = newInvite.id});
        }
        public IActionResult NewInvite()
        {
            return View();
        }
    }
}