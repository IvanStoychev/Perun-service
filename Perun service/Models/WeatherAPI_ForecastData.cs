using Newtonsoft.Json;
using System;

namespace WeatherAPI.Standard.Models
{
    public class WeatherAPI_ForecastData
    {
        /// <summary>
        /// The forecasted date.
        /// </summary>
        [JsonProperty("date")]
        public DateTime Date;

        /// <summary>
        /// The forecasted date as unix time.
        /// </summary>
        [JsonProperty("date_epoch")]
        public int? DateUnix;

        /// <summary>
        /// Weather information for the whole day.
        /// </summary>
        [JsonProperty("day")]
        public WeatherAPI_ForecastWeather ForecastWeather;

        /// <summary>
        /// Astronomy data for the day.
        /// </summary>
        [JsonProperty("astro")]
        public WeatherAPI_AstronomyData ForecastAstronomy;
    }
} 