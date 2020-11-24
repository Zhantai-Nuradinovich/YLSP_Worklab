using BlazorBoilerplate.Infrastructure.Storage.DataInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorBoilerplate.Infrastructure.Storage.DataModels
{
    public partial class Course
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(256)]
        public string DirectionName { get; set; }
        public string PicturePath { get; set; }
        public string Annotation { get; set; }
        [Required]
        [MaxLength(128)]
        public string CourseName { get; set; }
        public virtual ICollection<Quiz> Quizzes { get; set; }
        public virtual ICollection<Text> Texts { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
