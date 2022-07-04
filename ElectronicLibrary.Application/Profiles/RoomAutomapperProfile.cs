﻿using AutoMapper;
using ElectronicLibrary.Application.CQRS.Room.Commands;
using ElectronicLibrary.Domain.Entities;
using ElectronicLibrary.Infrastructure.Models;
using ElectronicLibrary.Infrastructure.Models.Room;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicLibrary.Application.Profiles
{
    /// <summary>
    /// Automapper class for Room entity
    /// </summary>
    public class RoomAutomapperProfile : Profile
    {
        public RoomAutomapperProfile(FileConfiguration fileConfiguration)
        {
            CreateMap<AddRoomCommand, Room>()
                .ForMember(dest => dest.Height, opt => opt.MapFrom(src => src.Height))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.TotalMaxPlaces, opt => opt.MapFrom(src => src.TotalMaxPlaces))
                .ForMember(dest => dest.TotalMaxTables, opt => opt.MapFrom(src => src.TotalMaxTables))
                .ForMember(dest => dest.Width, opt => opt.MapFrom(src => src.Width))
                .ForMember(dest => dest.File, opt => opt.Ignore());

            CreateMap<Room, RoomListModel>()
                .ForMember(dest => dest.FileAddress, opt => opt.MapFrom(x => String.Format(fileConfiguration.FileControllerAddress, x.File.Id)));
        }
    }
}