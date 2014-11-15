using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;
using System.IO;

namespace CombinaBinarios
{
    public class CombinacionBinarios
    {

        public string Combinaciones(int number)
        {
            string result = "";

            List<string> list = new List<string>();

            Regex rgx = new Regex("11");

            int numeroCombinaciones = Convert.ToInt32(Math.Pow(2, number));

            int num = Convert.ToInt32(Convert.ToString(3, 2));

            for (int i = 0; i < numeroCombinaciones; i++)
            {
                string binarioUnitario = Convert.ToString(i, 2).PadLeft(number, '0');

                if (rgx.IsMatch(binarioUnitario) == false)
                {
                    list.Add(binarioUnitario);
                }
            }

            for (int k = 0; k < list.Count; k++)
            {
                result = result + list[k] + " " ;
            }

            return result;

        }
    }
}



