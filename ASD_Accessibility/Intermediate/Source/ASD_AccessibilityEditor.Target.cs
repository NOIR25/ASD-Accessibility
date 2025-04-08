using UnrealBuildTool;

public class ASD_AccessibilityEditorTarget : TargetRules
{
	public ASD_AccessibilityEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("ASD_Accessibility");
	}
}
