using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webApi.Models;

namespace webApi.Controllers
{
    public class LoginController : ApiController
    {
        testEntities db = new testEntities();
        [HttpPost]
        public ApiResponse<Boolean> login([FromBody] login data)
        {
            if (db.logins.Where(m => m.username == data.username && m.password == data.password).Any())
            {
                return new ApiResponse<Boolean> { error = 0, message = "LOGIN SUCCESS", data = true };
            }
            return new ApiResponse<Boolean> { error = 1, message = "LOGIN FAILED", data = false };
        }

        [HttpPost]
        public ApiResponse<Boolean> exist([FromBody] login data)
        {
            if (db.logins.Where(m => m.username == data.username).Any())
            {
                return new ApiResponse<Boolean> { error = 0, message = "LOGIN SUCCESS", data = true };
            }
            return new ApiResponse<Boolean> { error = 1, message = "LOGIN FAILED", data = false };
        }


    }
}