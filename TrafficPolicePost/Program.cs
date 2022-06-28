using System;
namespace TrafficPolicePost
{
    class Program
    {
        static void Main()
        {
            /*   Vehicle Car = VehicleGenerator.GenerateCar();
               var stat = new CheckPointStatistics();
               var stolen = new List<string>() {"999", "123", "666"};
               var point = new CheckPoint(stat, stolen);
               point.RegisterVehicle(Car);*/
            string input;
            do
            {
                Console.WriteLine("Для начала работы введите 'Y'");
                input = Console.ReadLine();
            } while (input != "y" && input != "Y");
            Console.WriteLine("Чтобы остановить работу программы нажмите любую клавишу.");
            var statistic = new CheckPointStatistics();
            var stolenNumbers = new List<string>() {"111", "222", "333", "444", "555", "666", "777", "888","999"};
            var point = new CheckPoint(statistic, stolenNumbers);
            Random rand = new Random();
            int WaitTime;
            while (!Console.KeyAvailable)
            {
                Vehicle vehicle = VehicleGenerator.GenerateVehicle();
                point.RegisterVehicle(vehicle);
                Console.WriteLine();
                WaitTime = rand.Next(500, 5000);
                System.Threading.Thread.Sleep(WaitTime);
            }
            Console.WriteLine("Пост завершил свою работу. Статистика за сессию: ");
            point.GetStatistic().WriteStatistic();
            Console.WriteLine("Удачи на дорогах!");



            




        }
    }
}