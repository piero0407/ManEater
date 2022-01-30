using UnrealBuildTool;

public class ManEaterTarget : TargetRules
{
	public ManEaterTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("ManEater");
	}
}
