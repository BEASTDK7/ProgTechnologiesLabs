using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW__11
{
    enum City
    {
        Moscow,
        Stavropol,
        Voronezh,
        Rostov_on_Don
    }

    enum GenderType
    {
        Male,
        Female
    }

    class Ticket
    {
        String ID { get; set; }
        String Name { get; set; }
        public GenderType Gender { get; set; }
        public City CityFrom { get; set; }
        public City CityTo { get; set; }
        public float Price { get; set; }
        

        public static Ticket Create(String str)
        {
            Ticket t = new Ticket();
            string[] e = str.Split(',');
            t.ID = e[0].Trim();
            t.Name = e[1].Trim();
            String tmp = e[2].Trim();
            if (tmp == "M")
                t.Gender = GenderType.Male;
            else t.Gender = GenderType.Female;

            tmp = e[3].Trim();
            if (tmp == "Moscow")
                t.CityFrom = City.Moscow;
            else if (tmp == "Stavropol")
                t.CityFrom = City.Stavropol;
            else if (tmp == "Voronezh")
                t.CityFrom = City.Voronezh;
            else
                t.CityFrom = City.Rostov_on_Don;

            tmp = e[4].Trim();
            if (tmp == "Moscow")
                t.CityTo = City.Moscow;
            else if (tmp == "Stavropol")
                t.CityTo = City.Stavropol;
            else if (tmp == "Voronezh")
                t.CityTo = City.Voronezh;
            else
                t.CityTo = City.Rostov_on_Don;

            t.Price = Convert.ToSingle(e[5].TrimStart('$').Replace('.', ','));
            return t;
        }

        private static String CityToStr(City c)
        {
            if (c == City.Moscow) return "Moscow";
            else if (c == City.Stavropol) return "Stavropol";
            else if (c == City.Voronezh) return "Voronezh";
            else return "Rostov-on-Don";
        }

        private static String GenderToStr(GenderType g)
        {
            if (g == GenderType.Male) return "М";
            else return "Ж";
        }

        public override string ToString()
        {
            String s = string.Format(
                "********************************************************\n" +
                "ID: {0}, Имя держателя билета: {1}\n" +
                "Пол: {2}\n" +
                "Город отправления: {3}\n" +
                "Город прибытия: {4}\n " +
                "Цена: ${5}\n" +
                "********************************************************\n",
                ID, Name, GenderToStr(Gender), CityFrom, CityTo, Price);
            return s;
        }
    }
}
