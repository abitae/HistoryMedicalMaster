namespace HistoryMedicalModels
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class HistoryMedicalModel
    {
        [Key]
        public int IdHistoryMedical { get; set; }
        public string CodeHistoryMedical { get; set; }
        public DateTime AdmissionDate { get; set; }//Fecha de ingreso
        public DateTime UpdateDate { get; set; }//Fecha de Modificacion ultima
       //Llave foranea
        public int IdClient { get; set; }
    }
}
