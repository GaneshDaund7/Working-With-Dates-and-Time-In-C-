using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DateNdTime
{
    class Program
    {
        static void Main(string[] args)
        {


            // Formatting Given Date:::

            var date = "20/4/2021 12:00";
            Console.WriteLine(FormatingDates(date));



            // Calculating How Old You are:::

            var Birthdate = new DateTime(1990, 6, 6, 0, 0, 0);
            Console.WriteLine("Your Age is " + GetAge(Birthdate) + " Years");

           
            
            
            // Storing Given date in File Dates.txt:::
            
            
               StoreDates();



            Console.ReadLine();

        }




       



        public static string FormatingDates(string date)
        {
            
            var res = DateTime.Parse(date);
            return res.ToString("dd-MMM-yyyy dddd  hh:mm:ss");

        }


        public static int GetAge(DateTimeOffset Birthdate)
        {
            var Todate = DateTimeOffset.UtcNow;
            int age = Todate.Year - Birthdate.Year;
            return age;
        }


        public static void StoreDates()
        {
             
           string path= @"C:\Users\Lenovo\Documents\Visual Studio 2010\Projects\DateNdTime\DateNdTime\Dates.txt";
           Console.WriteLine("Write Date in dd/mm/yyyy");
           string inp=Console.ReadLine();

          var date = DateTimeOffset.Parse(inp);
          var date_format = date.ToString("dd-MMM-yyyy dddd");
         // Console.WriteLine(date_format);
          File.WriteAllText(path,date_format);
           
       
   
        }


       
    }
}
