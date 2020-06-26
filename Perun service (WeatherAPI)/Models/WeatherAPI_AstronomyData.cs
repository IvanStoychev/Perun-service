using Newtonsoft.Json;
using System;

namespace WeatherAPI.Standard.Models
{
    /// <summary>
    /// Contains information about when The Sun and Moon rise and set.
    /// </summary>
    public class WeatherAPI_AstronomyData
    {
        private TimeSpan sunrise;
        private TimeSpan sunset;
        private TimeSpan moonrise;
        private TimeSpan moonset;

        /// <summary>
        /// The time The Sun rises.
        /// </summary>
        [JsonProperty("sunrise")]
        public string Sunrise
        {
            get => sunrise.ToString();
            set => sunrise = DateTime.Parse(value).TimeOfDay;
        }

        /// <summary>
        /// The time The Moon sets.
        /// </summary>
        [JsonProperty("moonset")]
        public string Moonset
        {
            get => moonset.ToString();
            set => moonset = DateTime.Parse(value).TimeOfDay;
        }

        /// <summary>
        /// The time The Moon rises.
        /// </summary>
        [JsonProperty("moonrise")]
        public string Moonrise
        {
            get => moonrise.ToString();
            set => moonrise = DateTime.Parse(value).TimeOfDay;
        }

        /// <summary>
        /// The time The Sun sets.
        /// </summary>
        [JsonProperty("sunset")]
        public string Sunset
        {
            get => sunset.ToString();
            set => sunset = DateTime.Parse(value).TimeOfDay;
        }
    }
}