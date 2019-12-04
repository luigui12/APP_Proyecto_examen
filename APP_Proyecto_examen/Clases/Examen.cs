namespace APP_Proyecto_examen.Clases
{
    class Examen
    {
        /// <summary>
        /// Funcion que devuelve verdadero si es primo
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool esPrimo(int num)
        {
            bool primo = true;
            for(int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    primo = false;
                    break;//abandonar bucle
                }
            }
            return primo;
        }
        public static int sumatoria(int limite)
        {
            int cont = 0;
            int num = 2,suma=0;
            while (cont < limite)
            {
                if (esPrimo(num))
                {
                    suma += num;
                    cont++;
                }
                num++;

            }
            return suma;
        }
    }
}
