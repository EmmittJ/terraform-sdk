// Licensed under the MIT License.

using Aspire.Hosting.ApplicationModel;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Annotation for configuring Terraform generation settings.
/// </summary>
public sealed class TerraformConfigurationAnnotation : IResourceAnnotation
{
    /// <summary>
    /// Gets or sets the output path for generated Terraform files.
    /// If null, defaults to {output-path}/{resource-name}/
    /// </summary>
    public string? OutputPath { get; set; }
}

