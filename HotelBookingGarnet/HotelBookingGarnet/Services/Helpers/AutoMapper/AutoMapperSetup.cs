﻿using AutoMapper;
using HotelBookingGarnet.Services.Helpers.AutoMapper.Profiles;
using Microsoft.Extensions.DependencyInjection;

namespace HotelBookingGarnet.Services.Helpers.AutoMapper
{
    public static class AutoMapperSetup
    {
        public static void SetUpAutoMapper(this IServiceCollection services)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new BedFromBedViewModel());
                cfg.AddProfile(new HotelFromHotelViewModel());
                cfg.AddProfile(new HotelViewModelFromHotel());
                cfg.AddProfile(new RoomFromRoomViewModel());
            });

            var mapper = config.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}