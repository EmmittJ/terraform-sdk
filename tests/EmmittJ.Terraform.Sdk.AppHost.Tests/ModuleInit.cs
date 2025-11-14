using System.Runtime.CompilerServices;

namespace EmmittJ.Terraform.Sdk.AppHost.Tests;

public static class ModuleInit
{
    [ModuleInitializer]
    public static void Init()
    {
        // Initialize Verify settings
        VerifierSettings.DontScrubGuids();

        DerivePathInfo((sourceFile, projectDirectory, type, method) =>
        {
            return new PathInfo(
                directory: Path.Combine(projectDirectory, "Snapshots", type.Name),
                typeName: type.Name,
                methodName: method.Name);
        });
    }
}
