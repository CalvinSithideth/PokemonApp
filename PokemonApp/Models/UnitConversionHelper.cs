using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonApp.Models
{
    public static class UnitConversionHelper
    {

        public static string DecimetersToFeetAndInches(int decimeters)
        {
            const double InchesPerDecimeter = 3.937;
            const double InchesPerFeet = 12;

            double totalInches = decimeters * InchesPerDecimeter;
            int feet = (int) (totalInches / InchesPerFeet);
            int inchesLeft = (int) Math.Round(totalInches % InchesPerFeet);
            return $@"{feet}'{inchesLeft}""";
        }

        public static string HectogramsToPoundsAndOunces(int hectograms)
        {
            const double OuncesPerHectogram = 3.527;
            const double OuncesPerPound = 16;

            throw new NotImplementedException();
        }
    }
}
