using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {   /* TODO: Elegir tipo de Top
        public int Top { get; set; }
        public String Top { get; set; }        
        */
        /* TODO: Elegir tipo de Elementos
        public Disco[] Elementos { get; set; }
        public List<Disco> Elementos { get; set; }
        */

        //Para representar la cantidad de discos que hay en el palo.
        public int Size { get; set; }

        //Para representar el disco que está en la parte superior del palo.
        public int Top { get; set; }

        //Para representar el conjunto de discos que hay en ese palo.
        public List<Disco> Elementos { get; set; }



        /* TODO: Implementar métodos */
        public Pila()
        {
            this.Elementos = new List<Disco>();
            this.Size = 0;
        }

        //que permitirá colocar un disco en la pila de discos
        public void push(Disco d)
        {
            this.Elementos.Add(d);
            this.Size++;
            this.Top = d.Valor;
        }

        //que permitirá extraer el disco de la parte superior de la pila
        public Disco pop()
        {
            Disco discoAdevolver = this.Elementos[(this.Elementos.Count - 1)];
            if ((this.Elementos.Count - 2) >= 0)
            {
                this.Top = this.Elementos[(this.Elementos.Count - 2)].Valor;
            }
            this.Elementos.RemoveAt((this.Elementos.Count - 1));
            this.Size--;
            return discoAdevolver;
        }

        public bool isEmpty()
        {
            if (this.Elementos.Count == 0)
            {
                return true;
            }
            return false;
        }

        public bool isMyTopSmaller(Pila otherPile)
        {
            if (this.isEmpty() && !otherPile.isEmpty())
            {
                return true;
            }
            else if (!this.isEmpty() && otherPile.isEmpty())
            {
                return false;
            }
            else if (this.Top < otherPile.Top)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool winCheck(int numDiscosTotal)
        {
            int contadorDiscosOrdenados = 0;
            int valorDiscoGrande = numDiscosTotal - 1;
            for (int i = this.Elementos.Count - 1; i >= 0; i--)
            {
                if (this.Elementos[i].Valor == valorDiscoGrande)
                {
                    contadorDiscosOrdenados++;
                    valorDiscoGrande--;
                }
            }

            if (contadorDiscosOrdenados == numDiscosTotal)
            {
                return true;
            }
            return false;
        }

        public void rellenarPila(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Disco disco = new Disco();
                disco.Valor = i;
                this.push(disco);
            }
        }

    }
}
