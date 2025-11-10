using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetappVolumeGroupOracleTimeoutsBlock : TerraformBlock
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
/// Block type for volume in .
/// Nesting mode: list
/// </summary>
public class AzurermNetappVolumeGroupOracleVolumeBlock : TerraformBlock
{
    /// <summary>
    /// The capacity_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityPoolId is required")]
    public required TerraformProperty<string> CapacityPoolId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("capacity_pool_id");
        set => WithProperty("capacity_pool_id", value);
    }

    /// <summary>
    /// The encryption_key_source attribute.
    /// </summary>
    public TerraformProperty<string>? EncryptionKeySource
    {
        get => GetProperty<TerraformProperty<string>>("encryption_key_source");
        set => WithProperty("encryption_key_source", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The key_vault_private_endpoint_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVaultPrivateEndpointId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_private_endpoint_id");
        set => WithProperty("key_vault_private_endpoint_id", value);
    }

    /// <summary>
    /// The mount_ip_addresses attribute.
    /// </summary>
    public List<TerraformProperty<string>>? MountIpAddresses
    {
        get => GetProperty<List<TerraformProperty<string>>>("mount_ip_addresses");
        set => WithProperty("mount_ip_addresses", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The network_features attribute.
    /// </summary>
    public TerraformProperty<string>? NetworkFeatures
    {
        get => GetProperty<TerraformProperty<string>>("network_features");
        set => WithProperty("network_features", value);
    }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocols is required")]
    public List<TerraformProperty<string>>? Protocols
    {
        get => GetProperty<List<TerraformProperty<string>>>("protocols");
        set => WithProperty("protocols", value);
    }

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? ProximityPlacementGroupId
    {
        get => GetProperty<TerraformProperty<string>>("proximity_placement_group_id");
        set => WithProperty("proximity_placement_group_id", value);
    }

    /// <summary>
    /// The security_style attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityStyle is required")]
    public required TerraformProperty<string> SecurityStyle
    {
        get => GetRequiredProperty<TerraformProperty<string>>("security_style");
        set => WithProperty("security_style", value);
    }

    /// <summary>
    /// The service_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceLevel is required")]
    public required TerraformProperty<string> ServiceLevel
    {
        get => GetRequiredProperty<TerraformProperty<string>>("service_level");
        set => WithProperty("service_level", value);
    }

    /// <summary>
    /// The snapshot_directory_visible attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotDirectoryVisible is required")]
    public required TerraformProperty<bool> SnapshotDirectoryVisible
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("snapshot_directory_visible");
        set => WithProperty("snapshot_directory_visible", value);
    }

    /// <summary>
    /// The storage_quota_in_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageQuotaInGb is required")]
    public required TerraformProperty<double> StorageQuotaInGb
    {
        get => GetRequiredProperty<TerraformProperty<double>>("storage_quota_in_gb");
        set => WithProperty("storage_quota_in_gb", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("subnet_id");
        set => WithProperty("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => WithProperty("tags", value);
    }

    /// <summary>
    /// The throughput_in_mibps attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThroughputInMibps is required")]
    public required TerraformProperty<double> ThroughputInMibps
    {
        get => GetRequiredProperty<TerraformProperty<double>>("throughput_in_mibps");
        set => WithProperty("throughput_in_mibps", value);
    }

    /// <summary>
    /// The volume_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumePath is required")]
    public required TerraformProperty<string> VolumePath
    {
        get => GetRequiredProperty<TerraformProperty<string>>("volume_path");
        set => WithProperty("volume_path", value);
    }

    /// <summary>
    /// The volume_spec_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeSpecName is required")]
    public required TerraformProperty<string> VolumeSpecName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("volume_spec_name");
        set => WithProperty("volume_spec_name", value);
    }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    public TerraformProperty<string>? Zone
    {
        get => GetProperty<TerraformProperty<string>>("zone");
        set => WithProperty("zone", value);
    }

}

/// <summary>
/// Manages a azurerm_netapp_volume_group_oracle resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermNetappVolumeGroupOracle : TerraformResource
{
    public AzurermNetappVolumeGroupOracle(string name) : base("azurerm_netapp_volume_group_oracle", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    public required TerraformProperty<string> AccountName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("account_name");
        set => this.WithProperty("account_name", value);
    }

    /// <summary>
    /// The application_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationIdentifier is required")]
    public required TerraformProperty<string> ApplicationIdentifier
    {
        get => GetRequiredProperty<TerraformProperty<string>>("application_identifier");
        set => this.WithProperty("application_identifier", value);
    }

    /// <summary>
    /// The group_description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupDescription is required")]
    public required TerraformProperty<string> GroupDescription
    {
        get => GetRequiredProperty<TerraformProperty<string>>("group_description");
        set => this.WithProperty("group_description", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNetappVolumeGroupOracleTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermNetappVolumeGroupOracleTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for volume.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(2, ErrorMessage = "At least 2 Volume block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(12, ErrorMessage = "Maximum 12 Volume block(s) allowed")]
    public List<AzurermNetappVolumeGroupOracleVolumeBlock>? Volume
    {
        get => GetProperty<List<AzurermNetappVolumeGroupOracleVolumeBlock>>("volume");
        set => this.WithProperty("volume", value);
    }

}
