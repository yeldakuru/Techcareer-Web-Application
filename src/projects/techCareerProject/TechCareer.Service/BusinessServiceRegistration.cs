﻿using System.Reflection;
using Core.AOP.Helpers;
using Core.CrossCuttingConcerns.Rules;
using Core.CrossCuttingConcerns.Serilog;
using Core.CrossCuttingConcerns.Serilog.Loggers;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using TechCareer.Service.Abstracts;
using TechCareer.Service.Concretes;
using TechCareer.Service.Rules;

namespace TechCareer.Service
{
    public static class BusinessServiceRegistration
    {
        public static IServiceCollection AddServiceDependencies(this IServiceCollection services)
        {
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddSubClassesOfType(Assembly.GetExecutingAssembly(), typeof(BaseBusinessRules));
            services.AddScoped<LoggerServiceBase, FileLogger>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserWithTokenService, UserWithTokenService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IEventService, EventService>();
            services.AddScoped<IInstructorService, InstructorService>();
            services.AddScoped<IUserOperationClaimService, UserOperationClaimService>();
            services.AddScoped<IVideoEducationService, VideoEducationService>();
            services.AddScoped<CategoryBusinessRules>();
            return services;
        }

        public static IServiceCollection AddSubClassesOfType(this IServiceCollection services, Assembly assembly, Type type, Func<IServiceCollection, Type, IServiceCollection>? addWithLifeCycle = null)
        {
            var types = assembly.GetTypes().Where(t => t.IsSubclassOf(type) && type != t).ToList();
            foreach (var item in types)
                if (addWithLifeCycle == null)
                    services.AddScoped(item);
                else
                    addWithLifeCycle(services, type);
            return services;
        }
    }
}
