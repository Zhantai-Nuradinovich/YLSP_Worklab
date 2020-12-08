using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBoilerplate.Shared.DataInterfaces
{
    public interface ICourse
    {
        int Id { get; set; }
        String DirectionName { get; set; }
        String CourseName { get; set; }
        String PicturePath { get; set; }
        String Annotation { get; set; }
        DateTime When { get; set; }
        ICollection<IComment> Comments { get; }
        ICollection<IText> Texts { get; }
        ICollection<IQuiz> Quizzes { get; }
    }
}
