﻿// ***********************************************************************
// Assembly         : OpenAuth.WebApi
// Author           : yubaolee
// Created          : 07-11-2016
//
// Last Modified By : yubaolee
// Last Modified On : 07-11-2016
// Contact : 
// File: CheckController.cs
// ***********************************************************************

using System.Web.Mvc;
using Infrastructure;
using OpenAuth.App;
using OpenAuth.App.SSO;

namespace OpenAuth.WebApi.Areas.SSO.Controllers
{
    /// <summary>
    ///  sso验证
    /// <para>其他站点通过后台Post来认证</para>
    /// <para>或使用静态类OpenAuth.App.SSO.AuthUtil访问</para>
    /// </summary>
    public class CheckController : Controller
    {
        private LoginApp _app;
        public CheckController()
        {
            _app = AutofacExt.GetFromFac<LoginApp>();
        }

        public bool GetStatus(string token = "", string requestid = "")
        {
            if (new UserAuthSessionService().GetCache(token))
            {
                return true;
            }

            return false;
        }

        public string GetUser(string token = "", string requestid = "")
        {
            var user = new UserAuthSessionService().Get(token);
            if (user != null)
            {
                return JsonHelper.Instance.Serialize(_app.GetLoginUser(user.UserName));
            }

            return string.Empty;
        }

        [HttpPost]
        public string Login(PassportLoginRequest request)
        {
            return JsonHelper.Instance.Serialize(SSOAuthUtil.Parse(request));
        }
    }
}