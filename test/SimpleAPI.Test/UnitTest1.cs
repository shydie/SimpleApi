using SimpleAPI.Controllers;
namespace SimpleAPI.Test;

public class UnitTest1
{

    WeatherForecastController controller = new WeatherForecastController();
    [Fact]
    public void GetWeatherValue()
    {
        var returnValue = controller.Get(1);
        Assert.Equal("Freezing", returnValue.Value);
    }



    [Fact]
    public void Test1()
    {

    }
}