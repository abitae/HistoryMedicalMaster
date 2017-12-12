﻿namespace HistoryMedicalModels
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class MuscleSystemModel
    {
        [Key]
        public int IdMuscleSystem { get; set; }
        public bool MusclePain { get; set; }//Dolor Muscular
        public bool JointPain { get; set; }//Dolor Articular
    
    public int IdHistoryMedical { get; set; }
    }
}
