#pragma warning disable ASPIREPIPELINES001

using Aspire.Hosting.ApplicationModel;

namespace EmmittJ.Terraform.Sdk.AppHost;

/// <summary>
/// Represents a Terraform code generation environment resource.
/// </summary>
/// <remarks>
/// Initializes a new instance of the <see cref="TerraformCodeGenEnvironmentResource"/> class.
/// </remarks>
public class TerraformCodeGenEnvironmentResource(string name) : Resource(name)
{
    /// <summary>
    /// Gets or sets the output directory for generated provider code.
    /// </summary>
    public string OutputDirectory { get; set; } = "providers";

    /// <summary>
    /// Gets or sets the working directory for Terraform operations.
    /// </summary>
    public string WorkingDirectory { get; set; } = ".terraform-codegen";

    /// <summary>
    /// Gets or sets the base namespace for generated provider code.
    /// </summary>
    public string Namespace { get; set; } = "EmmittJ.Terraform.Sdk.Providers";
}
