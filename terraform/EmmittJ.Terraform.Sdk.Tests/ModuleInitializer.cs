using System.Runtime.CompilerServices;

namespace EmmittJ.Terraform.Sdk.Tests;

internal static class ModuleInitializer
{
    [ModuleInitializer]
    public static void Init()
    {
        DerivePathInfo((sourceFile, projectDirectory, type, method) =>
        {
            return new PathInfo(
                directory: Path.Combine(projectDirectory, "Snapshots", type.Name),
                typeName: type.Name,
                methodName: method.Name);
        });
    }
}
