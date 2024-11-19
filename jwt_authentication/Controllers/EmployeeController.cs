﻿using jwt_authentication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace jwt_authentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        [Route("GetData")]

        public string GetData()
        {
            return "Authenticated with JWT";
        }
        [HttpGet]
        [Route("Details")]

        public string Details()
        {
            return "Authenticated with JWT";
        }

        [Authorize]
        [HttpPost]
        public string AddUser(Users user)
        {
            return "User added with username" + user.Username;
        }
    }
}
