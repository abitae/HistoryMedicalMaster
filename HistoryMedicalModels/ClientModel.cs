namespace HistoryMedicalModels
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class ClientModel
    {   [Key]
        public int IdClient { get; set; }
        public string DniClient { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Address { get; set; }
        public DateTime AdmissionDate { get; set; }//Fecha de ingreso
        public DateTime UpdateDate { get; set; }//Fecha de Modificacion ultima
        public DateTime BirthDate { get; set; }//Fecha de Nacimiento
        public string EducationalLevel { get; set; }//Nivel de educacion
        public string MailAddress { get; set; }
        public string Phone { get; set; }
        public string BloodType { get; set; }//Grupo Sanguineo
        //Llave foraneas
        public int IdCity { get; set; }
        public int IdDepartament  { get; set; }
        public int IdCountry { get; set; }
    }
}
