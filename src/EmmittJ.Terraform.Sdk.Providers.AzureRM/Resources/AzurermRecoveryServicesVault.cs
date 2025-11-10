using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for encryption in .
/// Nesting mode: list
/// </summary>
public class AzurermRecoveryServicesVaultEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// The infrastructure_encryption_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InfrastructureEncryptionEnabled is required")]
    public required TerraformProperty<bool> InfrastructureEncryptionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("infrastructure_encryption_enabled");
        set => WithProperty("infrastructure_encryption_enabled", value);
    }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    public required TerraformProperty<string> KeyId
    {
        get => GetProperty<TerraformProperty<string>>("key_id");
        set => WithProperty("key_id", value);
    }

    /// <summary>
    /// The use_system_assigned_identity attribute.
    /// </summary>
    public TerraformProperty<bool>? UseSystemAssignedIdentity
    {
        get => GetProperty<TerraformProperty<bool>>("use_system_assigned_identity");
        set => WithProperty("use_system_assigned_identity", value);
    }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    public TerraformProperty<string>? UserAssignedIdentityId
    {
        get => GetProperty<TerraformProperty<string>>("user_assigned_identity_id");
        set => WithProperty("user_assigned_identity_id", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermRecoveryServicesVaultIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("identity_ids");
        set => WithProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => WithProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for monitoring in .
/// Nesting mode: list
/// </summary>
public class AzurermRecoveryServicesVaultMonitoringBlock : TerraformBlock
{
    /// <summary>
    /// The alerts_for_all_job_failures_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AlertsForAllJobFailuresEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("alerts_for_all_job_failures_enabled");
        set => WithProperty("alerts_for_all_job_failures_enabled", value);
    }

    /// <summary>
    /// The alerts_for_critical_operation_failures_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AlertsForCriticalOperationFailuresEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("alerts_for_critical_operation_failures_enabled");
        set => WithProperty("alerts_for_critical_operation_failures_enabled", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermRecoveryServicesVaultTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_recovery_services_vault resource.
/// </summary>
public class AzurermRecoveryServicesVault : TerraformResource
{
    public AzurermRecoveryServicesVault(string name) : base("azurerm_recovery_services_vault", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The classic_vmware_replication_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ClassicVmwareReplicationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("classic_vmware_replication_enabled");
        set => this.WithProperty("classic_vmware_replication_enabled", value);
    }

    /// <summary>
    /// The cross_region_restore_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? CrossRegionRestoreEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("cross_region_restore_enabled");
        set => this.WithProperty("cross_region_restore_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The immutability attribute.
    /// </summary>
    public TerraformProperty<string>? Immutability
    {
        get => GetProperty<TerraformProperty<string>>("immutability");
        set => this.WithProperty("immutability", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_network_access_enabled");
        set => this.WithProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformProperty<string> Sku
    {
        get => GetProperty<TerraformProperty<string>>("sku");
        set => this.WithProperty("sku", value);
    }

    /// <summary>
    /// The soft_delete_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SoftDeleteEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("soft_delete_enabled");
        set => this.WithProperty("soft_delete_enabled", value);
    }

    /// <summary>
    /// The storage_mode_type attribute.
    /// </summary>
    public TerraformProperty<string>? StorageModeType
    {
        get => GetProperty<TerraformProperty<string>>("storage_mode_type");
        set => this.WithProperty("storage_mode_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Encryption block(s) allowed")]
    public List<AzurermRecoveryServicesVaultEncryptionBlock>? Encryption
    {
        get => GetProperty<List<AzurermRecoveryServicesVaultEncryptionBlock>>("encryption");
        set => this.WithProperty("encryption", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermRecoveryServicesVaultIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermRecoveryServicesVaultIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for monitoring.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Monitoring block(s) allowed")]
    public List<AzurermRecoveryServicesVaultMonitoringBlock>? Monitoring
    {
        get => GetProperty<List<AzurermRecoveryServicesVaultMonitoringBlock>>("monitoring");
        set => this.WithProperty("monitoring", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermRecoveryServicesVaultTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermRecoveryServicesVaultTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
