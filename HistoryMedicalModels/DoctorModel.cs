namespace HistoryMedicalModels
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class DoctorModel
    {
        [Key]
        public int IdDoctor { get; set; }
        public string DniDoctor { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Address { get; set; }
        public string NumberCmp { get; set; }//Numero de Colegiatura
        public string Specialty { get; set; }//Especialidad Principal
        public DateTime BirthDate { get; set; }//Fecha de Nacimiento
        public string MailAddress { get; set; }
        public string Phone { get; set; }
        public int City { get; set; }
        public int Departament { get; set; }
        public int Country { get; set; }
    }
}
