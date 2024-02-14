

namespace ElonToysTests;

public class UnitTest1
{
    [Fact]
    public void BuyANewCar()
    {
        RemoteControlCar car =   new RemoteControlCar(0, 100);
        
        Assert.NotNull(car.Buy());
    } [Fact]
    public void NewCarDistanceDisplay()
    {
        var car = new RemoteControlCar(0, 100);
        Assert.Equal("Driven 0 meters", car.DistanceDisplay());
    }[Fact]
    public void BatteryDisplay()
    {
        var car = new RemoteControlCar(0, 100);
        Assert.Equal("Battery at 100%", car.BatteryDisplay());
    }[Fact]
    public void Driven()
    {
        var car = new RemoteControlCar(0, 100);
        car.Drive();
        Assert.Equal("Driven 20 meters", car.DistanceDisplay());
    }[Fact]
    public void EmptyBattary()
    {
        var car = new RemoteControlCar(0, 100);
        for (var i = 0; i < 100; i++)
        {
            car.Drive();
        }

        car.Drive();
        Assert.Equal("Battery empty", car.BatteryDisplay());
    }
}
