using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagement
{
    internal class FourWheeler
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SpeakerCount { get; set; }
        public int WindowCount { get; set; }
        public int DiscBrakeCount { get; set; }
        public int SeatBeltCount { get; set; }
        public int SeatingCapacity { get; set; }
        public string FuelTankSize { get; set; }
        public int HeadLightCount { get; set; }
        public int IndicatorCount { get; set; }
        public int ExhaustCount { get; set; }
        public int WheelsCount { get; set; }

        public enum FuelType
        {
            Petrol = 1,
            Diesel = 2

        }
        public FourWheeler()
        {
            Id = 1;
            WindowCount = 4;
            SeatingCapacity = 5;
            SeatBeltCount = 2;
            HeadLightCount = 4;
            IndicatorCount = 2;
            DiscBrakeCount = 2;
            FuelTankSize = "8 Liters";

        }
        public FourWheeler(int id, string name, int speakerCount, int windowCount, int discBrakeCount, int seatBeltCount, int seatingCapacity, string fuelTankSize, int headLightCount, int indicatorCount, int exhaustCount, int wheelsCount)
        {
            Id = id;
            Name = name;
            SpeakerCount = speakerCount;
            WindowCount = windowCount;
            DiscBrakeCount = discBrakeCount;
            SeatBeltCount = seatBeltCount;
            SeatingCapacity = seatingCapacity;
            FuelTankSize = fuelTankSize;
            HeadLightCount = headLightCount;
            IndicatorCount = indicatorCount;
            ExhaustCount = exhaustCount;
            WheelsCount = wheelsCount;

        }
        //Method for starting 4 wheelers
        public void StartEngine()
        {
            Console.WriteLine("Start Engine for four wheeler");
        }
        public void StartDriving()
        {
            Console.WriteLine("Start Driving  four wheeler");
        }
        public void ReleaseHandBrake()
        {
            Console.WriteLine("Release the brake for four wheeler");
        }
        //Method for stoping 4 wheelers
        public void StopEngine()
        {
            Console.WriteLine("Stop Engine for four wheeler");
        }
        public void StopDriving()
        {
            Console.WriteLine("Stop Driving  four wheeler");
        }
        public void EngageHandBrake()
        {
            Console.WriteLine("Engage the brake for four wheeler");
        }
    }
}
