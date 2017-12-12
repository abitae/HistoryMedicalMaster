namespace HistoryMedicalModels
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class RespiratorySystemModel
    {
        [Key]
        public int IdRespiratorySystem { get; set; }
        public bool Cough { get; set; }//Tos
        public bool BreastPain { get; set; }//dolor de Pecho
        public bool Backache { get; set; }//Dolor de Espalda
    }
}
