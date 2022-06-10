using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class TruckTemplate
    {
        string licence;
        float speedKm;
        float freight;
        public TruckTemplate(string licence, float speedKm, float freight)
        {
            this.licence = licence;
            this.speedKm = speedKm;
            this.freight = freight;
        }

        public string LicencePlate()
        {
            throw new NotImplementedException();
        }

        public float MaxLegalSpeedKmh()
        {
            throw new NotImplementedException();
        }

        public float MaxFreightKg()
        {
            throw new NotImplementedException();
        }
    }
}
