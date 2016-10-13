using UnrealBuildTool;
using System.IO;

public class gamelift : ModuleRules
{
	public gamelift(TargetInfo Target)
	{
		PrivateIncludePaths.AddRange(new string[] { "gamelift/Private" });
		PublicIncludePaths.AddRange(new string[] { "gamelift/Public" });

		PublicDependencyModuleNames.AddRange(new string[] { "Engine", "Core", "CoreUObject", "Engine", "InputCore" });
	}
}