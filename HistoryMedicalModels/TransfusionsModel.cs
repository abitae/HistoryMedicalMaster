namespace HistoryMedicalModels
{ 
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class TransfusionsModel
    {
        [Key]
        public int IdTransfusions { get; set; }
        public string TransfusionsReason { get; set; }//MOtivo de transfucion
        public DateTime TransfusionsDate { get; set; }
        public string TransfusionsComplications { get; set; }
        //Llave Foranea
        public int IdClient { get; set; }
    }
}
