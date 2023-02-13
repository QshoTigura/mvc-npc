using System;
using System.Collections.Generic;
using System.Text;

namespace mvcZelenhuci.model
{
    public class Garden
    {
        public Garden(decimal vefiPrice, decimal fruitsPrice, int vegiKG, int fruitsKG)
        {
            VefiPrice = vefiPrice;
            FruitsPrice = fruitsPrice;
            VegiKG = vegiKG;
            FruitsKG = fruitsKG;
        }

        public decimal VegiPrice { get; set; }
        public decimal FruitsPrice { get; set; }
        public int VegiKG { get; set; }
        public int FruitsKG { get; set; }
        public decimal CalculateSum()
        {
            return 1.94m * (this.FruitsKG * this.FruitsPrice + VegiKG * VegiPrice);
        }
    }
}
