using UnrealBuildTool;
using System.IO;

public class awsCore : ModuleRules
{
	public awsCore(TargetInfo Target)
	{
		PrivateIncludePaths.AddRange(new string[] { "core/Private" });
		PublicIncludePaths.AddRange(new string[] { "core/Public" });

		PublicDependencyModuleNames.AddRange(new string[] { "Engine", "Core", "CoreUObject", "Engine", "InputCore" });
		PrivateDependencyModuleNames.AddRange(new string[] { });

		string platformName = Target.Platform.ToString();

		string BasePath = System.IO.Path.Combine(ModuleDirectory, "../../Binaries", platformName);

		PublicLibraryPaths.Add(BasePath);

		PublicAdditionalLibraries.Add("aws-cpp-sdk-core.lib");

		RuntimeDependencies.Add(new RuntimeDependency(System.IO.Path.Combine(BasePath, "aws-cpp-sdk-core.dll")));
	}
}