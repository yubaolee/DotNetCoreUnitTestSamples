using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace OpenAuth.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private UserService _service;

        public ValuesController(UserService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("checklogin")]
        public bool CheckLogin([FromQuery]UserInfo user)
        {
            return _service.CheckLogin(user);
        }

    }
}
