using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetappVolumeGroupOracleTimeoutsBlock : TerraformBlock
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
/// Block type for volume in .
/// Nesting mode: list
/// </summary>
public class AzurermNetappVolumeGroupOracleVolumeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "volume";

    /// <summary>
    /// The capacity_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityPoolId is required")]
    public required TerraformValue<string> CapacityPoolId
    {
        get => new TerraformReference<string>(this, "capacity_pool_id");
        set => SetArgument("capacity_pool_id", value);
    }

    /// <summary>
    /// The encryption_key_source attribute.
    /// </summary>
    public TerraformValue<string> EncryptionKeySource
    {
        get => new TerraformReference<string>(this, "encryption_key_source");
        set => SetArgument("encryption_key_source", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The key_vault_private_endpoint_id attribute.
    /// </summary>
    public TerraformValue<string> KeyVaultPrivateEndpointId
    {
        get => new TerraformReference<string>(this, "key_vault_private_endpoint_id");
        set => SetArgument("key_vault_private_endpoint_id", value);
    }

    /// <summary>
    /// The mount_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> MountIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "mount_ip_addresses").ResolveNodes(ctx));
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
    /// The network_features attribute.
    /// </summary>
    public TerraformValue<string> NetworkFeatures
    {
        get => new TerraformReference<string>(this, "network_features");
        set => SetArgument("network_features", value);
    }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocols is required")]
    public TerraformList<string>? Protocols
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "protocols").ResolveNodes(ctx));
        set => SetArgument("protocols", value);
    }

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    public TerraformValue<string>? ProximityPlacementGroupId
    {
        get => new TerraformReference<string>(this, "proximity_placement_group_id");
        set => SetArgument("proximity_placement_group_id", value);
    }

    /// <summary>
    /// The security_style attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityStyle is required")]
    public required TerraformValue<string> SecurityStyle
    {
        get => new TerraformReference<string>(this, "security_style");
        set => SetArgument("security_style", value);
    }

    /// <summary>
    /// The service_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceLevel is required")]
    public required TerraformValue<string> ServiceLevel
    {
        get => new TerraformReference<string>(this, "service_level");
        set => SetArgument("service_level", value);
    }

    /// <summary>
    /// The snapshot_directory_visible attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotDirectoryVisible is required")]
    public required TerraformValue<bool> SnapshotDirectoryVisible
    {
        get => new TerraformReference<bool>(this, "snapshot_directory_visible");
        set => SetArgument("snapshot_directory_visible", value);
    }

    /// <summary>
    /// The storage_quota_in_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageQuotaInGb is required")]
    public required TerraformValue<double> StorageQuotaInGb
    {
        get => new TerraformReference<double>(this, "storage_quota_in_gb");
        set => SetArgument("storage_quota_in_gb", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The throughput_in_mibps attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThroughputInMibps is required")]
    public required TerraformValue<double> ThroughputInMibps
    {
        get => new TerraformReference<double>(this, "throughput_in_mibps");
        set => SetArgument("throughput_in_mibps", value);
    }

    /// <summary>
    /// The volume_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumePath is required")]
    public required TerraformValue<string> VolumePath
    {
        get => new TerraformReference<string>(this, "volume_path");
        set => SetArgument("volume_path", value);
    }

    /// <summary>
    /// The volume_spec_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeSpecName is required")]
    public required TerraformValue<string> VolumeSpecName
    {
        get => new TerraformReference<string>(this, "volume_spec_name");
        set => SetArgument("volume_spec_name", value);
    }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    public TerraformValue<string>? Zone
    {
        get => new TerraformReference<string>(this, "zone");
        set => SetArgument("zone", value);
    }

}

/// <summary>
/// Represents a azurerm_netapp_volume_group_oracle Terraform resource.
/// Manages a azurerm_netapp_volume_group_oracle resource.
/// </summary>
public partial class AzurermNetappVolumeGroupOracle(string name) : TerraformResource("azurerm_netapp_volume_group_oracle", name)
{
    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    public required TerraformValue<string> AccountName
    {
        get => new TerraformReference<string>(this, "account_name");
        set => SetArgument("account_name", value);
    }

    /// <summary>
    /// The application_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationIdentifier is required")]
    public required TerraformValue<string> ApplicationIdentifier
    {
        get => new TerraformReference<string>(this, "application_identifier");
        set => SetArgument("application_identifier", value);
    }

    /// <summary>
    /// The group_description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupDescription is required")]
    public required TerraformValue<string> GroupDescription
    {
        get => new TerraformReference<string>(this, "group_description");
        set => SetArgument("group_description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNetappVolumeGroupOracleTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNetappVolumeGroupOracleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// Volume block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(2, ErrorMessage = "At least 2 Volume block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(12, ErrorMessage = "Maximum 12 Volume block(s) allowed")]
    public TerraformList<AzurermNetappVolumeGroupOracleVolumeBlock>? Volume
    {
        get => GetArgument<TerraformList<AzurermNetappVolumeGroupOracleVolumeBlock>>("volume");
        set => SetArgument("volume", value);
    }

}
