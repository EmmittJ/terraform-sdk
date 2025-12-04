using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermSiteRecoveryNetworkMapping.
/// Nesting mode: single
/// </summary>
public class AzurermSiteRecoveryNetworkMappingTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

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
/// Represents a azurerm_site_recovery_network_mapping Terraform resource.
/// Manages a azurerm_site_recovery_network_mapping resource.
/// </summary>
public partial class AzurermSiteRecoveryNetworkMapping(string name) : TerraformResource("azurerm_site_recovery_network_mapping", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
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
    /// The recovery_vault_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryVaultName is required")]
    public required TerraformValue<string> RecoveryVaultName
    {
        get => GetRequiredArgument<TerraformValue<string>>("recovery_vault_name");
        set => SetArgument("recovery_vault_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The source_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceNetworkId is required")]
    public required TerraformValue<string> SourceNetworkId
    {
        get => GetRequiredArgument<TerraformValue<string>>("source_network_id");
        set => SetArgument("source_network_id", value);
    }

    /// <summary>
    /// The source_recovery_fabric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceRecoveryFabricName is required")]
    public required TerraformValue<string> SourceRecoveryFabricName
    {
        get => GetRequiredArgument<TerraformValue<string>>("source_recovery_fabric_name");
        set => SetArgument("source_recovery_fabric_name", value);
    }

    /// <summary>
    /// The target_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetNetworkId is required")]
    public required TerraformValue<string> TargetNetworkId
    {
        get => GetRequiredArgument<TerraformValue<string>>("target_network_id");
        set => SetArgument("target_network_id", value);
    }

    /// <summary>
    /// The target_recovery_fabric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetRecoveryFabricName is required")]
    public required TerraformValue<string> TargetRecoveryFabricName
    {
        get => GetRequiredArgument<TerraformValue<string>>("target_recovery_fabric_name");
        set => SetArgument("target_recovery_fabric_name", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSiteRecoveryNetworkMappingTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSiteRecoveryNetworkMappingTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
