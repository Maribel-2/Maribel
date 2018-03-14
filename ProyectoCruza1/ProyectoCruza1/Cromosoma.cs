using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCruza1
{
  
    class Cromosoma
    {
        private int BITS_POR_GENE;
        private int[] gene, inv;
        Random r = new Random();
        public Cromosoma(int bits) //recibe el No. de bits (genes)
        {
            this.BITS_POR_GENE = bits;
            gene = new int[BITS_POR_GENE];
        }

        public int getValue()
        { //binario a decimal
            int value = 0;

            for (int i = BITS_POR_GENE - 1; i >= 0; i--)
            {
                value += gene[i] * (int)Math.Pow((double)2, (double)i);
            }
            if (gene[BITS_POR_GENE - 1] == 1)
                return value;
            return -value;
        }

        public int getValueGray() //función que devuelve el valor de los genes en código Gray
        {
            Console.Write("\nGenesGray = ");
            int[] res = new int[BITS_POR_GENE]; //arreglo para el resultado de la XOR
            for (int k = gene.Length - 1; k >= 0; k--)
            {
                if ((k - 1) >= 0)
                { //el indice debe ser mayor que cero, de lo contrario ocurrirá un error
                    if (gene[k] == gene[k - 1])
                    { //se aplica el corrimiento a la derecha de MSB a LSB
                        res[k] = 0; //refer[i]=0 y refer[i]=1 es equivalente a una operacion XOR
                    }
                    else
                    {
                        res[k] = 1;
                    }
                }
                else
                { //cuando i no es mayor que 0, entonces el corrimiento a la derecha se termina
                    res[k] = gene[k]; //como el corrimiento terminó, el MSB se queda igual
                }
            }
            int[] inv = new int[res.Length];
            for (int i = 0, j = inv.Length - 1; i < inv.Length; i++, j--)
            {
                inv[i] = res[j]; /*Invierte el resultado (no sé exactamente porqué mis arreglos
                    intercambiaban los valores, intenté varias cosas hasta que llegué a
                    invertirlo mejor)*/
            }

            int value = 0;
            for (int i = res.Length - 1; i >= 0; i--) //comanzamos con el MSB
            {
                Console.Write(inv[i]);  //imprime los valores invertidos
                value += inv[i] * (int)Math.Pow((double)2, (double)i); //sumar los exponentes de cada gen según su índice

            }
            if (gene[BITS_POR_GENE - 1] == 1) //devuelve positivo si el MSB es 1 y negativo si no lo es (no recuerdo bien porqué era esto)
                return value;
            return -value;
        }

        public void inicializar()
        {
            Console.Write("\nGenes Aleatorios = ");
            for (int i = 0; i < gene.Length; i++)
            {
                gene[i] = r.Next(0, 2); //aleatorios entre 0 y 1, se guardan en el arreglo gene
                Console.Write(gene[i]);
            }
        }


    }
