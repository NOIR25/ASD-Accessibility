using UnrealBuildTool;

public class ASD_AccessibilityServerTarget : TargetRules
{
	public ASD_AccessibilityServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("ASD_Accessibility");
	}
}
