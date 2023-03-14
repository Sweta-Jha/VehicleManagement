using System.Xml.Linq;
using VehicleManagement;

public class Program
{
    public static void Main()
    {
        TwoWheeler Access = new TwoWheeler();
        Access.StartEngine();
        Access.StartDriving();
        Access.StopEngine();

        TwoWheeler Activa5g = new TwoWheeler();
        TwoWheeler Jupiter = new TwoWheeler(2, "Jupiter", 2, 2, 2, 2, 1, "5 Liters");

        FourWheeler Scorpio = new FourWheeler();
        Scorpio.StartEngine();
        Scorpio.StartDriving();
        Scorpio.StopEngine();
        Scorpio.EngageHandBrake();
        Scorpio.StopDriving();
        FourWheeler Nexon = new FourWheeler(2, "Nexon",4, 6, 2, 2, 6, "8 Liters", 4, 2, 2, 4);
        FourWheeler Ciaz = new FourWheeler(2, "Ciaz", 4, 6, 2, 2, 6, "8 Liters", 4, 2, 2, 4);

    }
}