﻿using Autofac;
using InfoNovitas.LoginSample.Model.Authors;
using InfoNovitas.LoginSample.Repositories;
using InfoNovitas.LoginSample.Repositories.Authors;
using InfoNovitas.LoginSample.Repositories.Users;
using InfoNovitas.LoginSample.Services;
using InfoNovitas.LoginSample.Services.Impl;

namespace InfoNovitas.LoginSample.Web.Api
{
    public class LoginSampleModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserRepository>().As<IUserRepository>();
            builder.RegisterType<AuthorRepository>().As<IAuthorRepository>();

            builder.RegisterType<UserService>().As<IUserService>();
            builder.RegisterType<AuthorService>().As<IAuthorService>();
        }
    }
}