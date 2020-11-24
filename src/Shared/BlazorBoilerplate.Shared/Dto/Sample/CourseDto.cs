using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBoilerplate.Shared.Dto.Sample
{
    public class CourseDto
    {
        public Int32 Id { get; set; }
        public string DirectionName { get; set; }
        public string PicturePath { get; set; }
        public string Annotation { get; set; }
        public DateTime When { get; set; }
        public string CourseName { get; set; }
    }
}
