using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_agency
{
    public enum TRANSPORT_TYPE
    {
        TRAIN,
        BUS,
        AIRPLANE,
        CAR
    }
    public class Transport
    {
        public TRANSPORT_TYPE type;
        private double price_per_km;
        private double quality;

        public Transport()
        {

        }

        public Transport(TRANSPORT_TYPE type, double price_per_km, double quality)
        {
            this.type = type;
            this.price_per_km = price_per_km;
            this.quality = quality;
        }
        public double Get_price(TRANSPORT_TYPE type)
        {
            if (type == TRANSPORT_TYPE.TRAIN) return 1;
            if (type == TRANSPORT_TYPE.BUS) return 2;
            if (type == TRANSPORT_TYPE.AIRPLANE) return 10;
            if (type == TRANSPORT_TYPE.CAR) return 3;

            return 0;
        }

        public double Get_quality(TRANSPORT_TYPE type)
        {
            if (type == TRANSPORT_TYPE.TRAIN) return 4.3;
            if (type == TRANSPORT_TYPE.BUS) return 3.5;
            if (type == TRANSPORT_TYPE.AIRPLANE) return 4.9;
            if (type == TRANSPORT_TYPE.CAR) return 3.8;

            return 0;
        }

        public double Get_calculate_quality(TRANSPORT_TYPE type)
        {
            return Get_quality(type) / Get_price(type)*10;
        }
        
    }
}
