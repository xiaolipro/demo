﻿using Antinew.AspNetCore3._1.Demo.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Antinew.AspNetCore3._1.Demo.Utility
{
    public static class CookieSessionHelper
    {
        public static void SetCookies(this HttpContext httpContext, string key, string value, int minutes = 30)
        {
            httpContext.Response.Cookies.Append(key, value, new CookieOptions
            {
                Expires = DateTime.Now.AddMinutes(minutes)
            });
        }
        public static void DeleteCookies(this HttpContext httpContext, string key)
        {
            httpContext.Response.Cookies.Delete(key);
        }

        public static string GetCookiesValue(this HttpContext httpContext, string key)
        {
            httpContext.Request.Cookies.TryGetValue(key, out string value);
            return value;
        }

        public static CurrentUser GetCurrentUserBySession(this HttpContext context)
        {
            string sUser = context.Session.GetString("CurrentUser");
            if (sUser == null)
            {
                return null;
            }
            else
            {
                CurrentUser currentUser = Newtonsoft.Json.JsonConvert.DeserializeObject<CurrentUser>(sUser);
                return currentUser;
            }
        }
        public static CurrentUser GetCurrentUserByCookie(this HttpContext context)
        {
            string sUser = context.GetCookiesValue("CurrentUser");
            if (sUser == null)
            {
                return null;
            }
            else
            {
                CurrentUser currentUser = Newtonsoft.Json.JsonConvert.DeserializeObject<CurrentUser>(sUser);
                return currentUser;
            }
        }
    }
}
