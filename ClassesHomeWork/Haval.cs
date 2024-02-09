using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesHomeWork
{
    internal class Haval: Car
    {
        public Haval(string name, int maxSpeed, string coast, double averageConsumption, double fuelValue) : base(name, maxSpeed, coast, averageConsumption, fuelValue)
        {

        }
        public override string GetReaction()
        {
            return "Лаваш хуита китайская";
        }
        public override void DriveDictance(double avCons, double fuVal, out double distance)
        {
            distance = (fuVal / avCons) * 100;

        }
        public override string GetCoast()
        {
            return _coast;
        }
        public new int Drive()
        {
            return _maxSpeed;
        }
    }
}
