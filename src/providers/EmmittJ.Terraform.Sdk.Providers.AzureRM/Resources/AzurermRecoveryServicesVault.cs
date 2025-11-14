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
/// Block type for encryption in .
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
    [TerraformArgument("infrastructure_encryption_enabled")]
    public required TerraformValue<bool> InfrastructureEncryptionEnabled
    {
        get => new TerraformReference<bool>(this, "infrastructure_encryption_enabled");
        set => SetArgument("infrastructure_encryption_enabled", value);
    }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    [TerraformArgument("key_id")]
    public required TerraformValue<string> KeyId
    {
        get => new TerraformReference<string>(this, "key_id");
        set => SetArgument("key_id", value);
    }

    /// <summary>
    /// The use_system_assigned_identity attribute.
    /// </summary>
    [TerraformArgument("use_system_assigned_identity")]
    public TerraformValue<bool>? UseSystemAssignedIdentity
    {
        get => new TerraformReference<bool>(this, "use_system_assigned_identity");
        set => SetArgument("use_system_assigned_identity", value);
    }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    [TerraformArgument("user_assigned_identity_id")]
    public TerraformValue<string>? UserAssignedIdentityId
    {
        get => new TerraformReference<string>(this, "user_assigned_identity_id");
        set => SetArgument("user_assigned_identity_id", value);
    }

}

/// <summary>
/// Block type for identity in .
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
    [TerraformArgument("identity_ids")]
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for monitoring in .
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
    [TerraformArgument("alerts_for_all_job_failures_enabled")]
    public TerraformValue<bool>? AlertsForAllJobFailuresEnabled
    {
        get => new TerraformReference<bool>(this, "alerts_for_all_job_failures_enabled");
        set => SetArgument("alerts_for_all_job_failures_enabled", value);
    }

    /// <summary>
    /// The alerts_for_critical_operation_failures_enabled attribute.
    /// </summary>
    [TerraformArgument("alerts_for_critical_operation_failures_enabled")]
    public TerraformValue<bool>? AlertsForCriticalOperationFailuresEnabled
    {
        get => new TerraformReference<bool>(this, "alerts_for_critical_operation_failures_enabled");
        set => SetArgument("alerts_for_critical_operation_failures_enabled", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_recovery_services_vault resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermRecoveryServicesVault : TerraformResource
{
    public AzurermRecoveryServicesVault(string name) : base("azurerm_recovery_services_vault", name)
    {
    }

    /// <summary>
    /// The classic_vmware_replication_enabled attribute.
    /// </summary>
    [TerraformArgument("classic_vmware_replication_enabled")]
    public TerraformValue<bool>? ClassicVmwareReplicationEnabled
    {
        get => new TerraformReference<bool>(this, "classic_vmware_replication_enabled");
        set => SetArgument("classic_vmware_replication_enabled", value);
    }

    /// <summary>
    /// The cross_region_restore_enabled attribute.
    /// </summary>
    [TerraformArgument("cross_region_restore_enabled")]
    public TerraformValue<bool>? CrossRegionRestoreEnabled
    {
        get => new TerraformReference<bool>(this, "cross_region_restore_enabled");
        set => SetArgument("cross_region_restore_enabled", value);
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
    /// The immutability attribute.
    /// </summary>
    [TerraformArgument("immutability")]
    public TerraformValue<string> Immutability
    {
        get => new TerraformReference<string>(this, "immutability");
        set => SetArgument("immutability", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformArgument("public_network_access_enabled")]
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => new TerraformReference<bool>(this, "public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [TerraformArgument("sku")]
    public required TerraformValue<string> Sku
    {
        get => new TerraformReference<string>(this, "sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The soft_delete_enabled attribute.
    /// </summary>
    [TerraformArgument("soft_delete_enabled")]
    public TerraformValue<bool>? SoftDeleteEnabled
    {
        get => new TerraformReference<bool>(this, "soft_delete_enabled");
        set => SetArgument("soft_delete_enabled", value);
    }

    /// <summary>
    /// The storage_mode_type attribute.
    /// </summary>
    [TerraformArgument("storage_mode_type")]
    public TerraformValue<string>? StorageModeType
    {
        get => new TerraformReference<string>(this, "storage_mode_type");
        set => SetArgument("storage_mode_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Encryption block(s) allowed")]
    [TerraformArgument("encryption")]
    public TerraformList<AzurermRecoveryServicesVaultEncryptionBlock> Encryption { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermRecoveryServicesVaultIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for monitoring.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Monitoring block(s) allowed")]
    [TerraformArgument("monitoring")]
    public TerraformList<AzurermRecoveryServicesVaultMonitoringBlock> Monitoring { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermRecoveryServicesVaultTimeoutsBlock Timeouts { get; set; } = new();

}
