namespace HistoryMedicalModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class RespiratorySystemModel
    {
        [Key]
        public int IdRespiratorySystem { get; set; }
        public bool Cough { get; set; }//Tos
        public bool BreastPain { get; set; }//dolor de Pecho
        public bool Backache { get; set; }//Dolor de Espalda
}
