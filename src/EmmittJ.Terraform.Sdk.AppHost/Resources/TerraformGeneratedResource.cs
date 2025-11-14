using Aspire.Hosting.ApplicationModel;

namespace EmmittJ.Terraform.Sdk.AppHost;

/// <summary>
/// Represents generated code artifacts from a Terraform provider.
/// </summary>
public class TerraformGeneratedResource : Resource
{
    /// <summary>
    /// Gets the list of generated file paths.
    /// </summary>
    public IReadOnlyList<string> GeneratedFiles { get; }

    /// <summary>
    /// Gets the provider resource that this was generated from.
    /// </summary>
    public Resource SourceProvider { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformGeneratedResource"/> class.
    /// </summary>
    public TerraformGeneratedResource(string name, IReadOnlyList<string> generatedFiles, Resource sourceProvider)
        : base(name)
    {
        GeneratedFiles = generatedFiles;
        SourceProvider = sourceProvider;
    }
}
