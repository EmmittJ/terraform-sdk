namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Generic resolvable interface with separate prepare and resolve phases.
/// Enables deferred resolution for handling circular references, cross-stack references, and late-bound values.
/// </summary>
/// <typeparam name="T">The type that will be resolved.</typeparam>
public interface ITerraformResolvable<out T> : ITerraformPreparable
{
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
/// Interface for preparation phase of Terraform resolvables.
/// </summary>
public interface ITerraformPreparable
{
    /// <summary>
    /// Preparation phase - called first to track dependencies and validate structure.
    /// </summary>
    /// <param name="context">The context for preparation and resolution.</param>
    void Prepare(ITerraformContext context);
}