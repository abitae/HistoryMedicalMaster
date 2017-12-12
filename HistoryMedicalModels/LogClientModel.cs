namespace HistoryMedicalModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class LogClientModel
    {
        public int IdLogClient { get; set; }
        public DateTime LogDate { get; set; }
        public string LogDetail { get; set; }
        //Llave Foranea
        public int IdClient { get; set; }
 }
}
