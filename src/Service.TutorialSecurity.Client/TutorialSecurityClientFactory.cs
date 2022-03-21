using JetBrains.Annotations;
using Microsoft.Extensions.Logging;
using Service.Grpc;
using Service.TutorialSecurity.Grpc;

namespace Service.TutorialSecurity.Client
{
	[UsedImplicitly]
	public class TutorialSecurityClientFactory : GrpcClientFactory
	{
		public TutorialSecurityClientFactory(string grpcServiceUrl, ILogger logger) : base(grpcServiceUrl, logger)
		{
		}

		public IGrpcServiceProxy<ITutorialSecurityService> GetTutorialSecurityService() => CreateGrpcService<ITutorialSecurityService>();
	}
}