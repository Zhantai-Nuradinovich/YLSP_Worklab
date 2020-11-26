using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBoilerplate.Shared.DataInterfaces
{
    public interface IQuiz
    {
        Int32 Id { get; set; }

        String QuizName { get; set; }

        DateTime When { get; set; }

       // ICollection<IQuizItem> Items { get; set; }
        ICollection<IQuizItem> Items { get; set; }

        Int32 CourseID { get; set; }

        ICourse Course { get; set; }
    }
}
