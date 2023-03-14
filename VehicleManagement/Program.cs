using System.Xml.Linq;
using VehicleManagement;

public class Program
{
    public static void Main()
    {
        TwoWheeler Access = new TwoWheeler();
        Access.PrintAllDetails();
        Access.StartEngine();
        Access.StartDriving();
        Access.StopEngine();
        
        TwoWheeler Activa5g = new TwoWheeler();
        TwoWheeler Jupiter = new TwoWheeler(2, "Jupiter", 2, 2, 2, 2, 1, "5 Liters");
        Jupiter.PrintAllDetails();

        FourWheeler Scorpio = new FourWheeler();
        FourWheeler Nexon = new FourWheeler(2, "Nexon", 4, 6, 2, 2, 6, "8 Liters", 4, 2, 2, 4);
        Nexon.PrintAllDetails();
        FourWheeler Ciaz = new FourWheeler(2, "Ciaz", 4, 6, 2, 2, 6, "8 Liters", 4, 2, 2, 4);
        Ciaz.PrintAllDetails();

        Scorpio.PrintAllDetails();
        Scorpio.StartEngine();
        Scorpio.StartDriving();
        Scorpio.StopEngine();
        Scorpio.EngageHandBrake();
        Scorpio.StopDriving();

    }
}