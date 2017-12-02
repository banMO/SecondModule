using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalaFoundation.Dev23.Practice3
{
    public static class ExtensionMethods
    {
        public static string GetFirstLetter(this string str)
        {
            return str.Substring(0, 1);
        }

        public static string LastLetter(this string str)
        {
            string res="";
            string[] words = str.Split(' ');
            foreach (string word in words)
            {
                res = res + word[word.Length - 1] + " ";
            }
            return res;
        }

        public static char[] BubbleSort(this string str)
        {

        }
        public static Array  QuickSort(this string str)
        {
            Array chars = str.ToCharArray();
            QuickSortMethod(ref chars);
            /*string res = "";
            for (int i = 0; i < chars.Length; i++)
            {
                res += chars[i];
                res += "*";
            }*/
              
            return chars;
        }



        static void QuickSortMethod(ref Array array )
        {
            if (array.Length <= 1)
            {
                return;
            }
            var middle = array[array.Length / 2];
            Array left = new Array(10);
            Array right = new Array(10);
                for (int i = 0; i < array.Length; i++)
                    if (i != array.Length / 2)
                    {
                        if (array[i] <= middle)
                            left.Add(array[i]);
                        else
                            right.Add(array[i]);
                    }
                return concatenate(quickSort(left), middle, quickSort(right));
            }

        }
    public static string ToBase64(this string str)
    {
        var strBytes = System.Text.Encoding.UTF8.GetBytes(str);
        return System.Convert.ToBase64String(strBytes);
    }

    public static IConvertible ToBase64(this IConvertible convertible)
    {
        string str = convertible.ToString();
        return str.ToBase64();
    }

}
}
