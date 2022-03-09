using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KonusarakOgren.DAL.Entities
{
    public class Question
    {
        [Key]
        public int Id { get; set; } 
       
        public string chicA { get; set; }
        public string chicB { get; set; }
        public string chicC { get; set; }
        public string chicd { get; set; }

        public string Truechic { get; set; }
    }
}
