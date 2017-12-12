namespace HistoryMedicalModels
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class UrinarySystemModel
    {
        [Key]
        public int IdUrinarySystem { get; set; }
        public bool PainUrinate { get; set; } //Dolor al Orinar
         public string ColorUrine { get; set; }//Color Orina
         public string SmellUrine { get; set; }//Olor Orina
         public bool BurningUrinating { get; set; }//Ardor Al Orinar
         public bool PainRelations { get; set; }//Dolor Relaciones Sexuales
         public bool Genitalsecretions { get; set; }//Secreciones Genitales
        public string Contraceptivemethod { get; set; }
         //Llave Foranea
        public int IdHistoryMedical { get; set; }
        
        
        

    }
}
