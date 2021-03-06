﻿namespace OpenDotaDotNet.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using OpenDotaDotNet.Models.Live;

    public class LiveEndpoint : ILiveEndpoint
    {
        private readonly Requester requester;

        public LiveEndpoint(Requester requester)
        {
            this.requester = requester;
        }

        /// <inheritdoc />
        public async Task<List<LiveGame>> GetTopLiveGamesAsync() =>
            await this.requester.GetResponseAsync<List<LiveGame>>("live");
    }
}
