using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PuWeb.Controllers
{
    [ApiController]
    [Authorize]
    [Route("[controller]")]
    public class ApiControllerBase : ControllerBase
    {
    }

}

