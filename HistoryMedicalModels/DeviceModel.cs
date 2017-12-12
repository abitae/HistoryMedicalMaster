namespace HistoryMedicalModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class deviceModel
    {
        public int IdDevice { get; set; }
        public string Name { get; set; }
        public string NameSystem { get; set; }
        public bool State { get; set; }
        public Date UpdateDevice { get; set; }
        //Llave Foranea
        public int IdClient { get; set; }
 }
}