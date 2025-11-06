// Licensed under the MIT License.

using Aspire.Hosting.ApplicationModel;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Annotation that stores Terraform configuration for a resource.
/// Applied to the parent resource or stack resource to specify output directory.
/// Does not store stack definitions - use <see cref="TerraformStackResource"/> for stack resources.
/// </summary>
public sealed class TerraformConfigurationAnnotation : IResourceAnnotation
{
    /// <summary>
    /// Gets or sets the output directory where Terraform files will be generated.
    /// If not specified, the pipeline output path or a default location will be used.
    /// </summary>
    public string? OutputDirectory { get; set; }
}

