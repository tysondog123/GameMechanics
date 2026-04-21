using UnrealBuildTool;

public class NemesisTarget : TargetRules
{
	public NemesisTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Nemesis");
	}
}
