using BlazorBoilerplate.Shared.DataInterfaces;
using Breeze.Sharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBoilerplate.Shared.Dto.Db
{
    public partial class Comment : BaseEntity, IComment
    {
        public int Id
        {
            get { return GetValue<int>(); }
            set { SetValue(value); }
        }

        public String UserName
        {
            get { return GetValue<String>(); }
            set { SetValue(value); }
        }

        public String Text
        {
            get { return GetValue<String>(); }
            set { SetValue(value); }
        }

        public DateTime When
        {
            get { return GetValue<DateTime>(); }
            set { SetValue(value); }
        }

        public Guid SenderId
        {
            get { return GetValue<Guid>(); }
            set { SetValue(value); }
        }

        public int CourseID
        {
            get { return GetValue<int>(); }
            set { SetValue(value); }
        }

        ICourse IComment.Course { get => Course; set => Course = (Course)value; }

        public Course Course
        {
            get { return GetValue<Course>(); }
            set { SetValue(value); }
        }

        IApplicationUser IComment.Sender { get => Sender; set => Sender = (ApplicationUser)value; }

        public ApplicationUser Sender
        {
            get { return GetValue<ApplicationUser>(); }
            set { SetValue(value); }
        }
    }
}
