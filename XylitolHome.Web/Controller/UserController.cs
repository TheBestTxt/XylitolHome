using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using XylitolHome.Domain.Dto;
using XylitolHome.Domain.Entities;
using XylitolHome.Domain.IService;

namespace XylitolHome.Web.Controller
{
    [Route("User")]
    public class UserController : ControllerBase
    {
        private readonly IUserApplication _user;

        public UserController(IUserApplication user)
        {
            _user = user;
        }

        [HttpGet("{id}")]
        public UserEntity Query([FromRoute] string id)
        {
            return _user.Query(id);
        }

        [HttpGet]
        public async Task Add([FromQuery] AddUser request)
        {
            await _user.Add(request);
        }
    }
}
