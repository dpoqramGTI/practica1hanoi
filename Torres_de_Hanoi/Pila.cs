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
        }

        //que permitirá colocar un disco en la pila de discos
        public void push(Disco d)
        {
            this.Elementos.Add(d);
        }

        //que permitirá extraer el disco de la parte superior de la pila
        public Disco pop()
        {
            return this.Elementos[(this.Elementos.Count - 1)];
        }                

        public bool isEmpty()
        {
            return true;
        }

    }
}
