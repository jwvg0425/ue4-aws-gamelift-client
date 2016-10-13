using UnrealBuildTool;
using System.IO;

public class gamelift : ModuleRules
{
	public gamelift(TargetInfo Target)
	{
		PrivateIncludePaths.AddRange(new string[] { "gamelift/Private", "gamelift/Public/aws/core", "gamelift/Public/aws/Client", "gamelift/Public/aws/gamelift" });
		PublicIncludePaths.AddRange(new string[] { "gamelift/Public" });

		PublicDependencyModuleNames.AddRange(new string[] { "Engine", "Core", "CoreUObject", "Engine", "InputCore" });

		string platformName = Target.Platform.ToString();

		string BasePath = System.IO.Path.Combine(ModuleDirectory, "../../Binaries", platformName);

		PublicLibraryPaths.Add(BasePath);

		PublicAdditionalLibraries.Add("aws-cpp-sdk-core.lib");
		PublicAdditionalLibraries.Add("aws-cpp-sdk-gamelift.lib");

		RuntimeDependencies.Add(new RuntimeDependency(System.IO.Path.Combine(BasePath, "aws-cpp-sdk-core.dll")));
		RuntimeDependencies.Add(new RuntimeDependency(System.IO.Path.Combine(BasePath, "aws-cpp-sdk-gamelift.dll")));
	}
}