using System;
using System.Collections.Generic;
using System.Text;

namespace mvcZelenhuci.view
{
    public class Display
    {
        public Display()
        {
            this.VefiPrice = 0;
            this.FruitsPrice = 0;
            this.VegiKG = 0;
            this.FruitsKG = 0;
            this.Total = 0;
        }

        public decimal VegiPrice { get; set; }
        public decimal FruitsPrice { get; set; }
        public int VegiKG { get; set; }
        public int FruitsKG { get; set; }
        public decimal Total { get; set; }

        public void GetValues()
        {
            this.VegiPrice = decimal.Parse(Console.ReadLine());
            this.FruitsPrice = decimal.Parse(Console.ReadLine());
            this.VegiKG = int.Parse(Console.ReadLine());
            this.FruitsKG = int.Parse(Console.ReadLine());
        }

        public void Showresut()
        {
            Console.WriteLine(this.Total);
        }
    }
}
