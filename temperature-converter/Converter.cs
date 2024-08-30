using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temperature_converter
{
    public class Converter
    {
        #region Variables
        public float Celsius {  get; set; }
         public float Fahrenheit { get; set; }

         
        #endregion

        #region Constructor
        public Converter() { }
        public Converter(float celsius, float fahrenheit)
        {
            Celsius = celsius;
            Fahrenheit = fahrenheit;
        }
        #endregion

        #region Methods
        public void ConvertCelsiusToFahrenheit(float celsiusP)
        {
            
            Fahrenheit = (celsiusP * 9/5)+32;

        }
        public void ConvertFahrenheitToCelsius(float fahrenheitP)
        {
            Celsius = (fahrenheitP - 32) * 5 / 9;

        }

        #endregion
    }


}
