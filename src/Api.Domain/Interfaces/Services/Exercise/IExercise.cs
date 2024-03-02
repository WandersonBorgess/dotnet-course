using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Exercise;

namespace Api.Domain.Interfaces.Services.Exercise {
    public interface IExerciseService {
        Task<ExerciseDto> Get(Guid id);
        
        Task<IEnumerable<ExerciseDto>> GetAll();

        Task<ExerciseDtoCreateResult> Post(ExerciseDtoCreate exercise);
        
        Task<ExerciseDtoUpdateResult> Put(ExerciseDtoUpdate exercise);
        
        Task<bool> Delete(Guid id);
    }
}