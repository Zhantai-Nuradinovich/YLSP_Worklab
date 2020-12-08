using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBoilerplate.Shared.DataInterfaces
{
    public interface IQuiz
    {
        int Id { get; set; }

        String QuizName { get; set; }

        DateTime When { get; set; }

       // ICollection<IQuizItem> Items { get; set; }
        ICollection<IQuizItem> Items { get; }

        int CourseID { get; set; }

        ICourse Course { get; set; }
    }
}
