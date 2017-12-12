namespace HistoryMedicalModels
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class PersonalHistoryPathologicalModel
    {
        public int IdPersonalHistoryPathological { get; set; }
        public string SurgicalInterventionDetail { get; set; }
        public DateTime SurgicalInterventionDate { get; set; }
        public string Complications { get; set; }
        //Llave Foranea
        public int IdHistoryMedical { get; set; }
    }
}
