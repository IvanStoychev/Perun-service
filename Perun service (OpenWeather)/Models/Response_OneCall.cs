using System;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Perun_service__OpenWeather_.Models
{
    public partial class Response_OneCall
    {
        /// <summary>
        /// Current weather data.
        /// </summary>
        [JsonProperty("current")]
        public Current Current { get; set; }

        /// <summary>
        /// Hourly forecast data.
        /// </summary>
        [JsonProperty("hourly")]
        public Hourly[] Hourly { get; set; }

        /// <summary>
        /// Daily forecast data.
        /// </summary>
        [JsonProperty("daily")]
        public Daily[] Daily { get; set; }
    }

    /// <summary>
    /// Current weather data.
    /// </summary>
    public partial class Current
    {
        /// <summary>
        /// Time of data recording. [Unix, UTC]
        /// </summary>
        [JsonProperty("dt")]
        public long Dt { get; set; }

        /// <summary>
        /// Time The Sun rises. [Unix, UTC]
        /// </summary>
        [JsonProperty("sunrise")]
        public long Sunrise { get; set; }

        /// <summary>
        /// Time The Sun sets. [Unix, UTC]
        /// </summary>
        [JsonProperty("sunset")]
        public long Sunset { get; set; }

        /// <summary>
        /// Temperature in Celsius.
        /// </summary>
        [JsonProperty("temp")]
        public double Temp { get; set; }

        /// <summary>
        /// What the temperature feels like to a human. [Celsius]
        /// </summary>
        [JsonProperty("feels_like")]
        public double FeelsLike { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("pressure")]
        public long Pressure { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("humidity")]
        public long Humidity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("dew_point")]
        public double DewPoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("uvi")]
        public double Uvi { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("clouds")]
        public long Clouds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("visibility")]
        public long Visibility { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("wind_speed")]
        public double WindSpeed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("wind_deg")]
        public long WindDeg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("weather")]
        public Weather[] Weather { get; set; }
    }

    public partial class Weather
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("main")]
        public Main Main { get; set; }

        [JsonProperty("description")]
        public Description Description { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }
    }

    public partial class Daily
    {
        [JsonProperty("dt")]
        public long Dt { get; set; }

        [JsonProperty("sunrise")]
        public long Sunrise { get; set; }

        [JsonProperty("sunset")]
        public long Sunset { get; set; }

        [JsonProperty("temp")]
        public Temp Temp { get; set; }

        [JsonProperty("feels_like")]
        public FeelsLike FeelsLike { get; set; }

        [JsonProperty("pressure")]
        public long Pressure { get; set; }

        [JsonProperty("humidity")]
        public long Humidity { get; set; }

        [JsonProperty("dew_point")]
        public double DewPoint { get; set; }

        [JsonProperty("wind_speed")]
        public double WindSpeed { get; set; }

        [JsonProperty("wind_deg")]
        public long WindDeg { get; set; }

        [JsonProperty("weather")]
        public Weather[] Weather { get; set; }

        [JsonProperty("clouds")]
        public long Clouds { get; set; }

        [JsonProperty("rain", NullValueHandling = NullValueHandling.Ignore)]
        public double? Rain { get; set; }

        [JsonProperty("uvi")]
        public double Uvi { get; set; }
    }

    public partial class FeelsLike
    {
        [JsonProperty("day")]
        public double Day { get; set; }

        [JsonProperty("night")]
        public double Night { get; set; }

        [JsonProperty("eve")]
        public double Eve { get; set; }

        [JsonProperty("morn")]
        public double Morn { get; set; }
    }

    public partial class Temp
    {
        [JsonProperty("day")]
        public double Day { get; set; }

        [JsonProperty("min")]
        public double Min { get; set; }

        [JsonProperty("max")]
        public double Max { get; set; }

        [JsonProperty("night")]
        public double Night { get; set; }

        [JsonProperty("eve")]
        public double Eve { get; set; }

        [JsonProperty("morn")]
        public double Morn { get; set; }
    }

    public partial class Hourly
    {
        [JsonProperty("dt")]
        public long Dt { get; set; }

        [JsonProperty("temp")]
        public double Temp { get; set; }

        [JsonProperty("feels_like")]
        public double FeelsLike { get; set; }

        [JsonProperty("pressure")]
        public long Pressure { get; set; }

        [JsonProperty("humidity")]
        public long Humidity { get; set; }

        [JsonProperty("dew_point")]
        public double DewPoint { get; set; }

        [JsonProperty("clouds")]
        public long Clouds { get; set; }

        [JsonProperty("wind_speed")]
        public double WindSpeed { get; set; }

        [JsonProperty("wind_deg")]
        public long WindDeg { get; set; }

        [JsonProperty("weather")]
        public Weather[] Weather { get; set; }
    }

    public enum Description { BrokenClouds, ClearSky, FewClouds, LightRain, ScatteredClouds };

    public enum Main { Clear, Clouds, Rain };

    public partial class Response_OneCall
    {
        public static Response_OneCall FromJson(string json) => JsonConvert.DeserializeObject<Response_OneCall>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Response_OneCall self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                DescriptionConverter.Singleton,
                MainConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class DescriptionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Description) || t == typeof(Description?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "broken clouds":
                    return Description.BrokenClouds;
                case "clear sky":
                    return Description.ClearSky;
                case "few clouds":
                    return Description.FewClouds;
                case "light rain":
                    return Description.LightRain;
                case "scattered clouds":
                    return Description.ScatteredClouds;
            }
            throw new Exception("Cannot unmarshal type Description");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Description)untypedValue;
            switch (value)
            {
                case Description.BrokenClouds:
                    serializer.Serialize(writer, "broken clouds");
                    return;
                case Description.ClearSky:
                    serializer.Serialize(writer, "clear sky");
                    return;
                case Description.FewClouds:
                    serializer.Serialize(writer, "few clouds");
                    return;
                case Description.LightRain:
                    serializer.Serialize(writer, "light rain");
                    return;
                case Description.ScatteredClouds:
                    serializer.Serialize(writer, "scattered clouds");
                    return;
            }
            throw new Exception("Cannot marshal type Description");
        }

        public static readonly DescriptionConverter Singleton = new DescriptionConverter();
    }

    internal class MainConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Main) || t == typeof(Main?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Clear":
                    return Main.Clear;
                case "Clouds":
                    return Main.Clouds;
                case "Rain":
                    return Main.Rain;
            }
            throw new Exception("Cannot unmarshal type Main");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Main)untypedValue;
            switch (value)
            {
                case Main.Clear:
                    serializer.Serialize(writer, "Clear");
                    return;
                case Main.Clouds:
                    serializer.Serialize(writer, "Clouds");
                    return;
                case Main.Rain:
                    serializer.Serialize(writer, "Rain");
                    return;
            }
            throw new Exception("Cannot marshal type Main");
        }

        public static readonly MainConverter Singleton = new MainConverter();
    }
}
