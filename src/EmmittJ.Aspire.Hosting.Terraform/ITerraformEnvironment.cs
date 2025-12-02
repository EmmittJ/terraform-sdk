// Licensed under the MIT License.

using Aspire.Hosting.ApplicationModel;
using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Represents a Terraform environment that can provision infrastructure.
/// </summary>
/// <remarks>
/// <para>
/// This interface defines the common contract for resources that manage Terraform infrastructure,
/// including settings for version, output path, and automatic operations (init, plan, apply).
/// </para>
/// <para>
/// Both <see cref="TerraformEnvironmentResource"/> (for general infrastructure) and
/// <see cref="TerraformContainerRegistryResource"/> (for container registries) implement this interface,
/// allowing them to be configured consistently using extension methods like <c>WithVersion()</c>,
/// <c>WithBackend()</c>, and <c>WithSettings()</c>.
/// </para>
/// </remarks>
public interface ITerraformEnvironment : IResource
{
    /// <summary>
    /// Gets the container registry associated with this environment, if any.
    /// </summary>
    /// <remarks>
    /// When set, the environment's plan step will depend on the registry's login step,
    /// ensuring the registry is provisioned and authenticated before deployment.
    /// </remarks>
    IContainerRegistry? ContainerRegistry { get; }

    /// <summary>
    /// Gets the <see cref="TerraformProvisioningResource"/> for this environment, which provides the stack
    /// and helper methods for configuring the Terraform infrastructure.
    /// </summary>
    TerraformProvisioningResource TerraformResource { get; }

    /// <summary>
    /// Gets or sets the Terraform version to use.
    /// </summary>
    /// <remarks>
    /// When set, a <c>.terraform-version</c> file is generated during publishing.
    /// This is used by tools like <c>tfenv</c> to automatically select the correct Terraform version.
    /// </remarks>
    string? TerraformVersion { get; set; }

    /// <summary>
    /// Gets or sets the output path for generated Terraform files relative to the publish output directory.
    /// </summary>
    string? OutputPath { get; set; }

    /// <summary>
    /// Gets or sets whether to automatically run <c>terraform init</c> during publishing.
    /// </summary>
    bool AutoInit { get; set; }

    /// <summary>
    /// Gets or sets whether to automatically run <c>terraform plan</c> during publishing.
    /// </summary>
    bool AutoPlan { get; set; }

    /// <summary>
    /// Gets or sets whether to automatically run <c>terraform apply</c> during publishing.
    /// </summary>
    bool AutoApply { get; set; }

    /// <summary>
    /// Gets the collection of parameter resources that have been registered as Terraform variables.
    /// </summary>
    /// <remarks>
    /// Parameters are registered when <see cref="TerraformProvisioningResource.AddVariable(ParameterResource, string?)"/> is called.
    /// During plan/apply, these parameters are resolved and passed to Terraform via tfvars (non-sensitive)
    /// or TF_VAR_* environment variables (sensitive).
    /// </remarks>
    Dictionary<ParameterResource, TerraformVariable> ParameterVariables { get; }
}
