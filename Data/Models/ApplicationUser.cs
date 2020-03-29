using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class ApplicationUser
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Url { get; set; }
        public string ApplicationName { get; set; }
        public int CheckTime { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual User User { get; set; }
    }
}
