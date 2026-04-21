using UnrealBuildTool;

public class NemesisEditorTarget : TargetRules
{
	public NemesisEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Nemesis");
	}
}
