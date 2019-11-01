using System;

namespace ProductManager
{
    class MyConsole
    {

        public static String getString(String prompt)
        {
            Double d = 0;
            String s = null;
            Boolean isValid = false;
            Boolean success = false;
            while (!isValid)
            {

                Console.WriteLine(prompt);
                s = Console.ReadLine();
                if (s != null && s.Equals(""))
                {
                    Console.WriteLine("Error! You must input something. Try again.");
                }
                else
                {

                    isValid = true;
                }

                 success = double.TryParse(Console.ReadLine(), out d);
                if (!success)
                {
                    Console.WriteLine("Error: entry must be decimal");
                }



                Console.WriteLine();
            }
            return s;

        }


    }
}
