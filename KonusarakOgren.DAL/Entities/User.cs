using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KonusarakOgren.DAL.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int status { get; set; }
    }
}
