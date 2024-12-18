using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO18._12._2024.Part3
{
    internal class Program
    {
/*        Задание 1
            Создайте однотабличную базу данных «Страны».
            Нужно хранить такую информацию:
            ■ Название страны;
            ■ Название столицы;
            ■ Количество жителей страны;
            ■ Площадь страны;
            ■ Часть света: Европа, Азия, Африка и т.д.
        Задание 2
            Реализуйте следующие LINQ запросы для 
            базы данных «Страны»:
            ■ Отобразить название стран;
            ■ Отобразить название столиц;
            ■ Отобразить название всех европейских стран;
            ■ Отобразить название стран с площадью большей
            конкретного числа.*/
           static CountriesDataDataContext db 
                = new CountriesDataDataContext();

        static void Main(string[] args)
        {
            ShowCountries();
            ShowCapitalCountries();
            ShowNameCountries();
        }
        //■ Отобразить всю информацию о странах;
        static void ShowCountries()
        {
            var countries = from countr in db.Countries
                            select countr;
            Show(countries);

        }
        //■ Отобразить название стран;
        static void ShowNameCountries()
        {
            var countries = from countr in db.Countries
                            select countr.NameCountry;
            Show(countries);

        }
        //■ Отобразить название столиц;
        static void ShowCapitalCountries()
        {
            var countries = from countr in db.Countries
                            select countr.NameCapital;
            Show(countries);

        }
        //■ Отобразить название всех европейских стран;
        static void ShowEuropeanCountries()
        {
            var countries = from countr in db.Countries
                            where countr.PartOfWolrd == "Европа"
                            select countr;
            countries = db.Countries
                .Where(co => co.PartOfWolrd == "Европа");

            Show(countries);

        }
        //Отобразить название стран с площадью большей конкретного числа.
        static void ShowCountCountries(float area)
        {
            var countries = db.Countries
                .Where(co => co.Area > area);

            Show(countries);
        }

        static void Show(IQueryable<Object> values)
        {
            foreach (var v in values)
                Console.WriteLine(v);
        }
    }
}
