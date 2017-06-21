using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NGCooking.Models
{
    public class Community
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Level { get; set; }
        public string Picture { get; set; }
        public string City { get; set; }
        public int Birth { get; set; }
        public string Bio { get; set; }
    }
}