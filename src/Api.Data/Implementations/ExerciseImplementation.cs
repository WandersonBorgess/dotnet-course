using System.Threading.Tasks;
using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Entities;
using Api.Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Implementations { 
    public class ExerciseImplementation : BaseRepository<ExerciseEntity>, IExerciseRepository {
        private DbSet<ExerciseEntity> _dataset;

        public ExerciseImplementation(MyContext context) : base(context) {
            _dataset = context.Set<ExerciseEntity> ();
        }

        public async Task<ExerciseEntity> FindByLogin(string name) {
            return await _dataset.FirstOrDefaultAsync(u => u.Name.Equals(name));
        }
    }
}