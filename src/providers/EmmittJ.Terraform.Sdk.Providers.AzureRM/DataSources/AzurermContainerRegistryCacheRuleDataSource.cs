using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerRegistryCacheRuleDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_container_registry_cache_rule.
/// </summary>
public class AzurermContainerRegistryCacheRuleDataSource : TerraformDataSource
{
    public AzurermContainerRegistryCacheRuleDataSource(string name) : base("azurerm_container_registry_cache_rule", name)
    {
    }

    /// <summary>
    /// The container_registry_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerRegistryId is required")]
    [TerraformArgument("container_registry_id")]
    public required TerraformValue<string> ContainerRegistryId
    {
        get => new TerraformReference<string>(this, "container_registry_id");
        set => SetArgument("container_registry_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermContainerRegistryCacheRuleDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The credential_set_id attribute.
    /// </summary>
    [TerraformArgument("credential_set_id")]
    public TerraformValue<string> CredentialSetId
    {
        get => new TerraformReference<string>(this, "credential_set_id");
    }

    /// <summary>
    /// The source_repo attribute.
    /// </summary>
    [TerraformArgument("source_repo")]
    public TerraformValue<string> SourceRepo
    {
        get => new TerraformReference<string>(this, "source_repo");
    }

    /// <summary>
    /// The target_repo attribute.
    /// </summary>
    [TerraformArgument("target_repo")]
    public TerraformValue<string> TargetRepo
    {
        get => new TerraformReference<string>(this, "target_repo");
    }

}
