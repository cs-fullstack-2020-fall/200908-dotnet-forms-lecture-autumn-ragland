using Lecture.Models;
using Lecture.DAO;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

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
            if(ModelState.IsValid)
            {
                _context.Invites.Add(newInvite);
                _context.SaveChanges();
                return RedirectToAction("ViewInvite", "HouseParty", new {inviteID = newInvite.id});
            } else 
            {
                List<string> errors = GetErrorListFromModelState(ModelState);
                string displayErr = "";
                errors.ForEach(err => displayErr += err);
                ViewData["errors"] = displayErr;
                return View("NewInvite", newInvite);
            }
            
        }
        public IActionResult NewInvite(Invite newInvite)
        {
            return View();
        }
        // method to capture model state validation errors
        public static List<string> GetErrorListFromModelState(ModelStateDictionary modelState)
        {
            IEnumerable<string> query = from state in modelState.Values
                from error in state.Errors
                select error.ErrorMessage;

            List<string> errorList = query.ToList();
            return errorList;
        }
    }
}