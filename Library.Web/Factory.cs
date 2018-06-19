﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Model;
using Library.Web.Models;

namespace Library.Web
{
    public static class Factory
    {
        public static IBooks GetBookInstance()
        {
            return new Books();
        }

        public static IAuthors GetAuthorInstance()
        {
            return new Authors();
        }

        public static IReserve GetReserveInstace(string userId, BookIds book)
        {
            return new Reserve
            {
                UserId = userId,
                BookIds = book
            };
        }
        public static IApplicationUser GetApplicationUserInstance()
        {
            return new ApplicationUser();
        }

        public static IReserveViewModel GetReserveViewModel()
        {
            return new ReserveViewModel();
        }

        public static ILog GetLogInstance()
        {
            return new Log();
        }
    }
}