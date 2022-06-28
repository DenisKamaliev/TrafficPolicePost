using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficPolicePost
{
    public class CheckPoint
    {
        private CheckPointStatistics _statistic;
        private List <string> _stolenNumbers;
        
        private int speedSum;

        public CheckPointStatistics GetStatistic()
        {
            return _statistic;
        }
        public void SetStolenNumbers(List<string> value)
        {
            _stolenNumbers = value;
        }
        public CheckPoint(CheckPointStatistics Statistic, List <string> StolenNumbers)
        {
            _statistic = Statistic;
            _stolenNumbers = StolenNumbers;
        }

        public void RegisterVehicle(Vehicle vehicle) 
        {
            int speed = vehicle.GetSpeed();
            speedSum += speed;
            _statistic.SetVehicleCount(_statistic.GetVehicleCount()+1);
            if (vehicle.CheckBodyType() == 0)
            {
                _statistic.SetCarsCount(_statistic.GetCarsCount() + 1);
                Console.WriteLine("Легковой автомобиль ");
            }
            else if (vehicle.CheckBodyType() == 1)
            {
                _statistic.SetBusesCount(_statistic.GetBusesCount() + 1);
                Console.WriteLine("Автобус ");
            }

            else if (vehicle.CheckBodyType() == 2)
            {
                _statistic.SetTrucksCount(_statistic.GetTrucksCount() + 1);
                Console.WriteLine("Грузовик ");
            }

            Console.WriteLine("Цвет: " + vehicle.GetColor().ToString());
            if (vehicle.GetHasPassenger())
                Console.WriteLine("Есть пассажир на переднем сидении");
            else
                Console.WriteLine("Нет пассажира на переднем сидении");
            Console.WriteLine("Скорость: "+ speed);
            if (speed > 110)
                {
                    _statistic.SetSpeedLimitBreakersCount(_statistic.GetSpeedLimitBreakersCount() + 1);
                    Console.WriteLine("Превышение скорости!");
                }
            Console.WriteLine("Регистрационный номер: "+ vehicle.GetLicensePlateNumber());
            if (_stolenNumbers.Contains(vehicle.GetLicensePlateNumber().ToString()))
                {
                    _statistic.SetCarJackersCount(_statistic.GetCarJackersCount() + 1);
                    Console.WriteLine("Автомобиль в угоне, план 'Перехват!'");
                }
                int Count = _statistic.GetVehicleCount();
                _statistic.SetAverageSpeed(speedSum / Count);
            }
    }
}
