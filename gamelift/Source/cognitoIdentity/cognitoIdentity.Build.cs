using UnrealBuildTool;
using System.IO;

public class cognitoIdentity : ModuleRules
{
	public cognitoIdentity(TargetInfo Target)
	{
		PrivateIncludePaths.AddRange(new string[] { "cognitoIdentity/Private" });
		PublicIncludePaths.AddRange(new string[] { "cognitoIdentity/Public" });

		PublicDependencyModuleNames.AddRange(new string[] { "Engine", "Core", "CoreUObject", "Engine", "InputCore" });
		PrivateDependencyModuleNames.AddRange(new string[] { "awsCore" });

		string platformName = Target.Platform.ToString();

		string BasePath = System.IO.Path.Combine(ModuleDirectory, "../../Binaries", platformName);

		PublicLibraryPaths.Add(BasePath);

		PublicAdditionalLibraries.Add("aws-cpp-sdk-cognito-identity.lib");

		RuntimeDependencies.Add(new RuntimeDependency(System.IO.Path.Combine(BasePath, "aws-cpp-sdk-cognito-identity.dll")));
	}
}