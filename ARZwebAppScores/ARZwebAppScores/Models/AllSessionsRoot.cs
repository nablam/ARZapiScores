using System;
using System.Net;
using System.Collections.Generic;

using Newtonsoft.Json;


namespace ARZwebAppScores.Models
{


    public partial class AllSessionsRoot
    {
        [JsonProperty("ListAllSessions")]
        public ListAllSession[] ListAllSessions { get; set; }
       
    }

    public partial class AllSessionsRoot
    {
        public AllSessionsRoot() { }

    }
   

    public partial class ListAllSession
    {
        [JsonProperty("PInfo")]
        public PInfo PInfo { get; set; }

        [JsonProperty("PPoints")]
        public PPoints PPoints { get; set; }

        [JsonProperty("SerrionTime")]
        public string SerrionTime { get; set; }

        public ListAllSession() { }
    }

    public partial class PPoints
    {
        [JsonProperty("headshots")]
        public long Headshots { get; set; }

        [JsonProperty("kills")]
        public long Kills { get; set; }

        [JsonProperty("maxstreak")]
        public long Maxstreak { get; set; }

        [JsonProperty("miss")]
        public long Miss { get; set; }

        [JsonProperty("score")]
        public long Score { get; set; }

        [JsonProperty("streakcount")]
        public long Streakcount { get; set; }

        [JsonProperty("totalshots")]
        public long Totalshots { get; set; }

        public PPoints() { }
    }

    public partial class PInfo
    {
        [JsonProperty("PlayerEmail")]
        public string PlayerEmail { get; set; }

        [JsonProperty("PlayerFirstName")]
        public string PlayerFirstName { get; set; }

        [JsonProperty("PlayerLastName")]
        public string PlayerLastName { get; set; }

        [JsonProperty("PlayerUserName")]
        public string PlayerUserName { get; set; }

        public PInfo() { }
    }

    public partial class AllSessionsRoot
    {
      
        public static AllSessionsRoot FromJson(string json)
        {
            return JsonConvert.DeserializeObject<AllSessionsRoot>(json, Converter3.Settings);
        }
    }

    public static class Serialize3
    {
        public static string ToJson(this AllSessionsRoot self)
        {
            return JsonConvert.SerializeObject(self, Converter3.Settings);
        }
    }

    public class Converter3
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
        };
    }
}