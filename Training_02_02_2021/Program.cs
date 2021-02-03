using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_02_02_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //nhap vao day abc sao cho in ra là cba
            Console.WriteLine("ahihi");
            //string input = Console.ReadLine();
            //char[] sPlit = input.ToCharArray();
            //char[] Edit = new char[sPlit.Length];
            //int j = 0;

            //for (int i = sPlit.Length - 1; i >= 0; i--)
            //{
            //    Edit[j] = sPlit[i];
            //    j++;
            //}

            //string ouput = new string(Edit);
            //Console.WriteLine(ouput);
            //Console.ReadLine();

            //nhap vao day 123abc in ra cba321  
            string input = Console.ReadLine();
            char[] sPlit = input.ToCharArray();
            int[] numBer = new int[sPlit.Length];
            char[] chaR = new char[sPlit.Length];
            int x = 0;
            int y = 0;

            for (int i = 0; i < sPlit.Length; i++)
            {
                if (sPlit[i] >= '0' && sPlit[i] <= '9')
                {
                    numBer[x] = int.Parse(sPlit[i].ToString());
                    Console.WriteLine(numBer[x]);
                    x++;
                }
                else
                {
                    chaR[y] = sPlit[i];
                    y++;
                }
            }
            SortNumber(numBer, numBer.Length);
            SortChar(chaR, chaR.Length);

            string[] NumToChar = new string[numBer.Length];
            int z = 0;
            foreach (var item in numBer)
            {
                NumToChar[z] = item.ToString();
                z++;
            }
            string ouput1 = new string(NumToChar);

            Console.ReadKey();

        }

        //static void SortNumber(int[] arr1, int n)
        //{
        //    int i, j;
            
        //    for (i = 0; i < n; i++)
        //    {
        //        for (j = i + 1; j < n; j++)
        //        {
        //            if (arr1[i] < arr1[j])
        //            {
        //                //cach trao doi gia tri
        //                int tmp = arr1[i];
        //                arr1[i] = arr1[j];
        //                arr1[j] = tmp;
        //            }
        //        }
        //    }
        //}

        static void SortChar(char[] arr1, int n)
        {
            int i, j;
            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr1[i] < arr1[j])
                    {
                        //cach trao doi gia tri
                        char tmp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = tmp;
                    }
                }
            }
        }
    }
}
