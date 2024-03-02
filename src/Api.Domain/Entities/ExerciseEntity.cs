using System;

namespace Api.Domain.Entities {
    public class ExerciseEntity : BaseEntity {
        public string Name { get; set; }
        public string Weight { get; set; }
        public string Reps { get; set; }
        public string Series { get; set; }
    }
}