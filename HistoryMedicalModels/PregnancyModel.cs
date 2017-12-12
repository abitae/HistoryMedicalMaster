namespace HistoryMedicalModels
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class PregnancyModel
    {
        [Key]
        public int IdPregnancy { get; set; } //Embarazo
        public DateTime LastRuleDate { get; set; }//Ultima Regla
        public DateTime BirthDate { get; set; }//Fecha aproximada de parto
        public DateTime PregnancyWeeks { get; set; }//Semanas de Embarazo
        public string Symptom { get; set; }//Sintomas
        public string Background { get; set; }//Antecedentes
        

    }
}
