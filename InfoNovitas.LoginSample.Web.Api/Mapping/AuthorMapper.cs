﻿using InfoNovitas.LoginSample.Services.Messaging.Views.Authors;
using InfoNovitas.LoginSample.Web.Api.Models.Authors;
using System.Collections.Generic;
using System.Linq;

namespace InfoNovitas.LoginSample.Web.Api.Mapping
{
    public static class AuthorMapper
    {
        public static AuthorViewModel MapToViewModel(this Author view)
        {
            if (view == null)
                return null;
            return new AuthorViewModel()
            {
                Id = view.Id,
                DateCreated = view.DateCreated,
                UserCreated = view.UserCreated.MapToViewModel(),
                FirstName = view.FirstName,
                LastName = view.LastName,
                LastModified = view.LastModified,
                UserLastModified = view.UserLastModified.MapToViewModel()
            };
        }

        public static List<AuthorViewModel> MapToViewModels(this IEnumerable<Author> views)
        {
            var result = new List<AuthorViewModel>();
            if (views == null)
                return result;
            result.AddRange(views.Select(item => item.MapToViewModel()));
            return result;
        }
    }
}