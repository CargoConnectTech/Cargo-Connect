using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CargoConnect.Application.DTOs.Booking;
using CargoConnect.Application.DTOs.Transaction;
using CargoConnect.Application.DTOs.Vehical;
using CargoConnect.Domain.Entities;

namespace CargoConnect.Application.Utilities
{
    public class ApplicationMappingProfile : Profile
    {
        public ApplicationMappingProfile() 
        {
            //user mapping
            CreateMap<UserEntity, UserViewDTO>();
            CreateMap<UserCreateDTO, UserEntity>();
            CreateMap<UserUpdateDTO, UserEntity>();

            //Driver Mapping
            CreateMap<DriverEntity, DriverViewDTO>();
            CreateMap<DriverCreateDTO, DriverEntity>();
            CreateMap<DriverUpdateDTO, DriverEntity>();

            //Booking Mapping
            CreateMap<BookingEntity, BookingViewDTO>();
            CreateMap<BookingCreateDTO, BookingEntity>();
            CreateMap<BookingUpdateDTO, BookingEntity>();

            //Vehical Mapping
            CreateMap<VehicalEntity, VehicalViewDTO>();
            CreateMap<VehicalCreateDTO, VehicalEntity>();
            CreateMap<VehicalUpdateDTO, VehicalEntity>();

            //Transaction Mapping
            CreateMap<TransactionEntity, TransactionViewDTO>();
            CreateMap<TransactionCreateDTO, TransactionEntity>();
        }
    }
}
