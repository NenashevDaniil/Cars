namespace ClassesHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Чтобы получить информацию об автомобиле, введите название марки.");
            Console.WriteLine("Mers; Kia; Haval; Lada");
            string tipeOfCar = Console.ReadLine();
            tipeOfCar = tipeOfCar.ToLower();
            switch (tipeOfCar)
            {
                case "mers":
                    Mers mers = new Mers("Мерс", 220, "5 лямов", 12, 60);
                    Console.WriteLine(mers.GetReaction());
                    Console.WriteLine("Цена автомобиля составляет " + mers.GetCoast());
                    mers.DriveDictance(12, 60, out double distanceMers);
                    Console.WriteLine($"Автомобиль проезжает без дозаправки {distanceMers} км.");
                    Console.WriteLine("Максимальная скорость автомобиля составляет " + mers.Drive() + "км/ч.");
                    Console.WriteLine();
                break;

                case "kia":
                    Kia kia = new Kia("Киаа", 180, "2 ляма", 8, 55);
                    Console.WriteLine(kia.GetReaction());
                    Console.WriteLine("Цена автомобиля составляет " + kia.GetCoast());
                    kia.DriveDictance(8, 55, out double distanceKia);
                    Console.WriteLine($"Автомобиль проезжает без дозаправки {distanceKia} км.");
                    Console.WriteLine("Максимальная скорость автомобиля составляет " + kia.Drive() + "км/ч.");
                    Console.WriteLine();
                break;

                case "haval":
                    Haval haval = new Haval("Лаваш", 200, "2 ляма", 14, 70);
                    Console.WriteLine(haval.GetReaction());
                    Console.WriteLine("Цена автомобиля составляет " + haval.GetCoast() + " Цена заманчивая, но не ведитесь пацаны");
                    haval.DriveDictance(14, 70, out double distanceHaval);
                    Console.WriteLine($"Автомобиль проезжает без дозаправки {distanceHaval} км.");
                    Console.WriteLine("Максимальная скорость автомобиля составляет " + haval.Drive() + "км/ч.");
                    Console.WriteLine();
                break;

                case "lada":
                    Lada lada = new Lada("Лада седан", 100, "500к деревянных", 10, 40);
                    Console.WriteLine(lada.GetReaction());
                    Console.WriteLine("Цена автомобиля составляет " + lada.GetCoast() + " + возможность поддержать отечественного производителя.");
                    lada.DriveDictance(10, 40, out double distanceLada);
                    Console.WriteLine($"Автомобиль проезжает без дозаправки {distanceLada} км. (При условии, что заведется).");
                    Console.WriteLine("Максимальная скорость автомобиля составляет " + lada.Drive() + "км/ч.");
                    Console.WriteLine();
                 break;
            } 
        }
    }
}
