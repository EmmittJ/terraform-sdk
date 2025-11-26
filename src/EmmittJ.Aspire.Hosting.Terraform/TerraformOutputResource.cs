// Licensed under the MIT License.

using Aspire.Hosting.ApplicationModel;
using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Represents a Terraform output resource that can be produced by one resource and consumed by others.
/// This resource follows the same pattern as <see cref="ParameterResource"/> but for outputs.
/// </summary>
/// <remarks>
/// <para>
/// A TerraformOutputResource represents a value that will be output from a Terraform module.
/// Unlike parameters which flow into modules, outputs flow out of modules and can be consumed
/// by other resources.
/// </para>
/// <para>
/// The output resource is created separately from the resource that produces it, allowing
/// for a clean separation between output definition and output value assignment.
/// </para>
/// <example>
/// <code>
/// // Define the output at the builder level
/// var redisConnectionString = builder.AddTerraformOutput("redis-connection-string", sensitive: true);
///
/// // Associate the output with the resource that produces it
/// cache.PublishAsTerraform(infra =>
/// {
///     var redisCache = new AzurermRedisCache(...);
///     infra.Add(redisCache);
///     infra.Add(redisConnectionString.AsOutput(redisCache.PrimaryConnectionString));
/// });
///
/// // Consume the output in another resource
/// api.PublishAsTerraform(infra =>
/// {
///     var connStr = redisConnectionString.AsVariable(infra);
///     // Use connStr in resource configuration
/// });
/// </code>
/// </example>
/// </remarks>
public sealed class TerraformOutputResource : Resource, IManifestExpressionProvider
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformOutputResource"/> class.
    /// </summary>
    /// <param name="name">The name of the output resource.</param>
    /// <param name="sensitive">Whether this output contains sensitive data.</param>
    public TerraformOutputResource(string name, bool sensitive = false) : base(name)
    {
        Sensitive = sensitive;
    }

    /// <summary>
    /// Gets a value indicating whether this output contains sensitive data.
    /// When true, the corresponding <see cref="TerraformOutput"/> and <see cref="TerraformVariable"/>
    /// will be marked as sensitive.
    /// </summary>
    public bool Sensitive { get; }

    /// <summary>
    /// Gets or sets the resource that produces this output value.
    /// This is set when calling <see cref="TerraformOutputResourceExtensions.ProducedBy{T}"/>.
    /// </summary>
    public IResource? Producer { get; internal set; }

    /// <summary>
    /// Gets a value indicating whether this output has been associated with a producer resource.
    /// </summary>
    public bool HasProducer => Producer is not null;

    /// <summary>
    /// Gets the manifest expression for this output reference.
    /// This expression can be used in Aspire manifests to reference the output value.
    /// </summary>
    /// <remarks>
    /// If a producer is set, the expression references the producer's output.
    /// Otherwise, it references the output resource directly.
    /// </remarks>
    public string ValueExpression => Producer is not null
        ? $"{{{Producer.Name}.outputs.{Name}}}"
        : $"{{{Name}.value}}";
}
