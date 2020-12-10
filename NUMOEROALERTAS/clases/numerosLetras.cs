using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTILS
{
    class numerosLetras
    {
        static String[] Unidades = {"Cero", "Uno", "Dos", "Tres", "Cuatro", "Cinco",
                             "Seis", "Siete","Ocho","Nueve","Diez","Once","Doce",
                             "Trece","Catorce","Quince","Dieciseis","Diecisiete",
                             "Deiciocho","Diecinueve"};

        static String[] Decenas = {"Cero","Diez", "Veinte", "Treinta", "Cuarenta", "Cincuenta",
                             "Sesenta","Setenta","Ochenta","Noventa"};

        static String[] Centenas = {"Cero","Cien","Doscientos","Trescientos","Cuatrocientos","Quinientos",
                             "Seiscientos","Setecientos","Ochocientos","Novecientos"};

        public static void TestUnidades()
        {
            //Recorrer todo el array de String
            foreach (String cad in Unidades)
            {
                Console.WriteLine(cad);
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Devuelve el equivalente en letras para las unidades
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static String getUnidades(int num)
        {
            String aux = "";
            if (num >= 0 && num < 20)
            {
                aux = Unidades[num];
            }
            return aux;
        }

        public static String getDecenas(int num)
        {
            String aux = "";
            if (num >= 0 && num < 20)
            {
                aux = getUnidades(num);
            }
            else
                if (num >= 20 && num < 100)
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
            {
                aux = getDecenas(num);
            }
            else if (num == 100)
            {
                aux += Centenas[num / 100];
            }
            else if (num > 100 && num < 200)
            {
                int residuo = num % 100;
                if (residuo > 0)
                {
                    aux += "Ciento " + getDecenas(residuo);
                }

            }
            else if (num >= 200 && num < 1000)
            {
                int residuo = num % 100;
                aux = Centenas[num / 100];
                if (residuo > 0)
                {
                    aux += " " + getDecenas(residuo);
                }
            }
            return aux;
        }

        public static String getMiles(int num)
        {
            String aux = "";
            if (num >= 0 && num < 1000)
            {
                aux = getCentenas(num);
            }
            else if (num == 1000)
            {
                aux = "Mil";
            }
            else if (num > 1000 && num <= 999999)
            {
                int residuo = num % 1000;
                if (num > 1000 && num < 2000)
                {
                    aux = "Mil " + getCentenas(residuo);
                }
                else if (num >= 2000 && num <= 999999)
                {
                    aux = getCentenas(num / 1000) + " mil";
                    if (residuo > 0)
                    {
                        aux += " " + getCentenas(residuo);
                    }
                }
            }
            return aux;
        }

        public static String getMillones(int num)
        {
            String aux = "";
            if (num >= 0 && num <= 999999)
            {
                aux = getMiles(num);
            }
            else if (num >= 1000000 && num <= 999999999)
            {
                int residuo = num % 1000000;
                if (num >= 1000000 && num < 2000000)
                {
                    aux = "Un Millon";
                    if (residuo > 0)
                    {
                        aux += " " + getMiles(residuo);
                    }
                }
                else if (num > 1000000 && num <= 999999999)
                {
                    aux = getMiles(num / 1000000) + " Millones";
                    if (residuo > 0)
                    {
                        aux += " " + getMiles(residuo);
                    }
                }

              
            }
            return aux;
        }


    }
}
