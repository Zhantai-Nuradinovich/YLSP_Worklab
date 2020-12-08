using BlazorBoilerplate.Shared.DataInterfaces;
using Breeze.Sharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBoilerplate.Shared.Dto.Db
{
    public partial class QuizItem : BaseEntity, IQuizItem
    {
        public int Id
        {
            get { return GetValue<int>(); }
            set { SetValue(value); }
        }

        public String Question
        {
            get { return GetValue<String>(); }
            set { SetValue(value); }
        }

        public String QuestionType
        {
            get { return GetValue<String>(); }
            set { SetValue(value); }
        }

        public String PicturePath
        {
            get { return GetValue<String>(); }
            set { SetValue(value); }
        }

        public String Answers
        {
            get { return GetValue<String>(); }
            set { SetValue(value); }
        }

        public String RightAnswer
        {
            get { return GetValue<String>(); }
            set { SetValue(value); }
        }

        public DateTime When
        {
            get { return GetValue<DateTime>(); }
            set { SetValue(value); }
        }

        public int QuizID
        {
            get { return GetValue<int>(); }
            set { SetValue(value); }
        }

        IQuiz IQuizItem.Quiz { get => Quiz; set => Quiz = (Quiz)value; }

        public Quiz Quiz
        {
            get { return GetValue<Quiz>(); }
            set { SetValue(value); }
        }
    }
}
