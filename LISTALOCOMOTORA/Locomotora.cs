using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTALOCOMOTORA
{
    internal class Locomotora
    {
        Vagon Primero { get; set; }

        public void AgregaPrimero(int valor)
        {
            Vagon nuevo = new Vagon(valor);
            if (this.Primero == null)//caso 1
            {
                this.Primero = nuevo;
            }
            else //caso 2
            {
                Vagon primVag = this.Primero;

                nuevo.Sig = primVag;

                this.Primero = nuevo;
            }
        }

        public void AgregaFinal(int valor)
        {
            Vagon nuevo = new Vagon(valor);
            if (this.Primero == null)//caso 1
            {
                this.Primero = nuevo;
            }
            else //caso 2
            {
                Vagon tmp = this.Primero;
                while (tmp.Sig != null)
                {
                    tmp = tmp.Sig;
                }
                tmp.Sig = nuevo;
            }
        }
        public void EliminarUltimo()
        {
            Vagon tmp = this.Primero;
            if (this.Primero == null)//caso 1
            {
                Console.WriteLine("no hay vagones");
                return;
            }

            if (this.Primero.Sig == null)//caso 2, cuando hay solo 1
            {
                this.Primero = null;
                return;
            }
            while (tmp.Sig != null && tmp.Sig.Sig != null)//caso 3, cuando hay mas de 1
            {
                tmp = tmp.Sig;
            }

            tmp.Sig = null;
        }
        public bool ExisteValor(int valor)
        {
            Vagon tmp = this.Primero;

            while (tmp != null)
            {
                if (tmp.Dato == valor)
                {
                    return true;
                }

                tmp = tmp.Sig;
            }
            return false;
        }
        public int Largo()
        {
            int contador = 0;
            Vagon tmp = this.Primero;

            while (tmp != null)
            {
                contador++;
                tmp = tmp.Sig;
            }

            return contador;
        }
        public int GetValor(int pos)
        {
            Vagon tmp = this.Primero;
            int contador = 0;

            while (tmp != null)
            {
                if (contador == pos)
                {
                    return tmp.Dato;
                }
                contador++;
                tmp = tmp.Sig;
            }

            throw new IndexOutOfRangeException("Posición fuera de rango.");
        }
        public Vagon GetVagon(int pos)
        {
            Vagon tmp = this.Primero;
            int contador = 0;

            while (tmp != null)
            {
                if (contador == pos)
                {
                    return tmp;
                }
                contador++;
                tmp = tmp.Sig;
            }

            return null;
        }
        public void AgregarLEFinal()
        {
            int n = Largo();
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    Vagon actual = GetVagon(j);
                    Vagon siguiente = actual.Sig;

                    if (siguiente != null && actual.Dato > siguiente.Dato)
                    {
                        // Intercambiar los datos
                        int temp = actual.Dato;
                        actual.Dato = siguiente.Dato;
                        siguiente.Dato = temp;
                    }
                }
            }

        }

        public string VerVagones()
        {
            string listaVag = "";
            Vagon tmp = this.Primero;
            while (tmp != null)
            {
                listaVag += tmp.Dato + ", ";
                tmp = tmp.Sig;
            }
            return listaVag;
        }

    }
}
    

