using Autofac;
using NerderyKaraoke.Core.Data;
using NerderyKaraoke.Core.Data.Models;
using NerderyKaraoke.Core.Data.Repositories;
using NerderyKaraoke.Core.Services;

namespace NerderyKaraoke.UI.BindingModules
{
	public class RepositoryModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			base.Load(builder);

			builder.RegisterType<NerderyKaraokeDbContext>()
				.AsSelf()
				.InstancePerRequest();

			builder.RegisterType<SongRequestRepository>()
				.As<IRepository<SongRequest>>()
				.InstancePerRequest();

			builder.RegisterType<SongRequestManager>()
				.As<ISongRequestManager>()
				.InstancePerRequest();

			builder.RegisterType<CommunicationHub>()
				.As<ICommunicationHub>()
				.SingleInstance();
		
		}
	}
}