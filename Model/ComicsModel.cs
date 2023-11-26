using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicsAPPDesktop.Model
{
    public class ComicsModel
    {
        private int IdComic;
        public string Tags { get; set; }//con esto se puede filtrar XD
        public string Publisher { get; set; }//con esto se puede filtrar XD
        public string? DateAdded { get; set; }//con esto se puede filtrar XDD
        public string DateRelease { get; set; }//con esto se puede filtrar XD
        public string? Type { get; set; }
        public string? Writer { get; set; }
        public string? Artist { get; set; }
        public ComicsModel()
        {
            IdComic++;
        }
    }
   
}
