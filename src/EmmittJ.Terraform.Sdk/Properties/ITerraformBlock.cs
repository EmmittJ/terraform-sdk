namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Marker interface for block properties.
/// Distinguishes blocks from regular attributes for serialization.
/// Blocks serialize without the = operator (block syntax).
/// </summary>
public interface ITerraformBlock
{
    // Pure marker - serialization checks this to use block syntax (no = operator)
}
