namespace HistoryMedicalModels
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class DigestiveSystemModel
    {
        [Key]
       public int IdDigestiveSystem { get; set; }
       public bool StomachPain { get; set; }//Dolor de Estomago
       public bool Constipation { get; set; }//Estreñimiento
       public bool Diarrhea { get; set; }
       public bool Sickness { get; set; }//Nauseas
       public bool Deworm { get; set; }//Desparacitado
       public string DewormDetail { get; set; }
       //Llave
       public int IdHistoryMedical { get; set; }
    }
}
