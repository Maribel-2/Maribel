using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCruza1
{
    class Individuo
    {
        Individuo[] Cross1P(Individuo madre,Individuo padre ,int cross)
        {
            Individuo[] hijo = new Individuo[2];
            padre = new Individuo(cross);
            madre = new Individuo(cross);
            cross = 3;
            
            for (int i = 0; i<cross.length; i++) {
                if (i <= cross) {
                    hijo1[1] = padre[i];
                }
            }

        }
        Cromosoma cromosoma;

        public Individuo(int num_bits)
        {
            cromosoma = new Cromosoma( num_bits);
            cromosoma.inicializar();
        }
        public override string ToString()
        {
            return string.Format("\nIndividou = "+ getFenotipo()); 
        }
        public int getFenotipo()
        {
            return cromosoma.getValue();

        }

        public
    }
}
