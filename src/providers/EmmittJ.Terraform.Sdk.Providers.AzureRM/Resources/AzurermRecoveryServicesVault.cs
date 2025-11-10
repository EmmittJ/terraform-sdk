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
        set => SetProperty("infrastructure_encryption_enabled", value);
    }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    public required TerraformProperty<string> KeyId
    {
        set => SetProperty("key_id", value);
    }

    /// <summary>
    /// The use_system_assigned_identity attribute.
    /// </summary>
    public TerraformProperty<bool>? UseSystemAssignedIdentity
    {
        set => SetProperty("use_system_assigned_identity", value);
    }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    public TerraformProperty<string>? UserAssignedIdentityId
    {
        set => SetProperty("user_assigned_identity_id", value);
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
        set => SetProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        set => SetProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        set => SetProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
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
        set => SetProperty("alerts_for_all_job_failures_enabled", value);
    }

    /// <summary>
    /// The alerts_for_critical_operation_failures_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AlertsForCriticalOperationFailuresEnabled
    {
        set => SetProperty("alerts_for_critical_operation_failures_enabled", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("classic_vmware_replication_enabled");
        SetOutput("cross_region_restore_enabled");
        SetOutput("id");
        SetOutput("immutability");
        SetOutput("location");
        SetOutput("name");
        SetOutput("public_network_access_enabled");
        SetOutput("resource_group_name");
        SetOutput("sku");
        SetOutput("soft_delete_enabled");
        SetOutput("storage_mode_type");
        SetOutput("tags");
    }

    /// <summary>
    /// The classic_vmware_replication_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> ClassicVmwareReplicationEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("classic_vmware_replication_enabled");
        set => SetProperty("classic_vmware_replication_enabled", value);
    }

    /// <summary>
    /// The cross_region_restore_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> CrossRegionRestoreEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("cross_region_restore_enabled");
        set => SetProperty("cross_region_restore_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The immutability attribute.
    /// </summary>
    public TerraformProperty<string> Immutability
    {
        get => GetRequiredOutput<TerraformProperty<string>>("immutability");
        set => SetProperty("immutability", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> PublicNetworkAccessEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("public_network_access_enabled");
        set => SetProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformProperty<string> Sku
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sku");
        set => SetProperty("sku", value);
    }

    /// <summary>
    /// The soft_delete_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> SoftDeleteEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("soft_delete_enabled");
        set => SetProperty("soft_delete_enabled", value);
    }

    /// <summary>
    /// The storage_mode_type attribute.
    /// </summary>
    public TerraformProperty<string> StorageModeType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_mode_type");
        set => SetProperty("storage_mode_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Encryption block(s) allowed")]
    public List<AzurermRecoveryServicesVaultEncryptionBlock>? Encryption
    {
        set => SetProperty("encryption", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermRecoveryServicesVaultIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for monitoring.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Monitoring block(s) allowed")]
    public List<AzurermRecoveryServicesVaultMonitoringBlock>? Monitoring
    {
        set => SetProperty("monitoring", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermRecoveryServicesVaultTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
