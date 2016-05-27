using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RiggenPoker.Models
{
    public class Result
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public int History { get; set; }
        public int TotalScore { get; set; }
        public int NewScore { get; set; }
       // public virtual ICollection<ApplicationUser> UserName { get; set; }
    }
}

//protected override void Seed(RiggenPoker.Models.ApplicationDbContext context)
//{
//    if (!context.Users.Any(u => u.UserName == "Admin"))
//    {
//        var roleStore = new RoleStore<IdentityRole>(context);
//        var roleManager = new RoleManager<IdentityRole>(roleStore);
//        var userstore = new UserStore<ApplicationUser>(context);
//        var userManager = new UserManager<ApplicationUser>(userstore);
//        var user = new ApplicationUser { UserName = "Admin" };
//        userManager.Create(user, "password");
//        roleManager.Create(new IdentityRole { Name = "Admin" });
//        userManager.AddToRole(user.Id, "admin");
//    }
