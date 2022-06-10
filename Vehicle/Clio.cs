using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class Clio : ICar
    {
        CarTemplate implementation;

        public Clio(string licence, float speedKm, int passengers)
        {
            implementation = new CarTemplate(licence, speedKm, passengers);
        }

        public string LicencePlate()
        {
            return implementation.LicencePlate();
        }

        public float MaxLegalSpeedKmh()
        {
            return implementation.MaxLegalSpeedKmh();
        }

        public int MaxPassengerCount()
        {
            return implementation.MaxPassengerCount();
        }


    }
}
