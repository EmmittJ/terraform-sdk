namespace EmmittJ.Terraform.Sdk;

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
