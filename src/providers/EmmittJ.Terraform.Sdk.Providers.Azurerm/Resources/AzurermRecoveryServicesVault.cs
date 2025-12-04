using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for encryption in AzurermRecoveryServicesVault.
/// Nesting mode: list
/// </summary>
public class AzurermRecoveryServicesVaultEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption";

    /// <summary>
    /// The infrastructure_encryption_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InfrastructureEncryptionEnabled is required")]
    public required TerraformValue<bool> InfrastructureEncryptionEnabled
    {
        get => GetArgument<TerraformValue<bool>>("infrastructure_encryption_enabled");
        set => SetArgument("infrastructure_encryption_enabled", value);
    }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    public required TerraformValue<string> KeyId
    {
        get => GetArgument<TerraformValue<string>>("key_id");
        set => SetArgument("key_id", value);
    }

    /// <summary>
    /// The use_system_assigned_identity attribute.
    /// </summary>
    public TerraformValue<bool>? UseSystemAssignedIdentity
    {
        get => GetArgument<TerraformValue<bool>>("use_system_assigned_identity");
        set => SetArgument("use_system_assigned_identity", value);
    }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    public TerraformValue<string>? UserAssignedIdentityId
    {
        get => GetArgument<TerraformValue<string>>("user_assigned_identity_id");
        set => SetArgument("user_assigned_identity_id", value);
    }

}


/// <summary>
/// Block type for identity in AzurermRecoveryServicesVault.
/// Nesting mode: list
/// </summary>
public class AzurermRecoveryServicesVaultIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public TerraformSet<string>? IdentityIds
    {
        get => GetArgument<TerraformSet<string>>("identity_ids");
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
        => AsReference("principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
        => AsReference("tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for monitoring in AzurermRecoveryServicesVault.
/// Nesting mode: list
/// </summary>
public class AzurermRecoveryServicesVaultMonitoringBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "monitoring";

    /// <summary>
    /// The alerts_for_all_job_failures_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AlertsForAllJobFailuresEnabled
    {
        get => GetArgument<TerraformValue<bool>>("alerts_for_all_job_failures_enabled");
        set => SetArgument("alerts_for_all_job_failures_enabled", value);
    }

    /// <summary>
    /// The alerts_for_critical_operation_failures_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AlertsForCriticalOperationFailuresEnabled
    {
        get => GetArgument<TerraformValue<bool>>("alerts_for_critical_operation_failures_enabled");
        set => SetArgument("alerts_for_critical_operation_failures_enabled", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermRecoveryServicesVault.
/// Nesting mode: single
/// </summary>
public class AzurermRecoveryServicesVaultTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_recovery_services_vault Terraform resource.
/// Manages a azurerm_recovery_services_vault resource.
/// </summary>
public partial class AzurermRecoveryServicesVault(string name) : TerraformResource("azurerm_recovery_services_vault", name)
{
    /// <summary>
    /// The classic_vmware_replication_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ClassicVmwareReplicationEnabled
    {
        get => GetArgument<TerraformValue<bool>>("classic_vmware_replication_enabled");
        set => SetArgument("classic_vmware_replication_enabled", value);
    }

    /// <summary>
    /// The cross_region_restore_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? CrossRegionRestoreEnabled
    {
        get => GetArgument<TerraformValue<bool>>("cross_region_restore_enabled");
        set => SetArgument("cross_region_restore_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The immutability attribute.
    /// </summary>
    public TerraformValue<string>? Immutability
    {
        get => GetArgument<TerraformValue<string>>("immutability");
        set => SetArgument("immutability", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => GetArgument<TerraformValue<bool>>("public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformValue<string> Sku
    {
        get => GetArgument<TerraformValue<string>>("sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The soft_delete_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SoftDeleteEnabled
    {
        get => GetArgument<TerraformValue<bool>>("soft_delete_enabled");
        set => SetArgument("soft_delete_enabled", value);
    }

    /// <summary>
    /// The storage_mode_type attribute.
    /// </summary>
    public TerraformValue<string>? StorageModeType
    {
        get => GetArgument<TerraformValue<string>>("storage_mode_type");
        set => SetArgument("storage_mode_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Encryption block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Encryption block(s) allowed")]
    public TerraformList<AzurermRecoveryServicesVaultEncryptionBlock>? Encryption
    {
        get => GetArgument<TerraformList<AzurermRecoveryServicesVaultEncryptionBlock>>("encryption");
        set => SetArgument("encryption", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermRecoveryServicesVaultIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermRecoveryServicesVaultIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Monitoring block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Monitoring block(s) allowed")]
    public TerraformList<AzurermRecoveryServicesVaultMonitoringBlock>? Monitoring
    {
        get => GetArgument<TerraformList<AzurermRecoveryServicesVaultMonitoringBlock>>("monitoring");
        set => SetArgument("monitoring", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermRecoveryServicesVaultTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermRecoveryServicesVaultTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
