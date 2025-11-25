// Licensed under the MIT License.

using Aspire.Hosting.ApplicationModel;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Represents a reference to a Terraform module output value.
/// This type is used to create strongly-typed references to outputs from Terraform modules,
/// enabling cross-module dependencies and parameter passing.
/// </summary>
/// <param name="Name">The name of the output in the Terraform module.</param>
/// <param name="Resource">The Aspire resource that produces this output.</param>
/// <remarks>
/// When used in module configurations, TerraformOutputReference instances are automatically
/// converted to module input variables by the publishing context, similar to how Aspire's
/// BicepOutputReference works for Bicep publishing.
/// <example>
/// <code>
/// // In a resource that produces outputs:
/// public TerraformOutputReference ConnectionStringOutput => new("connection_string", this);
///
/// // In a consuming resource:
/// var redisConnStr = redisResource.ConnectionStringOutput.AsVariable(infra);
/// containerApp.EnvironmentVariables["REDIS_CONNECTION"] = redisConnStr;
/// </code>
/// </example>
/// </remarks>
public sealed record TerraformOutputReference(string Name, IResource Resource) : IManifestExpressionProvider
{
    /// <summary>
    /// Gets the manifest expression for this output reference.
    /// This expression can be used in Aspire manifests to reference the output value.
    /// </summary>
    public string ValueExpression => $"{{{Resource.Name}.outputs.{Name}}}";

    /// <summary>
    /// Returns a string representation of this output reference suitable for debugging.
    /// </summary>
    public override string ToString() => $"TerraformOutputReference({Resource.Name}.{Name})";
}
