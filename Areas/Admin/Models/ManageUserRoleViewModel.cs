using Microsoft.AspNetCore.Identity;

namespace ITS_System.Areas.Admin.Models
{
    public class ManageUserRoleViewModel
    {
        public IdentityUser User { get; set; }

        public IdentityRole Role { get; set; }

        public bool InRole { get; set; }
    }
}
