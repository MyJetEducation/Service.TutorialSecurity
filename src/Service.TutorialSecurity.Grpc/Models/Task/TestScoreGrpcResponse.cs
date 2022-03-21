using System.Runtime.Serialization;
using Service.TutorialSecurity.Grpc.Models.State;

namespace Service.TutorialSecurity.Grpc.Models.Task
{
	[DataContract]
	public class TestScoreGrpcResponse
	{
		[DataMember(Order = 1)]
		public bool IsSuccess { get; set; }

		[DataMember(Order = 2)]
		public StateGrpcModel Unit { get; set; }
	}
}
