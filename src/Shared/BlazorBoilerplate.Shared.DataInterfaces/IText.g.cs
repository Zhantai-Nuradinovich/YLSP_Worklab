using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBoilerplate.Shared.DataInterfaces
{
    public interface IText
    {
        int Id { get; set; }

        String TextContent { get; set; }

        DateTime When { get; set; }

        int CourseID { get; set; }

        ICourse Course { get; set; }
    }
}
