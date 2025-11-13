namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents lifecycle meta-argument configuration for resources.
/// Controls resource creation, destruction, and change detection behavior.
/// Use the indexer to set properties: lifecycle["create_before_destroy"] = true
/// </summary>
public class TerraformLifecycleConfig : TerraformBlock
{
    /// <summary>
    /// Initializes a new instance of the TerraformLifecycleConfig class.
    /// </summary>
    public TerraformLifecycleConfig()
    {
    }

    protected internal override string? BlockLabel => "lifecycle";
}
