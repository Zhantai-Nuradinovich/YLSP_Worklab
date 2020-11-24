using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorBoilerplate.Infrastructure.Storage.DataModels
{
    public partial class Text
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string TextContent { get; set; }
        public DateTime When { get; set; }
        public int CourseID { get; set; }
        public Course Course { get; set; }
    }
}
