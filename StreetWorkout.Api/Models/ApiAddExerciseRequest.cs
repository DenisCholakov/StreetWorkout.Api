﻿namespace StreetWorkout.Api.Models
{
    public class ApiAddExerciseRequest
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public List<int> EquipmentToAdd { get; set; }
    }
}
