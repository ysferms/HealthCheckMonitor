using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class User
    {
        public User()
        {
            ApplicationUser = new HashSet<ApplicationUser>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public virtual ICollection<ApplicationUser> ApplicationUser { get; set; }
    }
}
