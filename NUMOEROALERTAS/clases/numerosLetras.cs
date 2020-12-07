﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTILS
{
    class numerosLetras
    {
        static String[] Unidades = { "cero","uno","dos","tres","cuatro"
                ,"cinco","seis","siete","ocho","nueve","diez"
        , "once", "doce","trece","catorce","quince"
                ,"dieciseis","diecisiete","dieciocho","diecinueve"};
        static String[] Decenas = {"cero", "diez","veinte","treinta","cuarenta","cincuenta"
                ,"sesenta","setenta","ochenta","noventa"};
        static String[] Centenas = {"cero", "cien","doscientos","trescientos","cuatrocientos","quinientos"
                ,"seiscientos","setecientos","ochocientos","novecientos"};
        public static void testUnidades()
        {
            //recorrer todo el vector o array de String
            foreach (String cad in Unidades)
            {

                Console.WriteLine(cad);
            }
        }//Fin
        /// <summary>
        /// Devuelve el equivalente en letras para las unidades 
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static String getUnidades(int num)
        {
            String aux = "";
            if (num >= 0 && num < 20)
                aux = Unidades[num];
            return aux;
        }
        public static String getDecenas(int num)
        {
            String aux = "";
            if (num >= 0 && num < 20)
                aux = getUnidades(num);
            else if (num >= 10 && num < 100)
            {
                int residuo = num % 10;
                aux = Decenas[num / 10];
                if (residuo > 0)
                {
                    aux += " y " + getUnidades(residuo);
                }
            }
            return aux;
        }
       public static String getCentenas(int num)
        {
            String aux = "";
            if (num >= 0 && num < 100)
                aux = getDecenas(num);
            else if (num > 100 && num < 200)
            {
                int residuo = num % 100;
                if (residuo > 0)
                {
                    aux += "ciento " + getDecenas(residuo);
                }

            }
            else if (num >= 100 && num < 1000)
            {
                int residuo = num % 100;
                aux = Centenas[num / 100];
                if (residuo > 0)
                {
                  
                    aux +=" "  + getCentenas(residuo);
             
                }
            }
            return aux;
        }

    }
}
