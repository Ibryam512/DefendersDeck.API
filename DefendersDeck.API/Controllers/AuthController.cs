﻿using DefendersDeck.Business.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace DefendersDeck.API.Controllers
{
    public class AuthController(IAuthService authService) : BaseController
    {
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] Business.Requests.LoginRequest request)
        {
            var response = await authService.Login(request);

            return response.Success 
                ? Ok(response) 
                : HandleFailure(response);
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] Business.Requests.RegisterRequest request)
        {
            var response = await authService.Register(request);

            return response.Success
                ? Ok(response)
                : HandleFailure(response);
        }
    }
}
