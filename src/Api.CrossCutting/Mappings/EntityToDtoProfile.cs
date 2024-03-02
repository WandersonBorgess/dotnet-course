using Api.Domain.Dtos.Exercise;
using Api.Domain.Dtos.User;
using Api.Domain.Entities;
using AutoMapper;

namespace Api.CrossCutting.Mappings {
    public class EntityToDtoProfile: Profile {
        public EntityToDtoProfile () {
            CreateMap<UserDto, UserEntity>().ReverseMap();
            CreateMap<UserDtoCreateResult, UserEntity>().ReverseMap();
            CreateMap<UserDtoUpdateResult, UserEntity>().ReverseMap();

            CreateMap<ExerciseDto, ExerciseEntity>().ReverseMap();
            CreateMap<ExerciseDtoCreateResult, ExerciseEntity>().ReverseMap();
            CreateMap<ExerciseDtoUpdateResult, ExerciseEntity>().ReverseMap();
        }
    } 
}