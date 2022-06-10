using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class Clio : ICar
    {
        string licence;
        float speedKm;
        int passengers;
        CarTemplate implementation;

        public Clio(string licence, float speedKm, int passengers)
        {
            this.licence = licence;
            this.speedKm = speedKm;
            this.passengers = passengers;
            implementation = new CarTemplate();
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
