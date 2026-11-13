using System;

namespace Ibraeva
{
    internal class Program
    {
        static void Main()
        {
            ReconDrone forpost = new ReconDrone(
                "Форпост-Р", "УЗГА",
                200, 250, 18, 500,
                60, 6000);

            AttackDrone lancet = new AttackDrone(
                "Ланцет-3", "ZALA",
                110, 100, 1, 12,
                5, "бронетехника");

            TransportDrone koshchey = new TransportDrone(
                "Кощей", "Авирон",
                80, 250, 6, 500,
                320, "медицинский");

            LoiteringMunition kamikaze = new LoiteringMunition(
                "Ланцет-3", "ZALA",
                110, 100, 1, 12,
                5, "бронетехника",
                40, "оптико-электронное");

            Console.WriteLine("=== Унаследованный метод GetInfo() ===");
            Console.WriteLine(forpost.GetInfo());
            Console.WriteLine(lancet.GetInfo());

            Console.WriteLine("\n=== Собственные методы ===");
            forpost.PerformReconnaissance();
            lancet.PerformStrike();
            koshchey.DeliverCargo();
            kamikaze.LoiterAndStrike();
        }
    }
}
