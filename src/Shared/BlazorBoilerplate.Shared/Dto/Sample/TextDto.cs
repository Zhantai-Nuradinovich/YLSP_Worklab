using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBoilerplate.Shared.Dto.Sample
{
    public class TextDto
    {
        public Int32 Id { get; set; }

        public string TextContent { get; set; }
        public DateTime When { get; set; }
        public Int32 CourseID { get; set; }
    }
}
