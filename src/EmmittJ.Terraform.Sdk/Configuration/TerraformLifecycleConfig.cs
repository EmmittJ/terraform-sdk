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

    /// <summary>
    /// Adds a precondition to validate before applying changes.
    /// Preconditions are checked before Terraform applies the resource configuration.
    /// </summary>
    public void AddPrecondition(string condition, string errorMessage)
    {
        var precondition = new TerraformConditionBlock("precondition", condition, errorMessage);
        this[$"precondition_{Guid.NewGuid():N}"] = precondition;
    }

    /// <summary>
    /// Adds a postcondition to validate after applying changes.
    /// Postconditions are checked after Terraform applies the resource configuration.
    /// </summary>
    public void AddPostcondition(string condition, string errorMessage)
    {
        var postcondition = new TerraformConditionBlock("postcondition", condition, errorMessage);
        this[$"postcondition_{Guid.NewGuid():N}"] = postcondition;
    }
}
