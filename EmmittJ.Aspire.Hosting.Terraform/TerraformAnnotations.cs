// Licensed under the MIT License.

using Aspire.Hosting.ApplicationModel;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Annotation that stores Terraform configuration for a resource.
/// Applied to the parent resource to specify working directory.
/// Does not store stack definitions - use <see cref="TerraformStackResource"/> for stack resources.
/// </summary>
public sealed class TerraformConfigurationAnnotation : IResourceAnnotation
{
    /// <summary>
    /// Gets or sets the working directory where Terraform files will be generated.
    /// If not specified, a default location will be used.
    /// </summary>
    public string? WorkingDirectory { get; set; }
}

