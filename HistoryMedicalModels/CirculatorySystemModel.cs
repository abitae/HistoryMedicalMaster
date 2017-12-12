namespace HistoryMedicalModels
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class CirculatorySystemModel
    {
      public int IdCirculatorySystem { get; set; }
      public bool Palpitaciones { get; set; }
      public bool Fatigue { get; set; }
      public bool ChestPain { get; set; } //Dolor de pecho
      public bool SwollenFaceHandsFeet { get; set; }//Hinchado de manos cara y pies
      public bool Dizziness { get; set; }//Mareos
      public bool Numbness { get; set; }//Adormecimiento
      public bool Cramps { get; set; }//Calambres
      //Llave Foranea
      public int IdHistoryMedical { get; set; }
    }
}
