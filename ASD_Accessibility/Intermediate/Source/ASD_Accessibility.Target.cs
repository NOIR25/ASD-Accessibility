using UnrealBuildTool;

public class ASD_AccessibilityTarget : TargetRules
{
	public ASD_AccessibilityTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("ASD_Accessibility");
	}
}
