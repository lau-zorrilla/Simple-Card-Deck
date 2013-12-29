using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace FormsAppBaraja
{
    class Baraja
    {
        Random r;
        ArrayList Lista;
        int rango, cantidad, aleatorio, extraido, cifra;

        public Baraja()
        {
            Lista = new ArrayList(2);
            r = new Random();
            rango = 2;
            aleatorio = 0;
            extraido = 0;
        }

        public Baraja(int numero)
        {
            Lista = new ArrayList(numero);
            r = new Random();
            rango = numero;
            aleatorio = 0;
            extraido = 0;
        }

        public ArrayList Inicializar()
        {
            Lista.Clear();
            for (int i = 0; i < rango; i++)
            {
                cifra = r.Next(1, (rango + 1));
                if (!Lista.Contains(cifra))
                    Lista.Add(cifra);
                else
                {
                    i--;
                }
            }
            return Lista;
        }

        public void Vaciar()
        {
            Lista.Clear();
        }

        public bool Vacia()
        {
            if (Lista.Count != 0)
                return true;
            else
                return false;
        }

        public int Cantidad()
        {
            cantidad = Lista.Count;

            return cantidad;
        }

        public ArrayList GetLista()
        {           
            return Lista;
        }

        public int Extraer()
        {
            aleatorio = r.Next(0, rango - 1);
            extraido = (int) Lista[aleatorio];
            
            Lista.RemoveAt(aleatorio);
            rango--;

            return extraido;
        }

    }
}
