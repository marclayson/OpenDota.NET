﻿namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.HeroStats;

    public class HeroStatsEndpoint : IHeroStatsEndpoint
    {
        private readonly Requester requester;

        public HeroStatsEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <inheritdoc />
        public async Task<List<HeroStats>> GetHeroStatsAsync() =>
            await this.requester.GetResponseAsync<List<HeroStats>>("heroStats");
    }
}
