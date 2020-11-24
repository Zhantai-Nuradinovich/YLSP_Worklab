using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorBoilerplate.Infrastructure.Storage.DataModels
{
    public partial class Quiz
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(128)]
        public string QuizName { get; set; }
        public DateTime When { get; set; }

        [Required]
        public virtual ICollection<QuizItem> Items { get; set; }
        public int CourseID { get; set; }
        public Course Course { get; set; }
    }
}
