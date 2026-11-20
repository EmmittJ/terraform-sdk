// Licensed under the MIT License.

using Aspire.Hosting.ApplicationModel;

namespace EmmittJ.Aspire.Hosting.Terraform.Modules;

/// <summary>
/// An Aspire value backed by a Terraform output of a <see cref="TerraformModuleResource"/>.
/// Resolves once the module has been applied and its outputs read.
/// </summary>
public sealed class TerraformModuleOutputReference(string name, TerraformModuleResource module)
    : IManifestExpressionProvider, IValueProvider, IValueWithReferences, IEquatable<TerraformModuleOutputReference>
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
        await Module.WaitForOutputsAsync(cancellationToken).ConfigureAwait(false);

        if (!Module.Outputs.TryGetValue(Name, out var value))
        {
            throw new InvalidOperationException(
                $"Terraform module '{Module.Name}' has no output named '{Name}'. Declare it with an `output \"{Name}\"` block in {Module.ModuleDirectory}.");
        }

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
