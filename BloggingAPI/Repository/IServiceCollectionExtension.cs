using BloggingAPI.Model;
using BloggingAPI.Repository.Contracts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloggingAPI.Repository
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddRepositoryDependencies(this IServiceCollection services, string connectionString)
        {
            services.AddScoped<BlogContext>(s => new BlogContext(connectionString));

            services.AddScoped(typeof(IBlogRepository), typeof(BlogRepository));
            services.AddScoped(typeof(ICommentsRepository), typeof(CommentsRepository));
            services.AddScoped(typeof(ILoginRepository), typeof(LoginRepository));

            return services;
        }
    }
}
