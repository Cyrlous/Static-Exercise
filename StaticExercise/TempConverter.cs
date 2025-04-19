namespace StaticExercise;

public static class TempConverter
{
    //Fields
    private static bool _validInput = false;
    private static int _answer;
    public static double FahrenheitToCelsius(double temp)
    {
         return (temp - 32) * 5 / 9;
    }

    public static double CelsiusToFahrenheit(double temp)
    {
        return (temp * 1.8) + 32;
    }

    public static void Menu()
    {
        //Main loop.  Will continue to allow user to make selections
        //until 3 is selected at which point the program will exit
        do
        {
            Console.WriteLine("TEMPERATURE CONVERTER\n");
            Console.WriteLine("1. Convert Fahrenheit to Celsius");
            Console.WriteLine("2. Convert Celsius to Fahrenheit");
            Console.WriteLine("3. Exit\n");
            Console.WriteLine("Please Enter Your Selection:");

            //Filter user input to ensure it is an integer
            if (int.TryParse(Console.ReadLine(), out _answer))
            {
                _validInput = true;
            }
            else
            {
                _validInput = false;
                continue;
            }
            

            //Switch case to execute the various menu options
            switch (_answer)
            {
                //Case 1 will allow the user to convert Fahrenheit to Celsius
                case 1:
                {
                    double tempFahrenheit = 0;
                    do
                    {
                        Console.WriteLine($"Please enter the temperature in Fahrenheit:");
                        if (double.TryParse(Console.ReadLine(), out tempFahrenheit))
                        {
                            Console.WriteLine($"The temperature in Celcius is {Math.Round(TempConverter.FahrenheitToCelsius(tempFahrenheit), 2)} degrees.)\n");
                            Console.WriteLine("Please press enter to continue.");
                            Console.ReadLine();
                            _validInput = true;
                        }
                        else
                        {
                            _validInput = false;
                        }
                    } while (_validInput == false);

                    break;
                }
                //Case 2 will allow the user to convert Celsius to Fahrenheit
                case 2:
                {
                    double tempCelsius = 0;
                    do
                    {
                        Console.WriteLine("Please enter the temperature in Celsius:");
                        if (double.TryParse(Console.ReadLine(), out tempCelsius))
                        {
                            Console.WriteLine($"The temperature in Fahrenheit is {Math.Round(TempConverter.CelsiusToFahrenheit(tempCelsius), 2)} degrees.\n");
                            Console.WriteLine("Please press enter to continue.");
                            Console.ReadLine();
                            _validInput = true;
                        }
                        else
                        {
                            _validInput = false;
                        }
                    } while (_validInput == false);

                    break;
                }
                //Case 3 will exit the program
                case 3:
                {
                    Console.WriteLine($"Thank you for using the Temperature Converter.  Please have a nice day.");
                    break;
                }
                default:
                {
                    Console.WriteLine("Please enter a valid selection.");
                    break;
                }
            }
        } while (_answer != 3);
    }
}