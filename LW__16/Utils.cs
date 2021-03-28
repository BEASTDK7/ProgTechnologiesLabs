using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW__16
{
    class Utils
    {
        private static Dictionary<int, String> dict;
        static Utils()
        {
            if (dict == null)
            {
                dict = new Dictionary<int, string>(4);
                dict.Add(0, "Закуп продуктов суммарно");
                dict.Add(1, "Цена самого дорогого продукта");
                dict.Add(2, "Закуп химии суммарно");
                dict.Add(3, "Цена самой дорогой химии");
            }
        }

        public static String GetGroupByNumber(int number)
        {
            if (dict.ContainsKey(number))
                return dict[number];
            else
                return "???";
        }
    }
}
