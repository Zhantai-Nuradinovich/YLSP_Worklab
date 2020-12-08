using BlazorBoilerplate.Shared.DataInterfaces;
using Breeze.Sharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBoilerplate.Shared.Dto.Db
{
    public partial class Text : BaseEntity, IText
    {
        public int Id
        {
            get { return GetValue<int>(); }
            set { SetValue(value); }
        }

        public String TextContent
        {
            get { return GetValue<String>(); }
            set { SetValue(value); }
        }

        public DateTime When
        {
            get { return GetValue<DateTime>(); }
            set { SetValue(value); }
        }

        public int CourseID
        {
            get { return GetValue<int>(); }
            set { SetValue(value); }
        }

        ICourse IText.Course { get => Course; set => Course = (Course)value; }

        public Course Course
        {
            get { return GetValue<Course>(); }
            set { SetValue(value); }
        }
    }
}
