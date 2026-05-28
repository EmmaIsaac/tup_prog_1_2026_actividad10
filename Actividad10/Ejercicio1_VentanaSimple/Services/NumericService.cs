using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_VentanaSimple.Services
{
    internal class NumericService
    {
        private int[] valores;
        private int contador;

        public NumericService() 
        { 
            valores = new int[100];
            contador = 0;
        }

        public void Registrar(int valor) 
        {
            if (contador<100 && contador>=0)
            {
                valores[contador] = valor;
                contador++;
            }
        }

        public int VerContador() 
        {
            return contador;
        }

        public int VerValor(int idx) 
        {
            if (idx >=0 && idx < contador)
            {
                return valores[idx];
            }
            return 0;
        }

        //public int Buscar(int valor) 
        //{
        //    for (int i = 0; i < contador; i++)
        //    {
        //        if (valor == valores[i])
        //        {
        //            return i;
        //        }                
        //    }
        //    return -1;
        //}

        public int Buscar(int valor) 
        {
            int n = 0;
            int idx = -1;
            while (idx==-1 && n < contador)
            {
                if (valor == valores[n])
                {
                    idx = n;
                }
                n++;
            }
            return idx;
        }

        public double CalcularPromedio() 
        {
            double prom = 0;
            int acu = 0;

            for (int i = 0; i < contador; i++)
            {
                acu += valores[i];
            }
            if (contador>0)
            {
                prom=1.0*acu/contador;                
            }
            return prom;
        }


    }
}
