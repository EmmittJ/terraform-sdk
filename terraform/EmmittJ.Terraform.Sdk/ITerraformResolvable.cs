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
    /// <param name="context">The preparation context.</param>
    void Prepare(ITerraformPrepareContext context);

    /// <summary>
    /// Resolution phase - called after preparation to produce the final value.
    /// </summary>
    /// <param name="context">The resolution context.</param>
    /// <returns>The resolved value.</returns>
    T Resolve(ITerraformResolveContext context);
}

/// <summary>
/// Non-generic base interface for scenarios where runtime polymorphism is needed.
/// Resolves to a string representation.
/// </summary>
public interface ITerraformResolvable : ITerraformResolvable<string>
{
}
