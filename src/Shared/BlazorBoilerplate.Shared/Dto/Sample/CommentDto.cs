using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorBoilerplate.Shared.Dto.Sample
{
    public class CommentDto
    {
        public Int32 Id { get; set; }
        public string UserName { get; set; }
        public string Text { get; set; }
        public DateTime When { get; set; }
        public Guid SenderId { get; set; }
        public Int32 CourseID { get; set; }

        public bool Mine { get; set; }

        public CommentDto() { }

        public CommentDto(Int32 id, string userName, string text, bool mine)
        {
            Id = id;
            UserName = userName;
            Text = text;
            Mine = mine;
        }

        /// <summary>
        /// Determine CSS classes to use for message div
        /// TODO: disambiguate between your and other members
        /// </summary>
        public string CSS
        {
            get
            {
                return Mine ? "sent" : "received";
            }
        }
    }
}
