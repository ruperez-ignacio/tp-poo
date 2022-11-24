using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej9
{
    public class Metodos
    {
        public static Random r = new Random();
        public static string[] nombres = {"Fernando", "Laura", "Pepe", "Eufrasio"};
 
        public static int generaNumeroEnteroAleatorio(int minimo, int maximo)
        {
            int num = r.Next(minimo, maximo);
            return num;
        }

    }
}
