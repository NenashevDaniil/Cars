using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesHomeWork
{
    internal class Lada : Car
    {
        public Lada(string name, int maxSpeed, string coast, double averageConsumption, double fuelValue) : base(name, maxSpeed, coast, averageConsumption, fuelValue)
        {

        }
        public override string GetReaction()
        {
            return "Лада классика для настоящих мужчин";
        }
        public override void DriveDictance(double avCons, double fuVal, out double distance)
        {
            distance = (fuVal / avCons) * 100;

        }
        public override string GetCoast()
        {
            return _coast;
        }
        public int Drive()
        {
            return _maxSpeed;
        }
    }
}
