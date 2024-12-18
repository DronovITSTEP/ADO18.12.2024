using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ADO18._12._2024.Part2
{
    internal class Program
    {
        static void LinqMethod()
        {
            string[] countries =
            {
                "Россия",
                "США",
                "Китай",
                "Канада",
                "Корея",
                "Великобритания",
                "Литва",
                "Латвия",
                "Эстония",
                "Япония"
            };

            //"select Name from countries where name like 'К%';"
            var result = from c in countries 
                         where c.StartsWith("К") 
                         select c;
            foreach (var c in result)
            {
                Console.WriteLine(c);
            }
            result = from c in countries
                     where c.Length > 5
                     select c;
            Console.WriteLine();
            foreach (var c in result)
            {
                Console.WriteLine(c);
            }

            /*from c in countries
            where c.StartsWith("К")
            select c;*/
            result = countries.Where(c => c.StartsWith("К"));

            Console.WriteLine();
            foreach (var c in result)
            {
                Console.WriteLine(c);
            }
        }
       
        static void SqlLinqMethod()
        {
            DataClasses1DataContext db =
                new DataClasses1DataContext();

            var result = from c in db.Informations
                         where c.Count > 10
                         select new
                         {
                             Id = c.Id,
                             Count = c.Count,
                             Price = c.Price
                         };

            foreach (var c in result)
                Console.WriteLine(c);

        }
        static void Main(string[] args)
        {
            //LinqMethod();
            SqlLinqMethod();

        }
    }
}
