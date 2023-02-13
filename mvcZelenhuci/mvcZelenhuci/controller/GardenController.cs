using mvcZelenhuci.model;
using mvcZelenhuci.view;
using System;
using System.Collections.Generic;
using System.Text;

namespace mvcZelenhuci.controller
{
    public class GardenController
    {
        private Display display;
        private Garden garden;

        public GardenController()
        {
            display = new Display();
            garden = new Garden(display.VegiPrice,display.FruitsPrice,display.VegiKG,display.FruitsKG);
            display.Total = garden.CalculateSum();
            display.Showresut();
        }
    }
}
