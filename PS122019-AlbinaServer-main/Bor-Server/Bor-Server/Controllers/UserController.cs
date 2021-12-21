using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Albina.BusinesLogic.Core.Interfaces;
using Albina.BusinesLogic.Core.Models;
using AutoMapper;
using Bor.Core.Models;
using Bor.DataAccess.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bor_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUserService _userService;

        public UserController(IMapper mapper, IUserService userService)
        {
            _mapper = mapper;
            _userService = userService;
        }

        [HttpPost("/auth")]
        public async Task<ActionResult<UserInformationDto>> Auth([FromBody] UserIdentityDto UserIdentityDto)
        {
            UserIdentityBlo userIdentityBlo = _mapper.Map<UserIdentityBlo>(UserIdentityDto);
            UserInformationBlo userInformationBlo = await _userService.Auth(userIdentityBlo);
            UserInformationDto userInformationDto = _mapper.Map<UserInformationDto>(userInformationBlo);
            return userInformationDto;
        }

        [HttpPost("/register")]
        public async Task<ActionResult<UserInformationDto>> Register ([FromBody] UserIdentityDto userIdentityDto)
        {
            UserIdentityBlo userIdentityBlo = _mapper.Map<UserIdentityBlo>(userIdentityDto);
            UserInformationBlo userInformationBlo = await _userService.Register(userIdentityBlo);
            UserInformationDto userInformationDto = _mapper.Map<UserInformationDto>(userInformationBlo);
            return userInformationDto;


        }

        [HttpPost("/register")]
        public async Task<ActionResult<UserInformationDto>> Update([FromBody] UserIdentityDto userIdentityDto)
        {

        }
    }
}
