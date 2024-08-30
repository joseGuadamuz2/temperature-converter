using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temperature_converter

{ /// <summary>
  /// The Converter class provides methods to convert temperatures between Celsius and Fahrenheit.
  /// </summary>
  /// 
    public class Converter
    {
        #region Variables

        /// <summary>
        /// Gets or sets the temperature in Celsius.
        /// </summary>
        
        public float Celsius {  get; set; }

        /// <summary>
        /// Gets or sets the temperature in Fahrenheit.
        /// </summary>

        public float Fahrenheit { get; set; }


        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the Converter class with default values.
        /// </summary>

        public Converter() { }

        /// <summary>
        /// Initializes a new instance of the Converter class with specified Celsius and Fahrenheit values.
        /// </summary>
        /// <param name="celsius">The temperature in Celsius.</param>
        /// <param name="fahrenheit">The temperature in Fahrenheit.</param>
 
        public Converter(float celsius, float fahrenheit)
        {
            Celsius = celsius;
            Fahrenheit = fahrenheit;
        }
        #endregion

        #region Methods

        /// <summary>
        /// Converts a temperature from Celsius to Fahrenheit.
        /// </summary>
        /// <param name="celsiusP">The temperature in Celsius to be converted.</param>
        
        public void ConvertCelsiusToFahrenheit(float celsiusP)
        {
            
            Fahrenheit = (celsiusP * 9/5)+32;

        }

        /// <summary>
        /// Converts a temperature from Fahrenheit to Celsius.
        /// </summary>
        /// <param name="fahrenheitP">The temperature in Fahrenheit to be converted.</param>

        public void ConvertFahrenheitToCelsius(float fahrenheitP)
        {
            Celsius = (fahrenheitP - 32) * 5 / 9;

        }

        #endregion
    }


}
