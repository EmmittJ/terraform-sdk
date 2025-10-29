namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Context for the resolution phase of terraform resolution.
/// Provides access to the scope and helpers for resolving nested resolvables.
/// </summary>
public interface ITerraformResolveContext
{
    /// <summary>
    /// Gets the current configuration scope.
    /// </summary>
    TerraformConfiguration Scope { get; }

    /// <summary>
    /// Helper to resolve nested resolvables.
    /// </summary>
    /// <typeparam name="T">The type that will be resolved.</typeparam>
    /// <param name="resolvable">The resolvable to resolve.</param>
    /// <returns>The resolved value.</returns>
    T Resolve<T>(ITerraformResolvable<T> resolvable);
}
