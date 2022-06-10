using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class CarTemplate
    {
        string licence;
        float speedKm;
        int passengers;

        public CarTemplate(string licence, float speedKm, int passengers)
        {
            this.licence = licence;
            this.speedKm = speedKm;
            this.passengers = passengers;
        }

        public string LicencePlate()
        {
            throw new NotImplementedException();
        }

        public float MaxLegalSpeedKmh()
        {
            throw new NotImplementedException();
        }

        public int MaxPassengerCount()
        {
            throw new NotImplementedException();
        }
    }
}
