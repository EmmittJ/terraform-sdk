// Licensed under the MIT License.

using Aspire.Hosting.ApplicationModel;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// An annotation that stores Terraform outputs for a resource.
/// </summary>
/// <remarks>
/// <para>
/// This annotation is added to resources that have Terraform outputs defined via
/// <see cref="TerraformExtensions.PublishAsTerraform"/>. The outputs dictionary is
/// populated after Terraform apply completes with the actual output values.
/// </para>
/// <para>
/// This pattern mirrors how <c>AzureBicepResource</c> stores outputs directly on the
/// resource, enabling <see cref="TerraformOutputReference"/> to access outputs without
/// searching through deployment annotations.
/// </para>
/// </remarks>
public sealed class TerraformOutputsAnnotation : IResourceAnnotation
{
    /// <summary>
    /// Gets the dictionary of Terraform outputs for this resource.
    /// Keys are output names (case-insensitive), values are the output values.
    /// </summary>
    public Dictionary<string, object?> Outputs { get; } = new(StringComparer.OrdinalIgnoreCase);

    /// <summary>
    /// Gets or sets the task completion source for the provisioning operation.
    /// </summary>
    /// <remarks>
    /// This allows async waiting for outputs to be available via
    /// <see cref="TerraformOutputReference.GetValueAsync"/>.
    /// </remarks>
    public TaskCompletionSource? ProvisioningTaskCompletionSource { get; set; }
}
