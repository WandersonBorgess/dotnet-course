using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;

namespace Api.Domain.Repository {
    public interface IExerciseRepository : IRepository<ExerciseEntity> {
        Task<ExerciseEntity> FindByLogin (string name);
    }
}