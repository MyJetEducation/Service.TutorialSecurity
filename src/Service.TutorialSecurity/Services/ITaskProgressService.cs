using System;
using System.Threading.Tasks;
using Service.Education.Structure;
using Service.TutorialSecurity.Grpc.Models.State;
using Service.TutorialSecurity.Grpc.Models.Task;
using Service.TutorialSecurity.Models;

namespace Service.TutorialSecurity.Services
{
	public interface ITaskProgressService
	{
		ValueTask<TestScoreGrpcResponse> SetTaskProgressAsync(string userId, EducationStructureUnit unit, EducationStructureTask task, bool isRetry, TimeSpan duration, int? progress = null);

		ValueTask<StateGrpcModel> GetUnitProgressAsync(string userId, int unit);

		ValueTask<TaskTypeProgressInfo> GetTotalProgressAsync(string userId, int? unit = null);
	}
}
