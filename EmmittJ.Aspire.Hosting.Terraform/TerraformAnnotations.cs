// Licensed under the MIT License.

using Aspire.Hosting.ApplicationModel;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Annotation that stores Terraform configuration for a resource.
/// Applied to the parent resource to specify the output path for Terraform files.
/// Does not store stack definitions - use <see cref="TerraformStackResource"/> for stack resources.
/// </summary>
public sealed class TerraformConfigurationAnnotation : IResourceAnnotation
{
    /// <summary>
    /// Gets or sets the output path where Terraform files will be generated.
    /// This path is relative to the pipeline output path.
    /// If not specified, defaults to the resource name.
    /// </summary>
    public string? OutputPath { get; set; }
}

