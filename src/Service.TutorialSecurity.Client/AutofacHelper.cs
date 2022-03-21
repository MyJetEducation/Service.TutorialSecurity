using Autofac;
using Microsoft.Extensions.Logging;
using Service.Grpc;
using Service.TutorialSecurity.Grpc;

// ReSharper disable UnusedMember.Global

namespace Service.TutorialSecurity.Client
{
	public static class AutofacHelper
	{
		public static void RegisterTutorialSecurityClient(this ContainerBuilder builder, string grpcServiceUrl, ILogger logger)
		{
			var factory = new TutorialSecurityClientFactory(grpcServiceUrl, logger);

			builder.RegisterInstance(factory.GetTutorialSecurityService()).As<IGrpcServiceProxy<ITutorialSecurityService>>().SingleInstance();
		}
	}
}
