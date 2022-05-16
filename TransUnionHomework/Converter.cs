using System;

namespace TransUnionHomework
{
    public class Converter
    {
        public int CelsiusToFahrenheit(int celsius)
        {
            return celsius * 18 / 10 + 32;
        }

        public int CelsiusToKelvin(int celsius)
        {
            return celsius + 273;
        }

        public int KelvinToCelsius(int kelvin)
        {
            return kelvin - 273;
        }

        public int KelvinToFahrenheit(int kelvin)
        {
            return 18*(kelvin - 273)/10 + 32;
        }

        public int FahrenheitToCelsius(int fah)
        {
            return (fah - 32) * 5 / 9;
        }

        public int FahrenheitToKelvin(int fah)
        {
            return (fah - 32) * 5 / 9 + 273;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var converter = new Converter();

            while (true)
            {
                Console.WriteLine("Select the unit you want to convert by entering its number. ");
                Console.WriteLine("1. Celsius, 2. Kelvin, 3. Fahrenheit");
                var unit = Convert.ToInt32(Console.ReadLine());
                var unit2 = 0;
                switch (unit)
                {
                    //If celsius was selected
                    case 1:
                        Console.WriteLine("Enter your Celsius Value");
                        var celsius = Convert.ToInt32(Console.ReadLine());
                        
                        Console.WriteLine("Select the unit you want your value to be converted to by its number");
                        Console.WriteLine("1. Kelvin, 2. Fahrenheit");
                        unit2 = Convert.ToInt32(Console.ReadLine());
                        
                        //If convert to Kelvin
                        if (unit2 == 1)
                        {
                            Console.WriteLine(celsius + " Celsius converted to Kelvin is: " + converter.CelsiusToKelvin(celsius));
                            break;
                        }
                        Console.WriteLine(celsius + " Celsius converted to Fahrenheit is: " + converter.CelsiusToFahrenheit(celsius));
                        break;
                    
                    //If Kelvin was selected
                    case 2:
                        Console.WriteLine("Enter your Kelvin Value");
                        var kelvin = Convert.ToInt32(Console.ReadLine());
                        
                        Console.WriteLine("Select the unit you want your value to be converted to by its number");
                        Console.WriteLine("1. Celsius, 2. Fahrenheit");
                        unit2 = Convert.ToInt32(Console.ReadLine());
                        
                        //If convert to Celsius
                        if (unit2 == 1)
                        {
                            Console.WriteLine(kelvin + " Kelvin converted to Celsius is: " + converter.KelvinToCelsius(kelvin));
                            break;
                        }
                        Console.WriteLine(kelvin + " Kelvin converted to Fahrenheit is: " + converter.KelvinToFahrenheit(kelvin));
                        break;
                    
                    //If Fahrenheit was selected
                    case 3:
                        Console.WriteLine("Enter your Fahrenheit Value");
                        var fah = Convert.ToInt32(Console.ReadLine());
                        
                        Console.WriteLine("Select the unit you want your value to be converted to by its number");
                        Console.WriteLine("1. Celsius, 2. Kelvin");
                        unit2 = Convert.ToInt32(Console.ReadLine());
                        
                        //If convert to Celsius
                        if (unit2 == 1)
                        {
                            Console.WriteLine(fah + " Fahrenheit converted to Celsius is: " + converter.FahrenheitToCelsius(fah));
                            break;
                        }
                        Console.WriteLine(fah + " Fahrenheit converted to Kelvin is: " + converter.FahrenheitToKelvin(fah));
                        break;
                }
                
                Console.WriteLine("Do you want to convert more temperatures? Enter Y for yes or N for no");
                string doContinue = Console.ReadLine();
                if (doContinue.Equals("N"))
                {
                    break;
                }

            }
            
        }
    }
}

