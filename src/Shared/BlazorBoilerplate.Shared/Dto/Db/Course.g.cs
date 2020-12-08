using BlazorBoilerplate.Shared.DataInterfaces;
using Breeze.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlazorBoilerplate.Shared.Dto.Db
{
    public partial class Course : BaseEntity, ICourse
    {
        public int Id
        {
            get { return GetValue<int>(); }
            set { SetValue(value); }
        }

        public String DirectionName
        {
            get { return GetValue<String>(); }
            set { SetValue(value); }
        }

        public String CourseName
        {
            get { return GetValue<String>(); }
            set { SetValue(value); }
        }

        public String PicturePath
        {
            get { return GetValue<String>(); }
            set { SetValue(value); }
        }

        public String Annotation
        {
            get { return GetValue<String>(); }
            set { SetValue(value); }
        }

        public DateTime When
        {
            get { return GetValue<DateTime>(); }
            set { SetValue(value); }
        }

        ICollection<IComment> ICourse.Comments { get => Comments.Select(i => (IComment)i).ToList(); }

        public NavigationSet<Comment> Comments
        {
            get { return GetValue<NavigationSet<Comment>>(); }
        }

        ICollection<IText> ICourse.Texts { get => Texts.Select(i => (IText)i).ToList(); }

        public NavigationSet<Text> Texts
        {
            get { return GetValue<NavigationSet<Text>>(); }
        }

        ICollection<IQuiz> ICourse.Quizzes { get => Quizzes.Select(i => (IQuiz)i).ToList(); }

        public NavigationSet<Quiz> Quizzes
        {
            get { return GetValue<NavigationSet<Quiz>>(); }
        }
    }
}
