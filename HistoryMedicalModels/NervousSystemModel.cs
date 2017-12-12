namespace HistoryMedicalModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class NervousSystemModel
    {   [Key]
        public int IdNervousSystem { get; set; }
        public bool SleepWell { get; set; } //Dormir Bien
        public int SleepingHours { get; set; }//Dormir Horas
        public bool VisionProblem { get; set; }
        public bool AuditionProblem { get; set; }
        public bool SmellProblem { get; set; }//Problema de Olfato
    }
}
