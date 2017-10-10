using System;

namespace WorkingWIthDateTime
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //different ways to format string
            DateTime myValue = DateTime.Now;
            //Console.WriteLine(myValue.ToString());
            //Console.WriteLine(myValue.ToShortDateString());
            //Console.WriteLine(myValue.ToShortTimeString()); 
            //Console.WriteLine(myValue.ToLongDateString());
            //Console.WriteLine(myValue.ToLongTimeString());

            //date math
            //Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            //Console.WriteLine(myValue.AddDays(3).ToShortTimeString());
            //Be aware of the data type being returned
            //Console.WriteLine(myValue.AddDays(-3).ToShortDateString());

            //Date time is really useful in doing calculation with dates without doing anything by hand


            //Console.WriteLine(myValue.Month.ToString());

            //DateTime myBirthday = new DateTime(1969, 12, 7);
            //Console.WriteLine(myBirthday.ToShortDateString());

            //Takes his birhday and says how old he is in days and fractional days.
            DateTime myBirthday = DateTime.Parse("12/7/1969");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge.TotalDays);


			Console.ReadLine();

            //There are many ways to use date time and how you call it determines how it will 
            //Be shown(this is built into the class)

        }
    }
}
