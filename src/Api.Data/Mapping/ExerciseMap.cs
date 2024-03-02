using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping {
    public class ExerciseMap : IEntityTypeConfiguration<ExerciseEntity>
    {
        public void Configure(EntityTypeBuilder<ExerciseEntity> builder)
        {
            builder.ToTable("Exercise");
            builder.HasKey(exercise => exercise.Id);
            builder.Property(exercise => exercise.Name).IsRequired().HasMaxLength(60);
            builder.Property(exercise => exercise.Weight).IsRequired().HasMaxLength(60);
            builder.Property(exercise => exercise.Reps).IsRequired().HasMaxLength(60);
            builder.Property(exercise => exercise.Series).IsRequired().HasMaxLength(60);
        }
    }
}