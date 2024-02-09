using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesHomeWork
{
    internal class Car
    {
        private string _name;
        private protected int _maxSpeed;
        private protected string _coast;
        private double _averageConsumption;
        private double _fuelValue;

        internal Car(string name, int maxSpeed, string coast,
        double averageConsumption, double fuelValue)
        {
            _name = name;
            _maxSpeed = maxSpeed;
            _coast = coast;
            _averageConsumption = averageConsumption;
            _fuelValue = fuelValue;
        }

        public virtual string GetReaction()
        {
            return "reaction";
        }
        public virtual void DriveDictance(double avCons, double fuVal, out double distance)
        {
            distance = (fuVal / avCons) * 100;
        }
        public virtual string GetCoast() 
        { 
        return _coast;
        }
        public int Drive()
        {
            return _maxSpeed;
        }
    }
}
