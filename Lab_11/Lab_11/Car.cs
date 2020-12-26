using System;
using System.Collections.Generic;

namespace Lab_11
{
    class Car
    {
        public bool WheelAlignerDone { get; set; }
        public bool paintingDone { get; set; }
        public bool oilChangeDone { get; set; }
        public bool fullTechnicalInspection { get; set; }
        public bool wheelReplacementDone { get; set; }
        public bool bodyRepairDone { get; set; }


        public void showInfo()
        {
            Console.WriteLine($"Wheel aligner is done - {WheelAlignerDone}");
            Console.WriteLine($"painted - {paintingDone}");
            Console.WriteLine($"oil change is performed - {oilChangeDone}");
            Console.WriteLine($"full technical inspection passed - {fullTechnicalInspection}");
            Console.WriteLine($"wheel replacement performed - {wheelReplacementDone}");
            Console.WriteLine($"body repair performed - {bodyRepairDone}");

        }
    }
}
