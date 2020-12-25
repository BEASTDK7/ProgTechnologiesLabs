using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LW__11
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader f_in = new StreamReader("lr11_05.csv");
#if !DEBUG
            TextWriter save_out = Console.Out;
            var new_out = new StreamWriter(@"lr11_output.txt");
            Console.SetOut(new_out);
#endif

            List<Ticket> all = new List<Ticket>();

            try
            {
                String line = f_in.ReadLine();
                while ((line = f_in.ReadLine()) != null)
                {
                    all.Add(Ticket.Create(line));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //foreach (Ticket t in all)
            //    Console.WriteLine(t);

            Console.WriteLine("******************************* Задача 1 *******************************");
            Console.WriteLine("******* Количество билетов с пунктом отправления из Ставрополя *******\n");
            int total_from_stavropol = (from t in all
                                        where (t.CityFrom == City.Stavropol) select t).Count();
            Console.WriteLine(String.Format("Кол-во билетов из Ставрополя: {0}", total_from_stavropol));
            Console.WriteLine("\n\n");


            Console.WriteLine("******************************* Задача 2 *******************************");
            Console.WriteLine("******* Средняя цена билета для каждого из пунктов отправления *******\n");
            float average_price_from_moscow = (from t in all
                                                  where (t.CityFrom == City.Moscow)
                                                  select t.Price).Average();
            float average_price_from_stavropol = (from t in all
                                                  where (t.CityFrom == City.Stavropol)
                                                  select t.Price).Average();
            float average_price_from_voronezh = (from t in all
                                                  where (t.CityFrom == City.Voronezh)
                                                  select t.Price).Average();
            float average_price_from_rostov = (from t in all
                                                  where (t.CityFrom == City.Rostov_on_Don)
                                                  select t.Price).Average();

            Console.WriteLine(String.Format("Средняя цена отправления из Москвы: ${0:0.00}", average_price_from_moscow));
            Console.WriteLine(String.Format("Средняя цена отправления из Ставрополя: ${0:0.00}", average_price_from_stavropol));
            Console.WriteLine(String.Format("Средняя цена отправления из Воронежа: ${0:0.00}", average_price_from_voronezh));
            Console.WriteLine(String.Format("Средняя цена отправления из Ростова-на-Дону: ${0:0.00}", average_price_from_rostov));
            Console.WriteLine("\n\n");


            Console.WriteLine("******************************* Задача 3 *******************************");
            Console.WriteLine("******* Кол-во билетов, купленных женщинами и мужчинами *******\n");
            int male_tickets = (from t in all
                                where (t.Gender == GenderType.Male)
                                select t).Count();
            int female_tickets = all.Count - male_tickets;

            Console.WriteLine(String.Format("Количество билетов, купленных мужчинами: {0} шт.", male_tickets));
            Console.WriteLine(String.Format("Количество билетов, купленных женщинами: {0} шт.", female_tickets));
            Console.WriteLine("\n\n");


            Console.WriteLine("******************************* Задача 4 *******************************");
            Console.WriteLine("******* Кол-во билетов с одинаковыми пунктами отправления и прибытия *******\n");
            int total_domestic = (from t in all
                                  where (t.CityFrom == t.CityTo)
                                  select t).Count();
            Console.WriteLine(String.Format("Количество билетов внутренних перелетов: {0} шт.", total_domestic));

#if !DEBUG
            Console.SetOut(save_out);
            new_out.Close();
#endif
        }
    }
}
