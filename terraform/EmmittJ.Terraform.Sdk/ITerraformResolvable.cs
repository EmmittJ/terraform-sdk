namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Generic resolvable interface with separate prepare and resolve phases.
/// Enables deferred resolution for handling circular references, cross-stack references, and late-bound values.
/// </summary>
/// <typeparam name="T">The type that will be resolved.</typeparam>
public interface ITerraformResolvable<out T>
{
    /// <summary>
    /// Preparation phase - called first to track dependencies and validate structure.
    /// </summary>
    /// <param name="context">The context for preparation and resolution.</param>
    void Prepare(ITerraformContext context);

    /// <summary>
    /// Converts to HCL representation with optional context.
    /// When context is provided, uses it for indentation and scope access.
    /// When context is null, creates a temporary context.
    /// </summary>
    /// <param name="context">Optional context for indentation and scope.</param>
    /// <returns>The HCL representation.</returns>
    T Resolve(ITerraformContext? context = null);
}

/// <summary>
/// Non-generic base interface for scenarios where runtime polymorphism is needed.
/// Resolves to a string representation.
/// </summary>
public interface ITerraformResolvable : ITerraformResolvable<string>
{
}
