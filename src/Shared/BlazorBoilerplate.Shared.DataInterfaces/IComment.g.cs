using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBoilerplate.Shared.DataInterfaces
{
    public interface IComment
    {
        int Id { get; set; }

        String UserName { get; set; }

        String Text { get; set; }

        DateTime When { get; set; }

        int CourseID { get; set; }

        ICourse Course { get; set; }

        Guid SenderId { get; set; }

        IApplicationUser Sender { get; set; }
    }
}
