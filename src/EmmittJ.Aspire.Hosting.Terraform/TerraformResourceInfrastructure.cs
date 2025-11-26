// Licensed under the MIT License.

using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Provides context for configuring Terraform infrastructure for a specific resource.
/// This context is passed to resource configuration callbacks and provides access to the
/// Terraform stack, the Aspire resource being configured, and infrastructure helpers.
/// </summary>
/// <remarks>
/// Similar to Aspire's AzureResourceInfrastructure for Bicep publishing, this context
/// enables resources to declare dependencies on other resources' outputs and automatically
/// handles the conversion to Terraform module variables.
/// <example>
/// <code>
/// resource.PublishAsTerraform(infra =>
/// {
///     // Reference another resource's output
///     var redisHost = redisResource.HostnameOutput.AsVariable(infra);
///
///     // Create Terraform resources using the SDK
///     var container = new AzurermContainerApp("api")
///     {
///         EnvironmentVariables = new()
///         {
///             ["REDIS_HOST"] = redisHost
///         }
///     };
///
///     infra.Add(container);
/// });
/// </code>
/// </example>
/// </remarks>
public sealed class TerraformResourceInfrastructure
{
    /// <summary>
    /// Gets the Aspire resource that this infrastructure configuration represents.
    /// </summary>
    public IResource Resource { get; }

    /// <summary>
    /// Gets the Terraform stack where resources should be added.
    /// </summary>
    public TerraformStack Stack { get; }

    /// <summary>
    /// Gets the dictionary of input parameters for this module.
    /// Keys are parameter names, values are the source objects (TerraformOutputResource, ParameterResource, etc.)
    /// </summary>
    internal Dictionary<string, object> Inputs { get; } = new();

    /// <summary>
    /// Gets the dictionary of variables created for this module's inputs.
    /// </summary>
    internal Dictionary<string, TerraformVariable> Parameters { get; } = new();

    /// <summary>
    /// Gets the Terraform resource wrapper if this is a compute resource.
    /// </summary>
    internal TerraformResource? TerraformResource { get; }

    /// <summary>
    /// Initializes a new instance of TerraformResourceInfrastructure.
    /// </summary>
    /// <param name="resource">The Aspire resource being configured.</param>
    /// <param name="stack">The Terraform stack for this resource.</param>
    /// <param name="terraformResource">Optional Terraform resource wrapper.</param>
    internal TerraformResourceInfrastructure(
        IResource resource,
        TerraformStack stack,
        TerraformResource? terraformResource = null)
    {
        Resource = resource ?? throw new ArgumentNullException(nameof(resource));
        Stack = stack ?? throw new ArgumentNullException(nameof(stack));
        TerraformResource = terraformResource;
    }

    /// <summary>
    /// Adds a Terraform block to the stack.
    /// </summary>
    /// <param name="block">The Terraform block to add.</param>
    public void Add(TerraformBlock block)
    {
        ArgumentNullException.ThrowIfNull(block);
        Stack.Add(block);
    }
}
