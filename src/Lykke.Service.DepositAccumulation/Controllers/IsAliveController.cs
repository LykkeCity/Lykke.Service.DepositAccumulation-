﻿using System;
using Lykke.Service.DepositAccumulation.Models;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.SwaggerGen.Annotations;

namespace Lykke.Service.DepositAccumulation.Controllers
{
    [Route("api/[controller]")]
    public class IsAliveController : Controller
    {
        /// <summary>
        /// Checks service is alive
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [SwaggerOperation("IsAlive")]
        public IsAliveResponse Get()
        {
            return new IsAliveResponse
            {
                Version = Microsoft.Extensions.PlatformAbstractions.PlatformServices.Default.Application.ApplicationVersion,
                Env = Environment.GetEnvironmentVariable("ENV_INFO")
            };
        }
    }
}
