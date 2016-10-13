using UnrealBuildTool;
using System.IO;

public class gamelift : ModuleRules
{
	public gamelift(TargetInfo Target)
	{
		PrivateIncludePaths.AddRange(new string[] { "gamelift/Private" });
		PublicIncludePaths.AddRange(new string[] { "gamelift/Public" });

		PublicDependencyModuleNames.AddRange(new string[] { "Engine", "Core", "CoreUObject", "Engine", "InputCore" });
		PrivateDependencyModuleNames.AddRange(new string[] { "awsCore" });

		string platformName = Target.Platform.ToString();

		string BasePath = System.IO.Path.Combine(ModuleDirectory, "../../Binaries", platformName);

		PublicLibraryPaths.Add(BasePath);
		
		PublicAdditionalLibraries.Add("aws-cpp-sdk-gamelift.lib");
		
		RuntimeDependencies.Add(new RuntimeDependency(System.IO.Path.Combine(BasePath, "aws-cpp-sdk-gamelift.dll")));
	}
}