using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class ipDetails
{
    [JsonProperty("country")]
    public string country { get; set; }

    [JsonProperty("region")]
    public string region { get; set; }

}

public class data
{
    [JsonProperty("likelySpam")]
    public bool likelySpam { get; set; }

    [JsonProperty("isDisposableEmail")]
    public bool isDisposableEmail { get; set; }

    [JsonProperty("isIPBlacklisted")]
    public bool isIPBlacklisted { get; set; }

    [JsonProperty("parsed")]
    public bool parsed { get; set; }

    [JsonProperty("ipDetails")]
    public ipDetails ipDetails { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

}

}
