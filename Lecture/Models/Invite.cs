using System.ComponentModel.DataAnnotations;
namespace Lecture.Models
{
    public class Invite
    {
        [Key]
        public int id {get;set;}
        [Required]
        [StringLength(200)]
        [Display(Name = "Name")]
        public string inviteName {get;set;}
        [Display(Name = "Attending")]
        public bool isAttending {get;set;}
        [Display(Name = "Number of Parties Invitee Has Attended")]
        public int numberAttended {get;set;}
        [Required]
        [Display(Name = "Age")]
        public int age {get;set;}
    }
}