using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumeralGenerator
{
    /// <summary>
    /// The implementation of the interface for generating Roman numerals using a dictionary.
    /// N.B. I have included class/test/interface all in one namespace/project for simplicity in this sample.
    /// Obviously in a real world scenario the code would be correctly namespaced.
    /// </summary>
    public class RomanNumeralGenerator : IRomanNumeralGenerator
    {
        static Dictionary<int, string> numerals = new Dictionary<int, string>
        {
                { 1000, "M" }, 
                { 900, "CM" },
                { 500, "D" }, 
                { 400, "CD" },
                { 100, "C" }, 
                { 90, "XC" },
                { 50, "L" }, 
                { 40, "XL" },
                { 10, "X" }, 
                { 9, "IX" },
                { 5, "V" }, 
                { 4, "IV" },
                { 1, "I" }
        };

        public string Generate(int number)
        {
            Validate(number);

            StringBuilder numeralBuilder = new StringBuilder();

            foreach (var numeral in numerals)
            {
                while (number >= numeral.Key)
                {
                    numeralBuilder.Append(numeral.Value);
                    number -= numeral.Key;
                }
            }

            return numeralBuilder.ToString();
        }

        void Validate(int number)
        {
            if (number < 1 || number > 3999)
            {
                throw new ArgumentOutOfRangeException();
            }
        }        
    }
}
