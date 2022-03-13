using System;
using CommercialRegistration;
using ConsumerVehicleRegistration;
using LiveryRegistration;
using IntroductionToCSharp.Calculators;


namespace IntroductionToCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new();
            Taxi taxi = new();
            Bus bus = new();
            DeliveryTruck truck = new();
            TollCalculator tollCalc = new();

            /*
            Console.WriteLine($"The toll for a car is {tollCalc.CalculateToll(car)}");
            Console.WriteLine($"The toll for a taxi is {tollCalc.CalculateToll(taxi)}");
            Console.WriteLine($"The toll for a bus is {tollCalc.CalculateToll(bus)}");
            Console.WriteLine($"The toll for a truck is {tollCalc.CalculateToll(truck)}");
            */

            DateTime weekend = new(2022,3,13);
            DateTime weekdayNight = new(2022, 3, 14, 2, 0,0);
            DateTime weekdayMorning = new(2022, 3, 14, 7, 0,0);
            DateTime weekdayDaytime = new(2022, 3, 14, 17, 0,0);
            DateTime weekdayEvening = new(2022, 3, 14, 20, 0,0);

            Console.WriteLine($"The toll for a car in morning rush inbound direction is {tollCalc.CalculateToll(car)}+{tollCalc.PeakTimePremium(weekdayMorning,true)}");
            Console.WriteLine($"The toll for a car in morning rush outbound direction is {tollCalc.CalculateToll(car)}+{tollCalc.PeakTimePremium(weekdayMorning,false)}");
            
            Console.WriteLine($"The toll for a taxi at night is {tollCalc.CalculateToll(taxi)}+{tollCalc.PeakTimePremium(weekdayNight,false)}");
            Console.WriteLine($"The toll for a bus in daytime is {tollCalc.CalculateToll(bus)}+{tollCalc.PeakTimePremium(weekdayDaytime,true)}");
            Console.WriteLine($"The toll for a truck in weekend is {tollCalc.CalculateToll(truck)}+{tollCalc.PeakTimePremium(weekend,true)}");

            /*try
            {
                tollCalc.CalculateToll("this will fail");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Caught an argument exception when using the wrong type\n{e}");
            }
            try
            {
                tollCalc.CalculateToll(null!);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Caught an argument exception when using null\n{e}");
            }*/
        }
    }
}
