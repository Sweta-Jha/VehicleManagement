using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static VehicleManagement.FourWheeler;
using System.Xml.Linq;

namespace VehicleManagement
{
    internal class TwoWheeler
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SeatingCapacity { get; set; }
        public string FuelTankSize { get; set; }
        public int HeadLightCount { get; set; }
        public int IndicatorCount { get; set; }
        public int ExhaustCount { get; set; }
        public int NoOfHelmet { get; set; }
        public int WheelsCount { get; set; }
        public enum VehicleType
        {
            Electric = 1,
            NonElectric = 2
        }
        public TwoWheeler()
        {
            Id = 1;
            NoOfHelmet = 2;
            WheelsCount = 3;
            HeadLightCount = 4;
            IndicatorCount = 5;
            ExhaustCount = 6;
            NoOfHelmet = 7;
            FuelTankSize = "5 Liters";
            
        }
        public TwoWheeler(int id, string name, int wheelscount, int headLightcount, int indicatorCount, int exhaustCount, int noOfHelmet, string fuelTankSize)
        {
            Id = id;
            Name = name;
            WheelsCount = wheelscount;
            HeadLightCount = headLightcount;
            ExhaustCount = exhaustCount;
            NoOfHelmet = noOfHelmet;
            IndicatorCount = indicatorCount;
            FuelTankSize = fuelTankSize;
           
        }
        //Method for starting 2 wheelers
        public void StartEngine()
        {
            Console.WriteLine("Start Engine for two wheeler");

        }
        public void StartDriving()
        {
            Console.WriteLine("Start Driving  two wheeler");
        }
        //Methods for stoping 2 wheelers
        public void StopEngine()
        {
            Console.WriteLine("Stop Engine for two wheeler");
        }
        public void StopDriving()
        {
            Console.WriteLine("Stop Driving  two wheeler");
        }
    }
}
