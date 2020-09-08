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
                // return Content($"ID {matchingInvite.id}\nName {matchingInvite.inviteName}\nIs Attending {matchingInvite.isAttending}\nParties Attended {matchingInvite.numberAttended}\nAge : {matchingInvite.age}\n---\n");
                ViewData["invite"] = $"ID {matchingInvite.id}\nName {matchingInvite.inviteName}\nIs Attending {matchingInvite.isAttending}\nParties Attended {matchingInvite.numberAttended}\nAge : {matchingInvite.age}\n---\n";
                return View();
            } else 
            {
                // return Content("Not matching invite found");
                ViewData["error"] = "No matching invite found";
                return View("Error");
            }
        }
        public IActionResult ListInvites()
        {
            string displayStr = "";
            foreach(Invite inv in _context.Invites)
            {
                displayStr += $"ID {inv.id}\nName {inv.inviteName}\nIs Attending {inv.isAttending}\nParties Attended {inv.numberAttended}\nAge : {inv.age}\n---\n";
            }
            // return Content($"{displayStr}");
            ViewData["invites"] = displayStr;
            return View();
        }
        [HttpPost]
        public IActionResult AddInvite([Bind("inviteName", "isAttending", "numberAttended", "age")] Invite newInvite)
        {
            _context.Invites.Add(newInvite);
            _context.SaveChanges();
            // return Content($"Return new invite {newInvite.inviteName}");
                ViewData["invite"] = $"ID {newInvite.id}\nName {newInvite.inviteName}\nIs Attending {newInvite.isAttending}\nParties Attended {newInvite.numberAttended}\nAge : {newInvite.age}\n---\n";
                return View("ViewInvite");
        }
    }
}