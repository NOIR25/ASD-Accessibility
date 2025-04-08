using UnrealBuildTool;

public class ASD_AccessibilityClientTarget : TargetRules
{
	public ASD_AccessibilityClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("ASD_Accessibility");
	}
}
