namespace HistoryMedicalModels
{   using System;
    using System.ComponentModel.DataAnnotations;
    public class SurgicalInterventionModel //Intervencion quirurgica
    {
        [Key]
        public int IdSurgicalIntervention { get; set; }
        public string SurgicalDetail { get; set; }
        public DateTime SurgicalDate { get; set; }
        public string SurgicalComplications { get; set; }
        //Llave Foranea
        public int IdHistoryMedical { get; set; }
    }
}
