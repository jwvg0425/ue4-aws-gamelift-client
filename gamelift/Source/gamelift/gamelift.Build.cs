using UnrealBuildTool;
using System.IO;

public class Gamelift : ModuleRules
{
	public Gamelift(TargetInfo Target)
	{
		PrivateIncludePaths.AddRange(new string[] { "gamelift/Private" });
		PublicIncludePaths.AddRange(new string[] { "gamelift/Public" });

		PublicDependencyModuleNames.AddRange(new string[] { "Engine", "Core", "CoreUObject", "Engine", "InputCore" });
	}
}