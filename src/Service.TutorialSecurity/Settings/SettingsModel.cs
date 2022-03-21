using MyJetWallet.Sdk.Service;
using MyYamlParser;

namespace Service.TutorialSecurity.Settings
{
	public class SettingsModel
	{
		[YamlProperty("TutorialSecurity.SeqServiceUrl")]
		public string SeqServiceUrl { get; set; }

		[YamlProperty("TutorialSecurity.ZipkinUrl")]
		public string ZipkinUrl { get; set; }

		[YamlProperty("TutorialSecurity.ElkLogs")]
		public LogElkSettings ElkLogs { get; set; }

		[YamlProperty("TutorialSecurity.EducationProgressServiceUrl")]
		public string EducationProgressServiceUrl { get; set; }

		[YamlProperty("TutorialSecurity.EducationRetryServiceUrl")]
		public string EducationRetryServiceUrl { get; set; }

		[YamlProperty("TutorialSecurity.UserRewardServiceUrl")]
		public string UserRewardServiceUrl { get; set; }

		[YamlProperty("TutorialSecurity.UserProgressServiceUrl")]
		public string UserProgressServiceUrl { get; set; }
	}
}