using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerderyKaraoke.Core.Services.Models.CommunicationHub
{
	public class SongRequestViewModel
	{
		public Guid Id { get; set; }
		public string SingerName { get; set; }
		public string SongTitle { get; set; }
		public string YouTubeUrl { get; set; }
		public int RequestOrder { get; set; }
	}
}
