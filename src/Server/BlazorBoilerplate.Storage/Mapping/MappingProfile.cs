using AutoMapper.Configuration;
using BlazorBoilerplate.Shared.Dto;
using BlazorBoilerplate.Shared.Dto.Admin;
using BlazorBoilerplate.Shared.Dto.Sample;
using Finbuckle.MultiTenant;
using ApiLogItem = BlazorBoilerplate.Infrastructure.Storage.DataModels.ApiLogItem;
using Message = BlazorBoilerplate.Infrastructure.Storage.DataModels.Message;
using Quiz = BlazorBoilerplate.Infrastructure.Storage.DataModels.Quiz;
using QuizItem = BlazorBoilerplate.Infrastructure.Storage.DataModels.QuizItem;
using Text = BlazorBoilerplate.Infrastructure.Storage.DataModels.Text;
using Comment = BlazorBoilerplate.Infrastructure.Storage.DataModels.Comment;
using Course = BlazorBoilerplate.Infrastructure.Storage.DataModels.Course;

namespace BlazorBoilerplate.Storage.Mapping
{
    public class MappingProfile : MapperConfigurationExpression
    {
        /// <summary>
        /// Create automap mapping profiles
        /// </summary>
        public MappingProfile()
        {
            CreateMap<TenantInfo, TenantDto>().ReverseMap();
            CreateMap<Message, MessageDto>().ReverseMap();
            CreateMap<Quiz, QuizDto>().ReverseMap();
            CreateMap<QuizItem, QuizItemDto>().ReverseMap();
            CreateMap<Course, CourseDto>().ReverseMap();
            CreateMap<Comment, CommentDto>().ReverseMap();
            CreateMap<Text, TextDto>().ReverseMap();
        }
    }
}
