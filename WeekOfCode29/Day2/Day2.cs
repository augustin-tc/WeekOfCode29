using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekOfCode29.Day2
{
    class Solution
    {
        public Solution()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] unsorted = new string[n];
            for (int unsorted_i = 0; unsorted_i < n; unsorted_i++)
            {
                unsorted[unsorted_i] = Console.ReadLine();
            }
        

            long lengthProcessed = 0;

            while (lengthProcessed < n)
            {
                string minimum = "";
                for (int i = 0; i < unsorted.Length; i++)
                {
                    if (unsorted[i] != "")
                        minimum = unsorted[i];
                }
                int currentMin = 0;
                for (int i = 0; i < unsorted.Length; i++)
                {

                    if (unsorted[i] != "")
                    {
                        int result = isSuperior(minimum, unsorted[i]);

                        if (result == 1 || result == 2)
                        {
                            minimum = unsorted[i];
                            currentMin = i;
                            
                        }
                    }
                }
                unsorted[currentMin] = "";
                lengthProcessed++;
                Console.WriteLine(minimum);
            }



        }

        public static int isSuperior(string a, string b)
        {
            if (a.Length > b.Length)
                return 1;
            else if (a.Length < b.Length)
                return 0;

            if (a.Length == b.Length)
            {
                for (int i = 0; i < a.Length; i++)
                {                   
                    if (int.Parse(a[i].ToString()) > int.Parse(b[i].ToString()))
                        {
                        return 1;
                    }
                    else if (int.Parse(a[i].ToString()) < int.Parse(b[i].ToString()))
                    {
                        return 0;
                    }
                }
            }
            return 2;                  
        }


    }
}

