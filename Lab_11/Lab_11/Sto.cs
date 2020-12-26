using System;
using System.Collections.Generic;

namespace Lab_11
{
    class Sto
    {
        public void WheelAlignerDone(Car car) => car.WheelAlignerDone = true;
        public void paintingDone(Car car) => car.paintingDone = true;
        public void oilChangeDone(Car car) => car.oilChangeDone = true;
        public void fullTechnicalInspection(Car car) => car.fullTechnicalInspection = true;
        public void wheelReplacementDone(Car car) => car.wheelReplacementDone = true;
        public void bodyRepairDone(Car car) => car.bodyRepairDone = true;
    }
}
