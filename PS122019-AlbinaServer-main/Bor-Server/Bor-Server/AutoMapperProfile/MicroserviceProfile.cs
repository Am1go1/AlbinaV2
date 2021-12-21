﻿using Albina.BusinesLogic.Core.Models;
using Bor.Core.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bor_Server.AutoMapperProfile
{
    public class MicroserviceProfile : Profile
    {
        public  MicroserviceProfile()
        {
            CreateMap<UserInformationBlo, UserInformationDto>();
            CreateMap<UserIdentityBlo, UserIdentityDto>();
            CreateMap<UserIdentityDto, UserIdentityBlo>();

            CreateMap<UserUpdateDto, UserUpdateBlo>();
            CreateMap<UserUpdateBlo, UserUpdateDto>();
        }

    }
}
