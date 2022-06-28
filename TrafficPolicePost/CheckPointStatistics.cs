using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficPolicePost
{
    public class CheckPointStatistics
    {
        private int _carsCount = 0;
        private int _trucksCount = 0;
        private int _busesCount = 0;
        private int _speedLimitBreakersCount = 0;
        private int _carJackersCount = 0;
        private double _averageSpeed = 0;
        private int _vehicleCount = 0;
        public int GetVehicleCount()
        {
            return _vehicleCount;
        }
        public void SetVehicleCount(int value)
        {
            _vehicleCount = value;
        }
        public int GetCarsCount()
        {
            return _carsCount;
        }
        public void SetCarsCount(int value)
        {
            _carsCount = value;
        }
        public int GetTrucksCount()
        {
            return _trucksCount;
        }
        public void SetTrucksCount(int value)
        {
            _trucksCount = value;
        }
        public int GetBusesCount()
        {
            return _busesCount;
        }
        public void SetBusesCount(int value)
        {
            _busesCount = value;
        }
        public int GetSpeedLimitBreakersCount()
        {
            return _speedLimitBreakersCount;
        }
        public void SetSpeedLimitBreakersCount(int value)
        {
            _speedLimitBreakersCount = value;
        }
        public int GetCarJackersCount()
        {
            return _carJackersCount;
        }
        public void SetCarJackersCount(int value)
        {
            _carJackersCount = value;
        }
        public double GetAverageSpeed()
        {
            return _averageSpeed;
        }
        public void SetAverageSpeed(int value)
        {
            _averageSpeed = value;
        }
        public  void WriteStatistic()
        {
            Console.WriteLine("Общее количество машин: " + _vehicleCount);
            Console.WriteLine("Легковых: " + _carsCount);
            Console.WriteLine("Автобусов: " + _busesCount);
            Console.WriteLine("Грузовиков: " + _trucksCount);
            Console.WriteLine("Нарушителей скорости: " + _speedLimitBreakersCount);
            Console.WriteLine("Обнаружено угнанных машин: " + _carJackersCount);
            Console.WriteLine("Средняя скорость за эту сессию: " + _averageSpeed);
        }


    }
}
