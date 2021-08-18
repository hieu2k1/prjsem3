using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoProjectSem3.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string User_name { get; set; }
        public string Password { get; set; }
        public int Role_id { get; set; }
        public virtual Role Role { get; set; }

    }
}