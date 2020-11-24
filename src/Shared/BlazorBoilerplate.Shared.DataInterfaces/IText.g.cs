using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBoilerplate.Shared.DataInterfaces
{
    public interface IText
    {
        Int32 Id { get; set; }

        String TextContent { get; set; }

        DateTime When { get; set; }

        Int32 CourseID { get; set; }

        ICourse Course { get; set; }
    }
}
