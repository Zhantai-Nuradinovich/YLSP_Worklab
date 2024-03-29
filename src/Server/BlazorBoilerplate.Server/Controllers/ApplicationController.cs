﻿using BlazorBoilerplate.Infrastructure.Storage.DataModels;
using BlazorBoilerplate.Storage;
using Breeze.AspNetCore;
using Breeze.Persistence;
using Breeze.Persistence.EFCore;
using IdentityServer4.AccessTokenValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBoilerplate.Server.Controllers
{
    [Route("api/data/[action]")]
    [Authorize(AuthenticationSchemes = AuthSchemes)]
    [BreezeQueryFilter]
    public class ApplicationController : Controller
    {
        private const string AuthSchemes =
            "Identity.Application" + "," + IdentityServerAuthenticationDefaults.AuthenticationScheme; //Cookie + Token authentication

        private ApplicationPersistenceManager persistenceManager;
        public ApplicationController(ApplicationPersistenceManager persistenceManager)
        {
            this.persistenceManager = persistenceManager;
        }

        [AllowAnonymous]
        [HttpGet]
        public string Metadata()
        {
            return persistenceManager.Metadata();
        }

        [HttpGet]
        public Task<UserProfile> UserProfile()
        {
            return persistenceManager.GetUserProfile();
        }

        [AllowAnonymous]
        [HttpGet]
        public IQueryable<TenantSetting> TenantSettings()
        {
            return persistenceManager.GetEntities<TenantSetting>();
        }

        [HttpGet]
        public IQueryable<ApplicationUser> Users()
        {
            return persistenceManager.GetEntities<ApplicationUser>().Include(i => i.UserRoles).ThenInclude(i => i.Role).OrderBy(i => i.UserName);
        }

        [HttpGet]
        public IQueryable<ApplicationRole> Roles()
        {
            return persistenceManager.GetEntities<ApplicationRole>().OrderBy(i => i.Name);
        }

        [AllowAnonymous]
        [HttpGet]
        public IQueryable<Todo> Todos()
        {
            return persistenceManager.GetEntities<Todo>().Include(i => i.CreatedBy).Include(i => i.ModifiedBy).OrderBy(i => i.Id);
        }

        [HttpGet]
        public IQueryable<Course> Courses()
        {
            return persistenceManager.GetEntities<Course>().OrderBy(i => i.Id);
        }

        [HttpGet]
        public IQueryable<Comment> Comments()
        {
            return persistenceManager.GetEntities<Comment>().OrderByDescending(i => i.When);
        }

        [HttpGet]
        public IQueryable<Quiz> Quizzes()
        {
            return persistenceManager.GetEntities<Quiz>().OrderByDescending(i => i.When);
        }

        [HttpGet]
        public IQueryable<QuizItem> QuizItems()
        {
            return persistenceManager.GetEntities<QuizItem>().OrderByDescending(i => i.When);
        }

        [HttpGet]
        public IQueryable<Text> Texts()
        {
            return persistenceManager.GetEntities<Text>().OrderByDescending(i => i.When);
        }

        [HttpGet]
        public IQueryable<DbLog> Logs()
        {
            return persistenceManager.GetEntities<DbLog>().AsNoTracking().OrderByDescending(i => i.TimeStamp);
        }

        [HttpGet]
        public IQueryable<ApiLogItem> ApiLogs()
        {
            return persistenceManager.GetEntities<ApiLogItem>().AsNoTracking().OrderByDescending(i => i.RequestTime);
        }

        [AllowAnonymous]
        [HttpPost]
        public SaveResult SaveChanges([FromBody] JObject saveBundle)
        {
            try
            {
                return persistenceManager.SaveChanges(saveBundle);
            }
            catch (Exception ex)
            {
                var errors = new List<EFEntityError>();
                errors.Add(new EFEntityError(null, null, ex.GetBaseException().Message, null));
                throw new EntityErrorsException(errors);
            }
        }
    }
}
