namespace HistoryMedicalModels
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class AllergiesModel
    {
        [Key]
        public int IdTransfusions { get; set; }
        public string AllergiesReason { get; set; }//Alergia motivo
        public DateTime AllergiesDate { get; set; }
         //Llave Foranea
        public int IdClient { get; set; }
    }
}
