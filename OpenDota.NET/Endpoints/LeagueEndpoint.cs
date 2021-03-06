﻿namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.Leagues;

    public class LeagueEndpoint : ILeagueEndpoint
    {
        private readonly Requester requester;

        public LeagueEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <inheritdoc />
        public async Task<List<League>> GetLeaguesAsync() =>
            await this.requester.GetResponseAsync<List<League>>("leagues");
    }
}
