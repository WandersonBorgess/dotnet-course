using System;

namespace Api.Domain.Models {
    public class ExerciseModel {
        private Guid _id;

        public Guid Id { get { return _id; } set { _id = value; } }

        private string _name;
        public string Name { get { return _name; } set { _name = value; } }

        private string _weight;
        public string Weight { get { return _weight; } set { _weight = value; } }

        private string _reps;
        public string Reps { get { return _reps; } set { _reps = value; } }

        private string _series;
        public string Series { get { return _series; } set { _series = value; } }

        private DateTime _createAt;

        public DateTime CreateAt { get { return _createAt; } set { _createAt = value == null ? DateTime.UtcNow : value; } }

        private DateTime _updateAt;

        public DateTime UpdateAt { get { return _updateAt; } set { _updateAt = value; } }
    }
}