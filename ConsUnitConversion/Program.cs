﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsUnitConversion
{
    class Program
    {
        delegate double ConvertUnit(double value);
        
        

        public double MileToKm(double mile)
        {
            return mile * 1.609344;
        }

        public double CelsiusToKelvin(double celsius)
        {
            return celsius + 273.15;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            double input = 20f;

            ConvertUnit cu = new ConvertUnit(p.MileToKm);
            double km = cu(input);
            Console.WriteLine($"{input} miles = {Math.Round(km, 3)} km");

            cu = new ConvertUnit(p.CelsiusToKelvin);
            double kelvin = cu(input);
            Console.WriteLine($"{input} °C = {Math.Round(kelvin, 3)} Kelvin");

            Console.ReadKey();
        }
    }
}
