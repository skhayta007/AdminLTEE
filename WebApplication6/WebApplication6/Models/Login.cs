using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Models
{
    public class Login
    {
        [Key]
        public int id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Hour { get; set; }
        public byte Admin { get; set; }
        public byte Active { get; set; }
        public string Hours { get; set; }
    }
}
