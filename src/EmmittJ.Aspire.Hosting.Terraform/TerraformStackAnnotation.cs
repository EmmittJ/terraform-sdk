// Licensed under the MIT License.

using Aspire.Hosting.ApplicationModel;
using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Represents an annotation for customizing Terraform infrastructure generation.
/// </summary>
/// <remarks>
/// Initializes a new instance of the <see cref="TerraformStackAnnotation"/> class.
/// </remarks>
/// <param name="configure">The configuration action for customizing the Terraform stack.</param>
/// <param name="name">Optional name for the stack. If not provided, the resource name will be used.</param>
public sealed class TerraformStackAnnotation(Action<TerraformStack> configure, string? name = null) : IResourceAnnotation
{
    /// <summary>
    /// Gets the configuration action for customizing the Terraform stack.
    /// </summary>
    public Action<TerraformStack> Configure { get; } = configure ?? throw new ArgumentNullException(nameof(configure));

    /// <summary>
    /// Gets the optional name for the stack. If null, the resource name will be used.
    /// </summary>
    public string? Name { get; } = name;
}
