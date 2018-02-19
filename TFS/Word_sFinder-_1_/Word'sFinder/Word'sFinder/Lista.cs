using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_sFinder
{
    public class Lista<T>
    {
        public int counter { get; set; }

        class Nodo<T>
        {
            public T info;
            public Nodo<T> sig;
        }

        private Nodo<T> raiz, fondo;

        public Lista()
        {
            raiz = null;
            fondo = null;
        }

        public bool Vacia()
        {
            if (raiz == null)
                return true;
            else
                return false;
        }

        public void Insertar(T info)
        {
            Nodo<T> nuevo;
            nuevo = new Nodo<T>();
            nuevo.info = info;
            nuevo.sig = null;
            if (Vacia())
            {
                raiz = nuevo;
                fondo = nuevo;
            }
            else
            {
                fondo.sig = nuevo;
                fondo = nuevo;
            }

            counter++;
        }

        public T Extraer()
        {
            if (!Vacia())
            {
                T informacion = raiz.info;
                if (raiz == fondo)
                {
                    raiz = null;
                    fondo = null;
                }
                else
                {
                    raiz = raiz.sig;
                }

                counter--;

                return informacion;
            }
            else
                return default(T);
        }
    }
}
