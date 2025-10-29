namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Context for the preparation phase of terraform resolution.
/// Provides access to the scope and helpers for preparing nested resolvables.
/// </summary>
public interface ITerraformPrepareContext
{
    /// <summary>
    /// Gets the current configuration scope.
    /// </summary>
    TerraformConfiguration Scope { get; }

    /// <summary>
    /// Helper to prepare nested resolvables.
    /// </summary>
    /// <typeparam name="T">The type that will be resolved.</typeparam>
    /// <param name="resolvable">The resolvable to prepare.</param>
    void Prepare<T>(ITerraformResolvable<T> resolvable);
}
