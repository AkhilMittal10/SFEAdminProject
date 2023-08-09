using System.ComponentModel.DataAnnotations;
using System;

namespace SfeAdminPortal.Models
{
    public class Users
    {
        [Key]
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public string Email { get; set; }
        public string Roles { get; set; }

    }
}
