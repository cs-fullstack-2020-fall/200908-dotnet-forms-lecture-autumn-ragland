using System.ComponentModel.DataAnnotations;
namespace Lecture.Models
{
    public class Invite
    {
        [Key]
        public int id {get;set;}
        public string inviteName {get;set;}
        public bool isAttending {get;set;}
        public int numberAttended {get;set;}
        public int age {get;set;}
    }
}