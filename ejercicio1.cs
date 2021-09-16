using System;
using System.Collections.Generic;

namespace Practica4
{
    /*1 - Hacer un método extendido que opere sobre el tipo List<int> llamado Pares() que retorne un List<int> con los valores pares en la lista asociada dada. 
    En la implementación del método Pares() utilice el método  FindAll() de las listas para pasarle una función 
    predicado mediante la implementación de un delegado que represente métodos que retornen bool y que reciban un entero como parámetro.*/
    delegate bool delegado(int x);

    public static class ejercicio1
    {       
        public static List<int> Pares(this List<int> lista)
        {
            delegado pares = Par;
            return lista.FindAll(Par);
        }
        private static bool Par(int num)
        {
            return num % 2 == 0;
        }
    }

}
