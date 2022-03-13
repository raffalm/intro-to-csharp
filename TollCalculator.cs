using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommercialRegistration;
using ConsumerVehicleRegistration;
using LiveryRegistration;

namespace IntroductionToCSharp.Calculators
{
    /*
    A Car is $2.00.
    A Taxi is $3.50.
    A Bus is $5.00.
    A DeliveryTruck is $10.00
    */

    public class TollCalculator
    {
        public decimal CalculateToll(object vehicle) =>
            vehicle switch
            {   //example of property pattern
                Car { Passengers: 0 } => 2.00m + 0.50m,
                Car { Passengers: 1 } => 2.00m,
                Car { Passengers: 2 } => 2.00m - 0.50m,
                Car => 2.00m - 1.00m,
                
                Taxi t=> t.Fares switch //example of nested switch
                {
                0 =>3.50m+1.0m,
                1 =>3.50m,
                2  =>3.50m-0.5m,
                _ => 3.50m - 1.0m,
                },
                                   
                Bus b when ((double)b.Riders/(double)b.Capacity)<0.5 =>5.00m+2.0m,
                Bus b when ((double)b.Riders/(double)b.Capacity)>0.9 =>5.00m-1.0m,
                Bus b => 5.00m,

                DeliveryTruck t when (t.GrossWeightClass>5000) =>10.00m+5.00m,
                DeliveryTruck t when (t.GrossWeightClass<3000) =>10.00m-2.00m,
                DeliveryTruck t => 10.00m,
                { } => throw new ArgumentException(message: "Not a known vehicle type", paramName: nameof(vehicle)),
                null => throw new ArgumentNullException(nameof(vehicle))
            };
        public decimal PeakTimePremium(DateTime timeOfToll, bool inbound) =>
            (IsWeekDay(timeOfToll),GetTimeBand(timeOfToll),inbound) switch
            {
                (true, TimeBand.Overnight, _) => 0.75m,
                (true, TimeBand.Daytime, _) => 1.50m,
                (true,TimeBand.MorningRush,true) => 2.00m,
                (true,TimeBand.EveningRush,false) => 2.00m,
                _ => 1.00m,
            };

        private static bool IsWeekDay(DateTime timeOfToll) => timeOfToll.DayOfWeek switch
        {
            DayOfWeek.Saturday => false,
            DayOfWeek.Sunday => false,
            _ => true
        };
        private enum TimeBand
        {
            MorningRush,
            Daytime,
            EveningRush,
            Overnight
        }
        private static TimeBand GetTimeBand(DateTime timeOfToll) => timeOfToll.Hour switch
        {
            < 6 or > 19 => TimeBand.Overnight,
            < 10 => TimeBand.MorningRush,
            < 16 => TimeBand.Daytime,
            _ => TimeBand.Daytime
        };


    }
}
