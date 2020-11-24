using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorBoilerplate.Infrastructure.Storage.DataModels
{
    public partial class QuizItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Question { get; set; }
        public string QuestionType { get; set; }

        public string PicturePath { get; set; }
        public DateTime When { get; set; }

        [Required]
        public string Answers { get; set; }

        [Required]
        public string RightAnswer { get; set; }

        public int QuizID { get; set; }
        public Quiz Quiz { get; set; }
    }
}
