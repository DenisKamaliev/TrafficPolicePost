using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficPolicePost
{
    public class Vehicle
    {
        public enum VehicleColor { Red = 0, Green = 1, Blue = 2, White = 3, Black = 4 }
        protected VehicleColor _color;
        public enum BodyType { Car = 0, Bus = 1, Truck = 2 }
        protected BodyType _bodyType;

        protected int _licensePlateNumber;
        protected bool _hasPassenger;

        public int CheckBodyType()
        {
           
                return (int)_bodyType;
            
        }
        public bool GetHasPassenger()
        { return _hasPassenger; }
        public void SetHasPassenger(bool value)
        { _hasPassenger = value; }

        public int GetLicensePlateNumber()
        { return _licensePlateNumber; }
        public void SetLicensePlateNumber(int value)
        { _licensePlateNumber = value; }

        public BodyType GetBodyType()
        { return _bodyType; }

        public void SetBodyType(BodyType value)
        { _bodyType = value; }

        public VehicleColor GetColor()
        { return _color; }
        public void SetColor(VehicleColor value)
        { _color = value; }

        public virtual int GetSpeed()
        {
            Random random = new Random();
            return random.Next(0, 300);
        }
    }

}