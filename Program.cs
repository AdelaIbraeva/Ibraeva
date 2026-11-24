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

            AttackReconDrone orion = new AttackReconDrone(
            "Орион", "Кронштадт",
            200, 250, 30, 1150,
            60, 7000,
            "крылатая ракета", 4);

            Drone[] drones = { forpost, lancet, koshchey, kamikaze, orion };

            foreach (Drone d in drones)
            {
                Console.WriteLine(d.GetInfo());
            }

            Console.WriteLine(forpost.GetInfo());
            Console.WriteLine(lancet.GetInfo());

            forpost.PerformReconnaissance();
            lancet.PerformStrike();
            koshchey.DeliverCargo();
            kamikaze.LoiterAndStrike();
        }
    }
}
