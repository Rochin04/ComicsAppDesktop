using ComicsAPPDesktop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicsAPPDesktop.Listas
{
    public  class Nodo
    {
        public ComicsModel Comics { get; set; }
        public Nodo Siguiente { get; set; }
        public Nodo(ComicsModel comics)
        {
            Comics = comics;
            Siguiente = null;
        }
    }
}
