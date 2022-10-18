namespace StaticExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(82);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(40);

            Console.WriteLine($"After conversions");
            Console.WriteLine($"celsius {celsius}");
            Console.WriteLine($"fahrenheit {fahrenheit}");
        }
    }
}