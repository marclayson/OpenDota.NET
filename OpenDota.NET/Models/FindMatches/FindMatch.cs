﻿namespace OpenDotaDotNet.Models.FindMatches
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class FindMatch
    {
        [JsonPropertyName("match_id")]
        public long MatchId { get; set; }

        [JsonPropertyName("teama")]
        public List<int> TeamA { get; set; }

        [JsonPropertyName("teamb")]
        public List<int> TeamB { get; set; }

        [JsonPropertyName("teamawin")]
        public bool TeamAWin { get; set; }

        [JsonPropertyName("start_time")]
        public long StartTime { get; set; }
    }
}
