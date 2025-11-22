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
    /// Gets the current indentation level.
    /// </summary>
    int IndentLevel { get; }

    /// <summary>
    /// Gets the current indentation string (spaces for current level).
    /// </summary>
    string Indent { get; }

    /// <summary>
    /// Gets the node formatter for sorting and formatting syntax nodes.
    /// </summary>
    ITerraformNodeFormatter Formatter { get; }

    /// <summary>
    /// Increases the indentation level and returns a disposable that will decrease it when disposed.
    /// Use with 'using' statement for automatic indent management.
    /// </summary>
    /// <returns>A disposable that restores the previous indent level.</returns>
    IDisposable PushIndent();

    /// <summary>
    /// Sets the current value being resolved and returns a disposable scope.
    /// Use with 'using' statement for automatic scope management.
    /// </summary>
    /// <param name="value">The current value.</param>
    /// <returns>A disposable that clears the current value when disposed.</returns>
    IDisposable PushCurrentValue(ITerraformValue? value);
}
