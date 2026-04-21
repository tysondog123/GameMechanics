using UnrealBuildTool;

public class NemesisServerTarget : TargetRules
{
	public NemesisServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Nemesis");
	}
}
