using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class Accros : ITruck
    {
        string licence;
        float speedKm;
        float freight;
        TruckTemplate implementation;

        public Accros(string licence, float speedKm, float freight)
        {
            this.licence = licence;
            this.speedKm = speedKm;
            this.freight = freight;
            implementation = new TruckTemplate();
        }

        public string LicencePlate()
        {
            return implementation.LicencePlate();
        }

        public float MaxLegalSpeedKmh()
        {
            return implementation.MaxLegalSpeedKmh();
        }

        public float MaxFreightKg()
        {
            return implementation.MaxFreightKg();
        }


    }
}
