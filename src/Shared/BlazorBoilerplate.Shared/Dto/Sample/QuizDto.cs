using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorBoilerplate.Shared.Dto.Sample
{
    public class QuizDto
    {
        public Int32 Id { get; set; }
        public string QuizName { get; set; }
        public DateTime When { get; set; }

        [Required]
        public virtual ICollection<QuizItemDto> Items { get; set; }
        public Int32 CourseID { get; set; }
    }
}
