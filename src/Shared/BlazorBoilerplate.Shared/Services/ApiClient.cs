using BlazorBoilerplate.Shared.Dto.Db;
using BlazorBoilerplate.Shared.Interfaces;
using Breeze.Sharp;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorBoilerplate.Shared.Services
{
    public class ApiClient : BaseApiClient, IApiClient
    {
        public ApiClient(HttpClient httpClient, ILogger<ApiClient> logger) : base(httpClient, logger)
        {   }              
        public async Task<UserProfile> GetUserProfile()
        {
            return (await entityManager.ExecuteQuery(new EntityQuery<UserProfile>().From("UserProfile"), CancellationToken.None)).SingleOrDefault();
        }
        public async Task<QueryResult<TenantSetting>> GetTenantSettings()
        {
            return await GetItems<TenantSetting>(from: "TenantSettings", orderBy: i => i.Key);
        }

        public async Task<QueryResult<ApplicationUser>> GetUsers(Expression<Func<ApplicationUser, bool>> predicate = null, int? take = null, int? skip = null)
        {
            return await GetItems("Users", predicate, i => i.UserName, null, take, skip);
        }
        public async Task<QueryResult<ApplicationRole>> GetRoles(Expression<Func<ApplicationRole, bool>> predicate = null, int? take = null, int? skip = null)
        {
            return await GetItems("Roles", predicate, i => i.Name, null, take, skip);
        }

        public async Task<QueryResult<DbLog>> GetLogs(Expression<Func<DbLog, bool>> predicate = null, int? take = null, int? skip = null)
        {
            return await GetItems("Logs", predicate, null, i => i.TimeStamp, take, skip);
        }

        public async Task<QueryResult<ApiLogItem>> GetApiLogs(Expression<Func<ApiLogItem, bool>> predicate = null, int? take = null, int? skip = null)
        {
            return await GetItems("ApiLogs", predicate, null, i => i.RequestTime, take, skip);
        }
        public async Task<QueryResult<Todo>> GetToDos()
        {
            return await GetItems<Todo>(from: "Todos", orderByDescending: i => i.CreatedOn);
        }

        public async Task<QueryResult<Course>> GetCourses()
        {
            return await GetItems<Course>(from: "Courses", orderByDescending: i => i.DirectionName);
        }

        public async Task<QueryResult<Quiz>> GetQuizzes(Int32 courseID)
        {
            return await GetItems<Quiz>(from: "Quizzes", predicate: i => i.CourseID == courseID, orderByDescending: j => j.When);
        }

        public async Task<QueryResult<QuizItem>> GetQuizItems(Int32 quizID)
        {
            return await GetItems<QuizItem>(from: "QuizItems", predicate: i => i.QuizID == quizID, orderByDescending: i => i.When);
        }


        public async Task<QueryResult<Text>> GetTexts(Int32 courseID)
        {
            return await GetItems<Text>(from: "Texts", predicate: i => i.CourseID == courseID, orderByDescending: i => i.When);
        }

        public async Task<QueryResult<Comment>> GetComments(Int32 courseID)
        {
            return await GetItems<Comment>(from: "Comments", predicate: i => i.CourseID == courseID, orderByDescending: i => i.When);
        }
    }
}
