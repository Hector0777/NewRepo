using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR6_DOBLE
{
    internal class ListaCirc<Tipo>
    {
       public Nodo<Tipo> Inicio;
       public Nodo<Tipo> Fin;
        public ListaCirc()
        {
            Inicio = null;
            Fin = null;
        }

        public void Insertar(ref ListaCirc<Tipo> L, Tipo X)
        {
            Nodo<Tipo> q = new Nodo<Tipo>(X);
            if (L.Inicio == null)
            {
                L.Inicio = L.Fin = q;
                q.Liga = L.Inicio;
            }
            else
            {
                q.Liga = L.Inicio;
                L.Fin.Liga= q;
                L.Fin = q;
            }
        }

        public void Desplegar(ListaCirc<Tipo> L, ListBox LBox)
        {
            Nodo<Tipo> p = null;
            LBox.Items.Clear();
            if (L.Inicio != null)
            {
                p = Inicio;
                do 
                {
                    LBox.Items.Add(p.Dato);
                    p = p.Liga;
                }while (p != Inicio);
            }
            else
                MessageBox.Show("Lista vacia");
        }
    }
}
