

namespace HistoryMedicalModels
{
    using System.ComponentModel.DataAnnotations;
    public class MuscleSystem
    {
        [Key]
        public int IdMuscleSystem { get; set; }
        public bool MusclePain { get; set; }//Dolor Muscular
        public bool JointPain { get; set; }//Dolor Articular
    }
}
