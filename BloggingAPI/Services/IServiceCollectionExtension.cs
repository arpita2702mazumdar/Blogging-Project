using AutoMapper;
using BloggingAPI.Contracts;
using BloggingAPI.Services.Mapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloggingAPI.Services
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddServiceDependencies(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(CommentMapProfile));
            services.AddScoped(typeof(IBlogService), typeof(BlogService));
            services.AddScoped(typeof(ICommentsService), typeof(CommentsService));
            services.AddScoped(typeof(ILoginService), typeof(LoginService));

            return services;
        }
    }
}
