using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        public static int m = 0;

        /*TODO: Implementar métodos*/
        public static void mover_disco(Pila a, Pila b)
        {/*
            if (a.isEmpty() && !b.isEmpty())
            {
                // Si una pila esta vacía y la otra no saco un disco y la pongo en la vacía
                a.push(b.pop());
            }
            else if (b.isEmpty() && !a.isEmpty())
            {
                b.push(a.pop());
            }
            else
            {*/
            // Si ambas pilas tienen discos muevo el disco mas pequeño 
            // y lo pongo encima del grande
            if (!a.isEmpty() || !b.isEmpty())
            {
                // Si a tiene un disco mas pequeño que b muevo el disco de a => b
                if (a.isMyTopSmaller(b))
                {
                    a.push(b.pop());
                }
                // Si b tiene un disco mas pequeño que a muevo el disco de b => a
                else
                {
                    b.push(a.pop());
                }
            }
            //}
        }

        public static int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            int m = 0;
            bool gameStatus = false;
            while (!gameStatus)
            {
                // Si n es impar
                if (n % 2 != 0)
                {
                    mover_disco(ini, fin);
                    m++;
                    gameStatus = ini.winCheck(n);
                    gameStatus = fin.winCheck(n);
                    if (!gameStatus)
                    {
                        mover_disco(ini, aux);
                        m++;
                        gameStatus = ini.winCheck(n);
                        gameStatus = aux.winCheck(n);
                    }
                    if (!gameStatus)
                    {
                        mover_disco(aux, fin);
                        m++;
                        gameStatus = aux.winCheck(n);
                        gameStatus = fin.winCheck(n);
                    }
                }
                else
                {
                    mover_disco(ini, aux);
                    m++;
                    gameStatus = ini.winCheck(n);
                    gameStatus = aux.winCheck(n);
                    if (!gameStatus)
                    {
                        mover_disco(ini, fin);
                        m++;
                        gameStatus = ini.winCheck(n);
                        gameStatus = fin.winCheck(n);
                    }
                    if (!gameStatus)
                    {
                        mover_disco(aux, fin);
                        m++;
                        gameStatus = aux.winCheck(n);
                        gameStatus = fin.winCheck(n);
                    }
                }
            }
            // cuantos son los movimientos minimos para resolver 2^(n-1); 7 si son 3 discos
            // entregar practica pronto
            // lanzar en terminal
            return m;
        }

        public static int algoritmoRecursivoHanoi(int n, Pila ini, Pila fin, Pila aux)
        {
            //llamara a iterativo
            if (n == 1)
            {
                m++;
                mover_disco(ini, fin);
            }
            else
            {
                algoritmoRecursivoHanoi(n-1, ini, aux, fin);
                m++;
                mover_disco(ini, fin);
                algoritmoRecursivoHanoi(n-1, aux, fin, ini);
            }
            
            return m;
        }

        public static void rellenarPilaIni(Pila pilaIni, int n)
        {
            pilaIni.rellenarPila(n);
        }

    }
}
