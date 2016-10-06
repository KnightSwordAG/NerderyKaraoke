using System;
using AutoMapper;

using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace NerderyKaraoke.Core.Services
{
	[HubName("KaraokeCommHub")]
	public class CommunicationHub : Hub, ICommunicationHub
	{
		private readonly ISongRequestManager _songRequestManager;
		private readonly IMapper _mapper;

		public CommunicationHub(ISongRequestManager songRequestManager, IMapper mapper)
		{
			_songRequestManager = songRequestManager;
			if(_songRequestManager == null)
				throw new ArgumentNullException(nameof(songRequestManager));

			_mapper = mapper;
			if (_mapper == null)
				throw new ArgumentNullException(nameof(mapper));
		}

		public void Update()
		{
			var songRequests = _songRequestManager.GetAll();
			Clients.All.broadcastUpdate(songRequests);
		}

	
	}
}
