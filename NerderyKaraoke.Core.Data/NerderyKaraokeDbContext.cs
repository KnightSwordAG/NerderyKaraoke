using System.Data.Entity;

using NerderyKaraoke.Core.Data.Models;

namespace NerderyKaraoke.Core.Data
{

	public class NerderyKaraokeDbContext : DbContext
	{
		static NerderyKaraokeDbContext()
		{
			Database.SetInitializer<NerderyKaraokeDbContext>(null);
		}

		public NerderyKaraokeDbContext()
				: base("name=NerderyKaraokeDb")
		{
		}

		public IDbSet<SongRequest> Songs { get; set; }
		public IDbSet<UserRole> UserRoles { get; set; }


		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
		}
	}
}
