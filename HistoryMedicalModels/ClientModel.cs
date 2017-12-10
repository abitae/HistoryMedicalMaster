using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoryMedicalModels
{
    public class ClientModel
    {
        public int IdClient { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }//Fecha de Nacimiento
        public string EducationalLevel { get; set; }//Nivel de educacion
        public string MailAddress { get; set; }
        public string Phone { get; set; }
        public string BloodType { get; set; }//Grupo Sanguineo
        public int City { get; set; }
        public int Departament  { get; set; }
        public int Country { get; set; }
    }
}
