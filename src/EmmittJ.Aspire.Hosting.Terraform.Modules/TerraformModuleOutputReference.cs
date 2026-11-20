// Licensed under the MIT License.

using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;

namespace EmmittJ.Aspire.Hosting.Terraform.Modules;

/// <summary>
/// An Aspire value backed by a Terraform output of a <see cref="TerraformModuleResource"/>.
/// When deploying it resolves after the module has been applied; in run mode it resolves from
/// state read by <c>RunAsExisting</c>.
/// </summary>
/// <param name="name">The Terraform output name.</param>
/// <param name="module">The module that produces the output.</param>
[AspireExport]
public sealed class TerraformModuleOutputReference(string name, TerraformModuleResource module)
    : IExpressionValue, IValueWithReferences, IEquatable<TerraformModuleOutputReference>
{
    /// <summary>Gets the Terraform output name.</summary>
    public string Name { get; } = name ?? throw new ArgumentNullException(nameof(name));

    /// <summary>Gets the module that produces this output.</summary>
    public TerraformModuleResource Module { get; } = module ?? throw new ArgumentNullException(nameof(module));

    /// <inheritdoc/>
    public string ValueExpression => $"{{{Module.Name}.outputs.{Name}}}";

    IEnumerable<object> IValueWithReferences.References => [Module];

    /// <inheritdoc/>
    public async ValueTask<string?> GetValueAsync(CancellationToken cancellationToken = default)
    {
        var value = await Module.GetOutputValueAsync(Name, cancellationToken).ConfigureAwait(false);
        return value?.ToString();
    }

    /// <inheritdoc/>
    public bool Equals(TerraformModuleOutputReference? other) =>
        other is not null && ReferenceEquals(other.Module, Module) && other.Name == Name;

    /// <inheritdoc/>
    public override bool Equals(object? obj) => Equals(obj as TerraformModuleOutputReference);

    /// <inheritdoc/>
    public override int GetHashCode() => HashCode.Combine(Module, Name);
}
