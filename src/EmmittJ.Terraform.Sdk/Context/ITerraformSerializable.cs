namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Interface for Terraform blocks and expressions that serialize to HCL strings.
/// Used for the final HCL generation phase - blocks and expressions implement this
/// to produce their HCL representation.
/// This is distinct from property resolution - properties resolve to expressions,
/// expressions then serialize to HCL.
/// </summary>
public interface ITerraformSerializable : ITerraformPreparable
{
    /// <summary>
    /// Serializes this block or expression to HCL format.
    /// </summary>
    /// <param name="context">Optional context for indentation and scope.</param>
    /// <returns>The HCL string representation.</returns>
    string ToHcl(ITerraformContext? context = null);
}
