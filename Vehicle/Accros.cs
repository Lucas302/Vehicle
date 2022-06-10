using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class Accros : ITruck
    {

        TruckTemplate implementation;

        public Accros(string licence, float speedKm, float freight)
        {

            implementation = new TruckTemplate(licence, speedKm, freight);
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
