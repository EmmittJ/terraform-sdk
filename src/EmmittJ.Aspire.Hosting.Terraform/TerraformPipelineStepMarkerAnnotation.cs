// Licensed under the MIT License.

using Aspire.Hosting.ApplicationModel;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Internal marker annotation to indicate that a resource has already had its Terraform pipeline step annotation added.
/// This prevents duplicate pipeline step registrations when PublishAsTerraform is called multiple times.
/// </summary>
internal sealed class TerraformPipelineStepMarkerAnnotation : IResourceAnnotation
{
}
