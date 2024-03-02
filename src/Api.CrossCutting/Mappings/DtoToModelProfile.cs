using Api.Domain.Dtos.Exercise;
using Api.Domain.Dtos.User;
using Api.Domain.Models;
using AutoMapper;

namespace Api.CrossCutting.Mappings {
    public class DtoToModelProfile : Profile {
        public DtoToModelProfile() {
            CreateMap<UserModel, UserDto>().ReverseMap();
            CreateMap<UserModel, UserDtoCreate>().ReverseMap();
            CreateMap<UserModel, UserDtoUpdate>().ReverseMap();

            CreateMap<ExerciseModel, ExerciseDto>().ReverseMap();
            CreateMap<ExerciseModel, ExerciseDtoCreate>().ReverseMap();
            CreateMap<ExerciseModel, ExerciseDtoUpdate>().ReverseMap();
        }
    } 
}