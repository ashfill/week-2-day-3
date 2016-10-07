using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public static class utils
    {


       public static void Method (Employee[] array)
        {

            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i].Firstname + "got paid");
                }
            }

        }


    }
}
