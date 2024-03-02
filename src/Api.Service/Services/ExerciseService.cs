using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Exercise;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.Exercise;
using Api.Domain.Models;
using AutoMapper;

namespace Api.Service.Services {
    public class ExerciseService: IExerciseService {
        private IRepository<ExerciseEntity> _repository;
        private readonly IMapper _mapper;

        public ExerciseService(IRepository<ExerciseEntity> repository, IMapper mapper) {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ExerciseDto> Get(Guid id) {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<ExerciseDto>(entity);
        }

        public async Task<IEnumerable<ExerciseDto>> GetAll() {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<ExerciseDto>>(listEntity);
        }

        public async Task<ExerciseDtoCreateResult> Post(ExerciseDtoCreate exercise) {
            var model = _mapper.Map<ExerciseModel>(exercise);
            var entity = _mapper.Map<ExerciseEntity>(model);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<ExerciseDtoCreateResult>(result);
        }

        public async Task<ExerciseDtoUpdateResult> Put(ExerciseDtoUpdate exercise) {
            var model = _mapper.Map<ExerciseModel>(exercise);
            var entity = _mapper.Map<ExerciseEntity>(model);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<ExerciseDtoUpdateResult>(result);
        }

        public async Task<bool> Delete(Guid id) {
            return await _repository.DeleteAsync(id); 
        }
    }
}