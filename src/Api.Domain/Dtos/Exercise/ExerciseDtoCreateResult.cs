using System;

namespace Api.Domain.Dtos.Exercise {
    public class ExerciseDtoCreateResult {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Weight { get; set; }

        public string Reps { get; set; }

        public string Series { get; set; }

        public DateTime CreateAt { get; set; }
    }
}