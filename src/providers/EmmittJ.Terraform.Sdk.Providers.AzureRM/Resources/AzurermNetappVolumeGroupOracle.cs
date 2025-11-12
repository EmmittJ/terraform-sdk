using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermNetappVolumeGroupOracleTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for volume in .
/// Nesting mode: list
/// </summary>
public partial class AzurermNetappVolumeGroupOracleVolumeBlock() : TerraformBlock("volume")
{
    /// <summary>
    /// The capacity_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityPoolId is required")]
    [TerraformProperty("capacity_pool_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CapacityPoolId { get; set; }

    /// <summary>
    /// The encryption_key_source attribute.
    /// </summary>
    [TerraformProperty("encryption_key_source")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> EncryptionKeySource { get; set; }


    /// <summary>
    /// The key_vault_private_endpoint_id attribute.
    /// </summary>
    [TerraformProperty("key_vault_private_endpoint_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KeyVaultPrivateEndpointId { get; set; }


    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The network_features attribute.
    /// </summary>
    [TerraformProperty("network_features")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NetworkFeatures { get; set; }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocols is required")]
    [TerraformProperty("protocols")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? Protocols { get; set; }

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    [TerraformProperty("proximity_placement_group_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ProximityPlacementGroupId { get; set; }

    /// <summary>
    /// The security_style attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityStyle is required")]
    [TerraformProperty("security_style")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SecurityStyle { get; set; }

    /// <summary>
    /// The service_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceLevel is required")]
    [TerraformProperty("service_level")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServiceLevel { get; set; }

    /// <summary>
    /// The snapshot_directory_visible attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotDirectoryVisible is required")]
    [TerraformProperty("snapshot_directory_visible")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> SnapshotDirectoryVisible { get; set; }

    /// <summary>
    /// The storage_quota_in_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageQuotaInGb is required")]
    [TerraformProperty("storage_quota_in_gb")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> StorageQuotaInGb { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformProperty("subnet_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SubnetId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The throughput_in_mibps attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThroughputInMibps is required")]
    [TerraformProperty("throughput_in_mibps")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> ThroughputInMibps { get; set; }

    /// <summary>
    /// The volume_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumePath is required")]
    [TerraformProperty("volume_path")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VolumePath { get; set; }

    /// <summary>
    /// The volume_spec_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeSpecName is required")]
    [TerraformProperty("volume_spec_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VolumeSpecName { get; set; }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    [TerraformProperty("zone")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Zone { get; set; }

}

/// <summary>
/// Manages a azurerm_netapp_volume_group_oracle resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermNetappVolumeGroupOracle : TerraformResource
{
    public AzurermNetappVolumeGroupOracle(string name) : base("azurerm_netapp_volume_group_oracle", name)
    {
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    [TerraformProperty("account_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AccountName { get; set; }

    /// <summary>
    /// The application_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationIdentifier is required")]
    [TerraformProperty("application_identifier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ApplicationIdentifier { get; set; }

    /// <summary>
    /// The group_description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupDescription is required")]
    [TerraformProperty("group_description")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> GroupDescription { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermNetappVolumeGroupOracleTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for volume.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(2, ErrorMessage = "At least 2 Volume block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(12, ErrorMessage = "Maximum 12 Volume block(s) allowed")]
    [TerraformProperty("volume")]
    public TerraformList<AzurermNetappVolumeGroupOracleVolumeBlock> Volume { get; set; } = new();

}
