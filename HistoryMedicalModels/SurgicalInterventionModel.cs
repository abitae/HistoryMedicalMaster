namespace HistoryMedicalModels
{   using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class SurgicalInterventionModel //Intervencion quirurgica
    {
        [Key]
        public int IdSurgicalIntervention { get; set; }
        public string SurgicalDetail { get; set; }
        public DateTime SurgicalDate { get; set; }
        public string SurgicalComplications { get; set; }
        //Llave Foranea
        public int IdClient { get; set; }
    }
}
