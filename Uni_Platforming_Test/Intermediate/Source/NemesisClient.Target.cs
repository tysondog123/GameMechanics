using UnrealBuildTool;

public class NemesisClientTarget : TargetRules
{
	public NemesisClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Nemesis");
	}
}
