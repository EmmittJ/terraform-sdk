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
    TerraformStack Scope { get; }

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
    /// Sets the current block being prepared/resolved and returns a disposable scope.
    /// Used for automatic dependency tracking.
    /// The block is automatically added to the dependency graph.
    /// Use with 'using' statement for automatic scope management.
    /// </summary>
    /// <param name="block">The current block.</param>
    /// <returns>A disposable that clears the current block when disposed.</returns>
    IDisposable SetCurrentBlock(TerraformBlock? block);

    /// <summary>
    /// Records a dependency from the current block to another block.
    /// Called automatically when resolving references during the Prepare phase.
    /// </summary>
    /// <param name="dependency">The block being depended upon.</param>
    void RecordDependency(TerraformBlock dependency);
}
