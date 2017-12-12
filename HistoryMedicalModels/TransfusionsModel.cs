namespace HistoryMedicalModels
{ 
    using System;
    using System.ComponentModel.DataAnnotations;
    public class TransfusionsModel
    {
        [Key]
        public int IdTransfusions { get; set; }
        public string TransfusionsReason { get; set; }//MOtivo de transfucion
        public DateTime TransfusionsDate { get; set; }
        public string TransfusionsComplications { get; set; }
        //Llave Foranea
        public int IdHistoryMedical { get; set; }
    }
}
