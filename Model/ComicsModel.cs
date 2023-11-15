using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicsAPPDesktop.Model
{
    public class ComicsModel
    { 
        public string Publisher { get; set; }//con esto se puede filtrar XD
        public string Tags { get; set; }//con esto se puede filtrar XD
        public DateTime? DateAdded { get; set; }//con esto se puede filtrar XDD
        public DateTime DateRelease { get; set; }//con esto se puede filtrar XD
        public string Type { get; set; }
        public string? Writer { get; set; }
        public string? Artist { get; set; }
    }
}
