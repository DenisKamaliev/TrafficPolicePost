using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficPolicePost
{
    public class Car:Vehicle
    {
        public override int GetSpeed()
        {
            Random random = new Random();
            return random.Next(90, 151);
        }
    }

}