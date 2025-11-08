using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// IpDetails data
    /// </summary>
    public class IpDetails
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("likelySpam")]
        public bool LikelySpam { get; set; }

        [JsonProperty("isDisposableEmail")]
        public bool IsDisposableEmail { get; set; }

        [JsonProperty("isIPBlacklisted")]
        public bool IsIPBlacklisted { get; set; }

        [JsonProperty("ipDetails")]
        public IpDetails IpDetails { get; set; }

        [JsonProperty("parsed")]
        public bool Parsed { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
