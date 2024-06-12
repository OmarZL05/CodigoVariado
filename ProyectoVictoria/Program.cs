using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using ProyectoVictoria;

namespace ProyectoVictoria
{

    /// <summary>
    /// 
    /// </summary>


    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            nodo lista6 = new nodo(6, null);
            nodo lista5 = new nodo(5, lista6);
            nodo lista4 = new nodo(4, lista5);
            nodo lista3 = new nodo(3, lista4);
            nodo lista2 = new nodo(2, lista3);
            nodo lista1 = new nodo(1, lista2);
            nodo lista = new nodo(lista1);

            eliminarLES(lista1, 4);

        }


        public static void eliminarLES(nodo lista, int n) {
            nodo actual, aux;
            int cont = 0;

            actual = lista;

            if (cont == n && lista.sig != null)
            {
                lista = actual.sig;
                actual = null;
            }
            else
            {
                while (actual != null) {
                    if(cont+1 == n) {
                    aux = actual.sig;
                    actual.sig = actual.sig.sig;
                    aux = null;
                    }
                    cont++;
                    actual = actual.sig;
                }
                
            }

        }

    }



    public class nodo
    {
        public dynamic dato;
        public nodo sig;

        public nodo() {
            sig = null;
        }

        public nodo(nodo sig)
        {
            this.sig = sig;
        }

        public nodo(dynamic dato)
        {
            this.dato = dato;
            sig = null;
        }

        public nodo(dynamic dato, nodo sig)
        {
            this.dato = dato;
            this.sig = sig;
        }
    }

}