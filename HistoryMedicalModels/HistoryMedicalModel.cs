

namespace HistoryMedicalModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class HistoryMedicalModel
    {
        [Key]
        public int IdHistoryMedical { get; set; }
        public string CodeHistoryMedical { get; set; }
        public DateTime AdmissionDate { get; set; }//Fecha de ingreso
        public DateTime UpdateDate { get; set; }//Fecha de Modificacion ultima
       
    }
}
