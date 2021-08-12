using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCars
{
    public interface IVehicle
    {
        // All vehicles need to be able to start, turn off, drive, as well as they all have a make, model, and color.

        void Start();
        void TurnOff();
        void Drive();
        void TurnLeft();
        void TurnRight();
        void Brake();

        string Make { get; }
        string Model { get; }
        string Color { get; set; }
    }
}
