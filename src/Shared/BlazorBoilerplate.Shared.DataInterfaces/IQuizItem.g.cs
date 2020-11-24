using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBoilerplate.Shared.DataInterfaces
{
    public interface IQuizItem
    {
        Int32 Id { get; set; }

        String Question { get; set; }

        String QuestionType { get; set; }

        String Answers { get; set; }

        String RightAnswer { get; set; }

        String PicturePath { get; set; }

        DateTime When { get; set; }

        Int32 QuizID { get; set; }

        IQuiz Quiz { get; set; }
    }
}
