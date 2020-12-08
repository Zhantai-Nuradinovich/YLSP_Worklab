using BlazorBoilerplate.Shared.DataInterfaces;
using Breeze.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlazorBoilerplate.Shared.Dto.Db
{
    public partial class Quiz : BaseEntity, IQuiz
    {
        public int Id
        {
            get { return GetValue<int>(); }
            set { SetValue(value); }
        }

        public String QuizName
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

        //ICollection<IQuizItem> IQuiz.Items { get => Items.Select(i => (IQuizItem)i).ToList(); set => Items = (NavigationSet<QuizItem>)value; }


        //public NavigationSet<QuizItem> Items
        //{
        //    get { return GetValue<NavigationSet<QuizItem>>(); }
        //    set { SetValue(value); }
        //}

        ICollection<IQuizItem> IQuiz.Items { get => Items.Select(i => (IQuizItem)i).ToList(); }


        public NavigationSet<QuizItem> Items
        {
            get { return GetValue<NavigationSet<QuizItem>>(); }
        }

        ICourse IQuiz.Course { get => Course; set => Course = (Course)value; }

        public Course Course
        {
            get { return GetValue<Course>(); }
            set { SetValue(value); }
        }
    }
}
