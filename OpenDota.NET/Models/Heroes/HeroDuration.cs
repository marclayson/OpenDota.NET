﻿namespace OpenDotaDotNet.Models.Heroes
{
    using System.Text.Json.Serialization;

    public class HeroDuration
    {
        /// <summary>
        /// Gets or sets lower bound of number of seconds the match lasted.
        /// </summary>
        [JsonPropertyName("duration_bin")]
        public int DurationBin { get; set; }

        /// <summary>
        /// Gets or sets number of games played.
        /// </summary>
        [JsonPropertyName("games_played")]
        public int GamesPlayed { get; set; }

        /// <summary>
        /// Gets or sets number of wins.
        /// </summary>
        [JsonPropertyName("wins")]
        public int Wins { get; set; }
    }
}
