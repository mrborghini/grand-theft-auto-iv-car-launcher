using System;
using GTA;

namespace gta_4_mod
{
    public class Car : Script
    {
        private Random _random;
        public Car()
        {
            _random = new Random();
            // Initialize the timer to trigger every 10 seconds
            Game.DisplayText("Car launcher activated");

            Timer timer = new Timer(10000);
            timer.Tick += OnTimerTick;
            timer.Start();
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            Game.DisplayText("10 seconds have passed");
            Vehicle[] vehicles = World.GetAllVehicles();

            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i].isAlive && Player.isActive)
                {
                    int speed = _random.Next(-100, 100);
                    vehicles[i].Speed = speed;
                }
            }
        }
    }
}