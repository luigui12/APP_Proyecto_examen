using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_Proyecto_examen.Clases
{

    class numero_reales
    {
        
        /// <summary>
        /// Generar numeros aleatorios
        /// </summary>
        /// <returns></returns>
        public static int generardatos()
        {

            Random random = new Random();
                int nu = random.Next(1, 101);
            
            return nu;
        }
        /// <summary>
        /// COMPARACION DE POSICIONES
        /// </summary>
        //METODO BURBUJA COMPARACION DE POSICIONES 
       public static int Burbuja()
        {
            int max = 20;
            int[] vec = new int[max];
            int r, ac, au;
            for (r = 0; r < max; r++)
            {
                for (ac=r+1;ac<max-r;ac++)
                {
                    if (vec[r]>vec[ac])
                    {
                        au = vec[r];
                        vec[r] = vec[ac];
                        vec[ac] = au;
                    }
                }

            }
            return 0;
        }
        //MOSTRAR VALORES REALES 
        
    }
}
