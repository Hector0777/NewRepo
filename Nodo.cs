using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR6_DOBLE
{
    internal class Nodo<T1>
    {
        T1 dato;
        Nodo<T1> liga;
        public int px;
        public int py;

        public Nodo(T1 dt)
        {
            Dato = dt;
            Liga = null;
            px = py = 0;


        }//sigues sin ver el forms?
        //asies
        //solo veo la clase nodo
        //y esta vacia la clase nodo?
        //no

        //deja veo si te puedo compartir las demas clases

        public T1 Dato { get => dato; set => dato = value; }//aqui esta un metodo
        public Nodo<T1> Liga { get => liga; set => liga = value; }
    }
}
