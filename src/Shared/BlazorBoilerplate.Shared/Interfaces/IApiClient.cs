using BlazorBoilerplate.Shared.Dto.Db;
using Breeze.Sharp;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BlazorBoilerplate.Shared.Interfaces
{
    public interface IApiClient : IBaseApiClient
    {
        Task<UserProfile> GetUserProfile();

        Task<QueryResult<TenantSetting>> GetTenantSettings();
        Task<QueryResult<ApplicationUser>> GetUsers(Expression<Func<ApplicationUser, bool>> predicate = null, int? take = null, int? skip = null);
        Task<QueryResult<ApplicationRole>> GetRoles(Expression<Func<ApplicationRole, bool>> predicate = null, int? take = null, int? skip = null);

        Task<QueryResult<DbLog>> GetLogs(Expression<Func<DbLog, bool>> predicate = null, int? take = null, int? skip = null);
        Task<QueryResult<ApiLogItem>> GetApiLogs(Expression<Func<ApiLogItem, bool>> predicate = null, int? take = null, int? skip = null);

        Task<QueryResult<Todo>> GetToDos();

        Task<QueryResult<Course>> GetCourses();

        Task<QueryResult<Quiz>> GetQuizzes(Int32 courseID);

        Task<QueryResult<Quiz>> GetQuiz(string quizName);

        Task<QueryResult<QuizItem>> GetQuizItems(Int32 quizID);

        Task<QueryResult<Text>> GetTexts(Int32 courseID);

        Task<QueryResult<Comment>> GetComments(Int32 courseID);
    }
}
