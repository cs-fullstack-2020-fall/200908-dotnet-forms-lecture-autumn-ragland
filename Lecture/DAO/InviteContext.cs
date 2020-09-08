using Microsoft.EntityFrameworkCore;
using Lecture.Models;
namespace Lecture.DAO
{
    public class InviteContext : DbContext
    {
        public InviteContext(DbContextOptions<InviteContext> options) : base(options)
        {
        }
        public DbSet<Invite> Invites {get;set;}
    }
}