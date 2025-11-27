// Licensed under the MIT License.

using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Provides extension methods for converting Aspire resource references to Terraform variables.
/// These methods enable cross-module dependencies by converting output references and parameters
/// into Terraform module input variables.
/// </summary>
public static class TerraformProvisioningExtensions
{
    /// <summary>
    /// Converts an Aspire parameter resource to a Terraform variable in the current module.
    /// This enables using Aspire parameters (like secrets, configuration values) as Terraform variables.
    /// </summary>
    /// <param name="parameterResource">The parameter resource to convert.</param>
    /// <param name="infrastructure">The infrastructure context for the current resource.</param>
    /// <param name="variableName">Optional custom name for the variable. If not provided, uses the parameter's name.</param>
    /// <returns>A TerraformVariable that can be used in resource configurations.</returns>
    /// <remarks>
    /// This method creates a Terraform variable for an Aspire parameter, maintaining the secret
    /// flag and other metadata. The parameter value will be provided at deployment time through
    /// Terraform's standard variable mechanisms (tfvars, environment variables, etc.).
    /// <example>
    /// <code>
    /// var password = postgresPassword.AsVariable(infra);
    /// var server = new AzurermPostgresqlFlexibleServer("postgres")
    /// {
    ///     AdministratorPassword = password
    /// };
    /// </code>
    /// </example>
    /// </remarks>
    public static TerraformVariable AsVariable(
        this ParameterResource parameterResource,
        TerraformResourceInfrastructure infrastructure,
        string? variableName = null)
    {
        ArgumentNullException.ThrowIfNull(parameterResource);
        ArgumentNullException.ThrowIfNull(infrastructure);

        // Use parameter name as variable name if not provided
        variableName ??= parameterResource.Name.Replace("-", "_");

        // Register this parameter as an input dependency
        infrastructure.Inputs[variableName] = parameterResource;

        // Get or create the variable in the stack
        if (!infrastructure.Parameters.TryGetValue(variableName, out var variable))
        {
            variable = new TerraformVariable(variableName)
            {
                Type = "string",
                Description = parameterResource.Description ?? $"Parameter '{parameterResource.Name}'",
                Sensitive = parameterResource.Secret
            };
            infrastructure.Parameters[variableName] = variable;
            infrastructure.Stack.Add(variable);
        }

        // Register on the environment for runtime resolution during plan/apply
        var environment = infrastructure.TerraformResource?.Environment
            ?? (infrastructure.Resource as TerraformEnvironmentResource);

        if (environment is not null)
        {
            environment.ParameterVariables[parameterResource] = variable;
        }

        return variable;
    }

    /// <summary>
    /// Converts an Aspire parameter resource builder to a Terraform variable.
    /// This is a convenience overload for use with parameter builders.
    /// </summary>
    /// <param name="parameterBuilder">The parameter resource builder.</param>
    /// <param name="infrastructure">The infrastructure context for the current resource.</param>
    /// <param name="variableName">Optional custom name for the variable.</param>
    /// <returns>A TerraformVariable that can be used in resource configurations.</returns>
    public static TerraformVariable AsVariable(
        this IResourceBuilder<ParameterResource> parameterBuilder,
        TerraformResourceInfrastructure infrastructure,
        string? variableName = null)
    {
        ArgumentNullException.ThrowIfNull(parameterBuilder);
        return parameterBuilder.Resource.AsVariable(infrastructure, variableName);
    }
}
