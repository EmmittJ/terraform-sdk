using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermContainerRegistryCacheRuleDataSource.
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
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_container_registry_cache_rule Terraform data source.
/// Retrieves information about a azurerm_container_registry_cache_rule.
/// </summary>
public partial class AzurermContainerRegistryCacheRuleDataSource(string name) : TerraformDataSource("azurerm_container_registry_cache_rule", name)
{
    /// <summary>
    /// The container_registry_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerRegistryId is required")]
    public required TerraformValue<string> ContainerRegistryId
    {
        get => GetRequiredArgument<TerraformValue<string>>("container_registry_id");
        set => SetArgument("container_registry_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The credential_set_id attribute.
    /// </summary>
    public TerraformValue<string> CredentialSetId
        => CreateReference("credential_set_id");

    /// <summary>
    /// The source_repo attribute.
    /// </summary>
    public TerraformValue<string> SourceRepo
        => CreateReference("source_repo");

    /// <summary>
    /// The target_repo attribute.
    /// </summary>
    public TerraformValue<string> TargetRepo
        => CreateReference("target_repo");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermContainerRegistryCacheRuleDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermContainerRegistryCacheRuleDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
