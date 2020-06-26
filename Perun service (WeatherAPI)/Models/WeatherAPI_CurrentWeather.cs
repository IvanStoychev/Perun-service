using Newtonsoft.Json;
using System;

namespace WeatherAPI.Standard.Models
{
    /// <summary>
    /// Represents select information from the WeatherAPI current weather response.
    /// </summary>
    public class WeatherAPI_CurrentWeather
    {
        /// <summary>
        /// Local time when the data was updated in unix time.
        /// </summary>
        [JsonProperty("last_updated_epoch")]
        public int? LastUpdatedUnix;

        /// <summary>
        /// Local time when the data was updated.
        /// </summary>
        [JsonProperty("last_updated")]
        public DateTime LastUpdated;

        /// <summary>
        /// The temperature in celsius.
        /// </summary>
        [JsonProperty("temp_c")]
        public double? Temperature;

        /// <summary>
        /// The human-readable overall weather condition.
        /// </summary>
        public string Condition;

        /// <summary>
        /// Wind speed in kilometers per hour.
        /// </summary>
        [JsonProperty("wind_kph")]
        public double? WindSpeed;

        /// <summary>
        /// Wind direction in degrees, 0 being North.
        /// </summary>
        [JsonProperty("wind_degree")]
        public int? WindDirectionDegrees;

        /// <summary>
        /// Wind direction as 16 point compass. E.g.: NSW.
        /// </summary>
        [JsonProperty("wind_dir")]
        public string WindDirectionCompass;

        /// <summary>
        /// Atmospheric pressure in millibars.
        /// </summary>
        [JsonProperty("pressure_mb")]
        public double? Pressure;

        /// <summary>
        /// Rainfall amount in millimeters.
        /// </summary>
        [JsonProperty("precip_mm")]
        public double? Precipitation;

        /// <summary>
        /// Air humidity percentage.
        /// </summary>
        [JsonProperty("humidity")]
        public int? Humidity;

        /// <summary>
        /// Percentage of the sky covered by clouds.
        /// </summary>
        [JsonProperty("cloud")]
        public int? CloudCover;

        /// <summary>
        /// "Feels like" temperature in celcius.
        /// </summary>
        [JsonProperty("feelslike_c")]
        public double? FeelsLike;

        /// <summary>
        /// Kilometers of clear visibility.
        /// </summary>
        [JsonProperty("vis_km")]
        public double? Visibility;

        /// <summary>
        /// UV Index.
        /// </summary>
        [JsonProperty("uv")]
        public double? UvIndex;

        /// <summary>
        /// Wind gust speed in kilometers per hour.
        /// </summary>
        [JsonProperty("gust_kph")]
        public double? GustSpeed;
    }
} 