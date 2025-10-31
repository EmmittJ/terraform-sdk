namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Context for terraform preparation and resolution.
/// Provides access to the scope, indentation management, and helpers for processing resolvables.
/// </summary>
public interface ITerraformContext
{
    /// <summary>
    /// Gets the current configuration scope.
    /// </summary>
    TerraformConfiguration Scope { get; }

    /// <summary>
    /// Gets the dependency graph being built during the Prepare phase.
    /// </summary>
    DependencyGraph DependencyGraph { get; }

    /// <summary>
    /// Gets the current indentation level.
    /// </summary>
    int IndentLevel { get; }

    /// <summary>
    /// Gets the current indentation string (spaces for current level).
    /// </summary>
    string Indent { get; }

    /// <summary>
    /// Increases the indentation level and returns a disposable that will decrease it when disposed.
    /// Use with 'using' statement for automatic indent management.
    /// </summary>
    /// <returns>A disposable that restores the previous indent level.</returns>
    IDisposable PushIndent();
}
