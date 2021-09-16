using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    /*
     2 -  Escriba los siguiente método como expresión lambda:
        public bool EsImpar(int x){
             if (x % 2 != 0){
                 return true;
             else{
                 return false;
             }
        }


        public double CalcularITBIS(double precio){
            var itebis = precio * 0.18;
            return itebis;
        }


        public void GetDate(){
             var fecha = DateTime.Now;
             return fecha;
        }
     */
    public delegate double calcularItebis(double precio);
    public delegate DateTime getDate();
    public delegate bool esImpar(int x);

    class ejercicio2
    {
        calcularItebis calcularItebis = (x) => x * 0.18;
        getDate getDate = () => DateTime.Now;
        esImpar esImpar = (x) => x % 2 != 0;
    }
}
