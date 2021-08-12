using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCars
{
    public class SUV : IVehicle
    {
        public SUV(string make, string model, string color)
        {
            Make = make;
            Model = model;
            Color = color;
        }

        public string Make { get; }
        public string Model { get; }
        public string Color { get; set; }

        public void Brake()
        {
            Console.WriteLine("SCREEEEEECH!!!!");
        }

        public void Drive()
        {
            Console.WriteLine("Vroom!!");
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void TurnLeft()
        {
            throw new NotImplementedException("you doink");
            // Console.WriteLine("The SUV turns left");
        }

        public void TurnOff()
        {
            throw new NotImplementedException();
        }

        public void TurnRight()
        {
            throw new NotImplementedException();
        }
    }
}
