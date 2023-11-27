using ComicsAPPDesktop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicsAPPDesktop.Listas
{
    public class ListaEnlazada
    {
        Nodo primero;
        public ListaEnlazada()
        {
            primero = null;
        }
        public void AgregarComics(ComicsModel comicsModel)
        {
            Nodo nodo = new Nodo(comicsModel);
            nodo.Siguiente = primero;
            primero = nodo;
        }
        public void agregarAlFinal(ComicsModel comicsModel)
        {
            Nodo nodoF = new Nodo(comicsModel);
            if(primero == null)
            {
                primero = nodoF;
            }
            else
            {
                Nodo actualF = primero;
                while(actualF.Siguiente != null)
                {
                   actualF = actualF.Siguiente;
                }
                actualF.Siguiente = nodoF; 
            }
        }
        public void Imprimir()
        {
            Nodo actual = primero;
            while (actual != null)
            {
                MessageBox.Show($"Publicher{actual.Comics.Publisher} {actual.Comics.Tags} {actual.Comics.Type} {actual.Comics.DateAdded} {actual.Comics.DateRelease} {actual.Comics.Writer} {actual.Comics.Artist}");
            }
        }
    }
}
