using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorBoilerplate.Infrastructure.Storage.DataModels
{
    public partial class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Text { get; set; }
        public DateTime When { get; set; }
        public int CourseID { get; set; }
        public Course Course { get; set; }
        public Guid SenderId { get; set; }
        public ApplicationUser Sender { get; set; }
    }
}
