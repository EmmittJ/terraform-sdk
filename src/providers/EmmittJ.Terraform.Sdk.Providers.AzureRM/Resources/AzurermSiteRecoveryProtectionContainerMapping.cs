using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for automatic_update in .
/// Nesting mode: list
/// </summary>
public class AzurermSiteRecoveryProtectionContainerMappingAutomaticUpdateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "automatic_update";

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    public TerraformValue<string>? AuthenticationType
    {
        get => new TerraformReference<string>(this, "authentication_type");
        set => SetArgument("authentication_type", value);
    }

    /// <summary>
    /// The automation_account_id attribute.
    /// </summary>
    public TerraformValue<string>? AutomationAccountId
    {
        get => new TerraformReference<string>(this, "automation_account_id");
        set => SetArgument("automation_account_id", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSiteRecoveryProtectionContainerMappingTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_site_recovery_protection_container_mapping Terraform resource.
/// Manages a azurerm_site_recovery_protection_container_mapping resource.
/// </summary>
public partial class AzurermSiteRecoveryProtectionContainerMapping(string name) : TerraformResource("azurerm_site_recovery_protection_container_mapping", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The recovery_fabric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryFabricName is required")]
    public required TerraformValue<string> RecoveryFabricName
    {
        get => new TerraformReference<string>(this, "recovery_fabric_name");
        set => SetArgument("recovery_fabric_name", value);
    }

    /// <summary>
    /// The recovery_replication_policy_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryReplicationPolicyId is required")]
    public required TerraformValue<string> RecoveryReplicationPolicyId
    {
        get => new TerraformReference<string>(this, "recovery_replication_policy_id");
        set => SetArgument("recovery_replication_policy_id", value);
    }

    /// <summary>
    /// The recovery_source_protection_container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoverySourceProtectionContainerName is required")]
    public required TerraformValue<string> RecoverySourceProtectionContainerName
    {
        get => new TerraformReference<string>(this, "recovery_source_protection_container_name");
        set => SetArgument("recovery_source_protection_container_name", value);
    }

    /// <summary>
    /// The recovery_target_protection_container_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryTargetProtectionContainerId is required")]
    public required TerraformValue<string> RecoveryTargetProtectionContainerId
    {
        get => new TerraformReference<string>(this, "recovery_target_protection_container_id");
        set => SetArgument("recovery_target_protection_container_id", value);
    }

    /// <summary>
    /// The recovery_vault_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryVaultName is required")]
    public required TerraformValue<string> RecoveryVaultName
    {
        get => new TerraformReference<string>(this, "recovery_vault_name");
        set => SetArgument("recovery_vault_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// AutomaticUpdate block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomaticUpdate block(s) allowed")]
    public AzurermSiteRecoveryProtectionContainerMappingAutomaticUpdateBlock? AutomaticUpdate
    {
        get => GetArgument<AzurermSiteRecoveryProtectionContainerMappingAutomaticUpdateBlock>("automatic_update");
        set => SetArgument("automatic_update", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSiteRecoveryProtectionContainerMappingTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSiteRecoveryProtectionContainerMappingTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
