namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents lifecycle meta-argument configuration for resources.
/// Controls resource creation, destruction, and change detection behavior.
/// Use the indexer to set properties: lifecycle["create_before_destroy"] = true
/// </summary>
/// <remarks>
/// <para>Spec: <see href="https://developer.hashicorp.com/terraform/language/meta-arguments/lifecycle"/></para>
/// </remarks>
public class TerraformLifecycleConfig : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lifecycle";

    /// <summary>
    /// Initializes a new instance of the TerraformLifecycleConfig class.
    /// </summary>
    public TerraformLifecycleConfig()
    {
    }
}
