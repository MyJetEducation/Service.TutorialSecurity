﻿using System.Threading.Tasks;
using Service.Education.Contracts;
using Service.Education.Contracts.Task;
using Service.Education.Structure;
using Service.TutorialSecurity.Helper;
using static Service.Education.Helpers.AnswerHelper;

namespace Service.TutorialSecurity.Services
{
	public partial class TutorialSecurityService
	{
		private static readonly EducationStructureUnit Unit2 = TutorialHelper.StructureTutorial.Units[2];

		public async ValueTask<TestScoreGrpcResponse> Unit2TextAsync(TaskTextGrpcRequest request) =>
			await _taskProgressService.SetTaskProgressAsync(request.UserId, Unit2, Unit2.Tasks[1], request.IsRetry, request.Duration);

		public async ValueTask<TestScoreGrpcResponse> Unit2TestAsync(TaskTestGrpcRequest request)
		{
			ITaskTestAnswer[] answers = request.Answers;

			int progress = CheckAnswer(20, answers, 1, 1)
				+ CheckAnswer(20, answers, 2, 2)
				+ CheckAnswer(20, answers, 3, 2, 3)
				+ CheckAnswer(20, answers, 4, 1)
				+ CheckAnswer(20, answers, 5, 2);

			return await _taskProgressService.SetTaskProgressAsync(request.UserId, Unit2, Unit2.Tasks[2], request.IsRetry, request.Duration, progress);
		}

		public async ValueTask<TestScoreGrpcResponse> Unit2VideoAsync(TaskVideoGrpcRequest request) =>
			await _taskProgressService.SetTaskProgressAsync(request.UserId, Unit2, Unit2.Tasks[3], request.IsRetry, request.Duration);

		public async ValueTask<TestScoreGrpcResponse> Unit2CaseAsync(TaskCaseGrpcRequest request) =>
			await _taskProgressService.SetTaskProgressAsync(request.UserId, Unit2, Unit2.Tasks[4], request.IsRetry, request.Duration, CountProgress(request.Value == 2));

		public async ValueTask<TestScoreGrpcResponse> Unit2TrueFalseAsync(TaskTrueFalseGrpcRequest request)
		{
			ITaskTrueFalseAnswer[] answers = request.Answers;

			int progress = CheckAnswer(20, answers, 1, true)
				+ CheckAnswer(20, answers, 2, true)
				+ CheckAnswer(20, answers, 3, false)
				+ CheckAnswer(20, answers, 4, true)
				+ CheckAnswer(20, answers, 5, true);

			return await _taskProgressService.SetTaskProgressAsync(request.UserId, Unit2, Unit2.Tasks[5], request.IsRetry, request.Duration, progress);
		}

		public async ValueTask<TestScoreGrpcResponse> Unit2GameAsync(TaskGameGrpcRequest request) =>
			await _taskProgressService.SetTaskProgressAsync(request.UserId, Unit2, Unit2.Tasks[6], request.IsRetry, request.Duration);
	}
}
