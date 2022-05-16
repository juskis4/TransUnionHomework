using NUnit.Framework;
using TransUnionHomework;
namespace UnitTestsTransUnion
{
    public class ConverterTest
    {
        [Test]
        public void Converting_From_Celsius_To_Fahrenheit()
        {
            int celsius = 100;
            Converter converter = new Converter();

            int result = converter.CelsiusToFahrenheit(celsius);
            
            Assert.AreEqual(212, result);
        }
        
        [Test]
        public void Converting_From_Celsius_To_Kelvin()
        {
            int celsius = 100;
            Converter converter = new Converter();

            int result = converter.CelsiusToKelvin(celsius);
            
            Assert.AreEqual(373, result);
        }
        
        [Test]
        public void Converting_From_Kelvin_To_Celsius()
        {
            int kelvin = 100;
            Converter converter = new Converter();

            int result = converter.KelvinToCelsius(kelvin);
            
            Assert.AreEqual(-173, result);
        }
        
        [Test]
        public void Converting_From_Kelvin_To_Fahrenheit()
        {
            int kelvin = 300;
            Converter converter = new Converter();

            int result = converter.KelvinToFahrenheit(kelvin);
            
            Assert.AreEqual(80, result);
        }
        
        [Test]
        public void Converting_From_Fahrenheit_To_Celsius()
        {
            int fahrenheit = 32;
            Converter converter = new Converter();

            int result = converter.FahrenheitToCelsius(fahrenheit);
            
            Assert.AreEqual(0, result);
        }
        
        [Test]
        public void Converting_From_Fahrenheit_To_Kelvin()
        {
            int fahrenheit = 81;
            Converter converter = new Converter();

            int result = converter.FahrenheitToKelvin(fahrenheit);
            
            Assert.AreEqual(300, result);
        }
    }
}