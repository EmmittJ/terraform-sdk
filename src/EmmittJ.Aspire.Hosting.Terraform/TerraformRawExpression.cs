// Licensed under the MIT License.

using Aspire.Hosting.ApplicationModel;
using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// An Aspire value provider that carries a raw, verbatim HCL expression fragment.
/// </summary>
/// <remarks>
/// <para>
/// This type is the cross-language "escape-hatch" for Terraform's structured expression operators
/// (conditionals, <c>for</c> expressions, function calls, index/key access, references such as
/// <c>module.x.output</c>) that have no direct counterpart in Aspire's interpolation/concatenation-based
/// <see cref="ReferenceExpression"/> algebra.
/// </para>
/// <para>
/// Because it implements <see cref="IValueProvider"/> and <see cref="IManifestExpressionProvider"/>,
/// it can be embedded directly inside a <see cref="ReferenceExpression"/> hole and flows through the
/// existing host-side lowering (<see cref="TerraformProvisioningResource.ResolveValueProvider"/> and
/// <c>TerraformPublishingContext.ResolveInputValue</c>). When lowered, the fragment is rendered
/// <b>verbatim and unquoted</b> via <see cref="TerraformExpression.Raw"/>, so a reference like
/// <c>module.network.vnet_id</c> stays symbolic in the generated HCL instead of being emitted as a
/// quoted string literal.
/// </para>
/// <para>
/// The contained HCL is rendered as-is and is not validated or escaped. Prefer the typed value
/// providers (<see cref="TerraformOutputReference"/>, <see cref="ParameterResource"/>) where possible;
/// use this type only when an expression cannot otherwise be represented.
/// </para>
/// </remarks>
/// <example>
/// <code>
/// // Inject a symbolic Terraform reference through the Aspire expression system.
/// var moduleId = TerraformRawExpression.Create("module.network.vnet_id");
///
/// app.PublishAsTerraform(infra =>
/// {
///     var value = infra.ResolveValueProvider(moduleId); // renders: module.network.vnet_id (unquoted)
/// });
/// </code>
/// </example>
public sealed class TerraformRawExpression
    : IManifestExpressionProvider, IValueProvider, IEquatable<TerraformRawExpression>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformRawExpression"/> class.
    /// </summary>
    /// <param name="hcl">The raw HCL expression fragment to render verbatim.</param>
    /// <exception cref="ArgumentException">Thrown when <paramref name="hcl"/> is <c>null</c> or empty.</exception>
    public TerraformRawExpression(string hcl)
    {
        ArgumentException.ThrowIfNullOrEmpty(hcl);
        Hcl = hcl;
    }

    /// <summary>
    /// Gets the raw HCL expression fragment.
    /// </summary>
    public string Hcl { get; }

    /// <summary>
    /// Creates a new <see cref="TerraformRawExpression"/> from the specified HCL fragment.
    /// </summary>
    /// <param name="hcl">The raw HCL expression fragment to render verbatim.</param>
    /// <returns>A <see cref="TerraformRawExpression"/> wrapping <paramref name="hcl"/>.</returns>
    public static TerraformRawExpression Create(string hcl) => new(hcl);

    /// <summary>
    /// Lowers this raw expression into the Terraform AST as a verbatim (unquoted) value.
    /// </summary>
    /// <returns>A <see cref="TerraformValue{T}"/> that renders as the raw HCL fragment.</returns>
    public TerraformValue<string> ToTerraformValue() => TerraformExpression.Raw(Hcl);

    /// <summary>
    /// Gets the manifest expression for this raw fragment, which is the verbatim HCL.
    /// </summary>
    public string ValueExpression => Hcl;

    /// <summary>
    /// Gets the value of this raw expression. Returns the verbatim HCL fragment.
    /// </summary>
    /// <param name="cancellationToken">A token to observe while waiting for the task to complete.</param>
    /// <returns>The raw HCL fragment.</returns>
    public ValueTask<string?> GetValueAsync(CancellationToken cancellationToken = default)
        => new(Hcl);

    /// <inheritdoc/>
    public bool Equals(TerraformRawExpression? other)
        => other is not null && string.Equals(Hcl, other.Hcl, StringComparison.Ordinal);

    /// <inheritdoc/>
    public override bool Equals(object? obj) => Equals(obj as TerraformRawExpression);

    /// <inheritdoc/>
    public override int GetHashCode() => StringComparer.Ordinal.GetHashCode(Hcl);

    /// <inheritdoc/>
    public override string ToString() => Hcl;
}
