namespace HistoryMedicalModels
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class DiseasesModel
    {
        [Key]
        public int IdDiseases { get; set; }
        public string DiseasesDetail { get; set; }//Detalle de Enfermedad
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ControlMedication { get; set; }//Medicamento de control
        public string DiseasesComplications { get; set; }//Complicaciones
        //Llave foranea
        public int IdHistoryMedical { get; set; }
    }
}
