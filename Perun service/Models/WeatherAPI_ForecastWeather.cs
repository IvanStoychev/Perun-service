using Newtonsoft.Json;

namespace WeatherAPI.Standard.Models
{
    /// <summary>
    /// Contains information about the minimum, maximum and average weather conditions for a day.
    /// </summary>
    public class WeatherAPI_ForecastWeather
    {
        /// <summary>
        /// Maximum temperature, in celsius, for the day.
        /// </summary>
        [JsonProperty("maxtemp_c")]
        public double? MaxTemperature;

        /// <summary>
        /// Minimum temperature, in celsius, for the day.
        /// </summary>
        [JsonProperty("mintemp_c")]
        public double? MinTemperature;

        /// <summary>
        /// Average temperature, in celsius, for the day.
        /// </summary>
        [JsonProperty("avgtemp_c")]
        public double? AverageTemperature;

        /// <summary>
        /// Maximum wind speed, in kilometers per hour, for the day.
        /// </summary>
        [JsonProperty("maxwind_kph")]
        public double? MaxWindSpeed;

        /// <summary>
        /// Total rain amount, in milimeters, for the day.
        /// </summary>
        [JsonProperty("totalprecip_mm")]
        public double? TotalPrecipitation;

        /// <summary>
        /// Average visibility, in kilometers, for the day.
        /// </summary>
        [JsonProperty("avgvis_km")]
        public double? AverageVisibilityKm;

        /// <summary>
        /// Average humidity, as percentage, for the day.
        /// </summary>
        [JsonProperty("avghumidity")]
        public double? AverageHumidity;

        /// <summary>
        /// The average human-readable overall weather condition for the day.
        /// </summary>
        [JsonProperty("condition")]
        public string Condition;

        /// <summary>
        /// The average UV Index for the day.
        /// </summary>
        [JsonProperty("uv")]
        public double? UvIndex;
    }
} 