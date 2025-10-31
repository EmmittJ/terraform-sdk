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

    /// <summary>
    /// Sets the current construct being prepared/resolved and returns a disposable scope.
    /// Used for automatic dependency tracking.
    /// The construct is automatically added to the dependency graph.
    /// Use with 'using' statement for automatic scope management.
    /// </summary>
    /// <param name="construct">The current construct.</param>
    /// <returns>A disposable that clears the current construct when disposed.</returns>
    IDisposable SetCurrentConstruct(TerraformConstruct? construct);

    /// <summary>
    /// Records a dependency from the current construct to another construct.
    /// Called automatically when resolving references during the Prepare phase.
    /// </summary>
    /// <param name="dependency">The construct being depended upon.</param>
    void RecordDependency(TerraformConstruct dependency);
}
