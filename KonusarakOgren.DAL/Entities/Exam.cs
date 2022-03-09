using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KonusarakOgren.DAL.Entities
{
    public class Exam
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }

        public List<Question> QuestionList { get; set; }
    }
}
