using BlazorBoilerplate.Shared.DataInterfaces;
using Breeze.Sharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBoilerplate.Shared.Dto.Db
{
    public partial class Text : BaseEntity, IText
    {
        public Int32 Id
        {
            get { return GetValue<Int32>(); }
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

        public Int32 CourseID
        {
            get { return GetValue<Int32>(); }
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
