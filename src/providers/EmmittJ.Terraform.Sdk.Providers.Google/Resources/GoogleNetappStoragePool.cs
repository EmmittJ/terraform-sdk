using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleNetappStoragePoolTimeoutsBlock : TerraformBlockBase
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
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_netapp_storage_pool resource.
/// </summary>
public partial class GoogleNetappStoragePool : TerraformResource
{
    public GoogleNetappStoragePool(string name) : base("google_netapp_storage_pool", name)
    {
    }

    /// <summary>
    /// Specifies the Active Directory policy to be used. Format: &#39;projects/{{project}}/locations/{{location}}/activeDirectories/{{name}}&#39;.
    /// The policy needs to be in the same location as the storage pool.
    /// </summary>
    [TerraformProperty("active_directory")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ActiveDirectory { get; set; }

    /// <summary>
    /// Optional. True if the storage pool supports Auto Tiering enabled volumes. Default is false.
    /// Auto-tiering can be enabled after storage pool creation but it can&#39;t be disabled once enabled.
    /// </summary>
    [TerraformProperty("allow_auto_tiering")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AllowAutoTiering { get; set; }

    /// <summary>
    /// Capacity of the storage pool (in GiB).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityGib is required")]
    [TerraformProperty("capacity_gib")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CapacityGib { get; set; }

    /// <summary>
    /// Optional. True if using Independent Scaling of capacity and performance (Hyperdisk). Default is false.
    /// </summary>
    [TerraformProperty("custom_performance_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> CustomPerformanceEnabled { get; set; }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Flag indicating that the hot-tier threshold will be auto-increased by 10% of the hot-tier when it hits 100%. Default is true.
    /// The increment will kick in only if the new size after increment is still less than or equal to storage pool size.
    /// </summary>
    [TerraformProperty("enable_hot_tier_auto_resize")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableHotTierAutoResize { get; set; }

    /// <summary>
    /// Total hot tier capacity for the Storage Pool. It is applicable only to Flex service level.
    /// It should be less than the minimum storage pool size and cannot be more than the current storage pool size. It cannot be decreased once set.
    /// </summary>
    [TerraformProperty("hot_tier_size_gib")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HotTierSizeGib { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Specifies the CMEK policy to be used for volume encryption. Format: &#39;projects/{{project}}/locations/{{location}}/kmsConfigs/{{name}}&#39;.
    /// The policy needs to be in the same location as the storage pool.
    /// </summary>
    [TerraformProperty("kms_config")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsConfig { get; set; }

    /// <summary>
    /// Labels as key value pairs. Example: &#39;{ &amp;quot;owner&amp;quot;: &amp;quot;Bob&amp;quot;, &amp;quot;department&amp;quot;: &amp;quot;finance&amp;quot;, &amp;quot;purpose&amp;quot;: &amp;quot;testing&amp;quot; }&#39;.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// When enabled, the volumes uses Active Directory as LDAP name service for UID/GID lookups. Required to enable extended group support for NFSv3,
    /// using security identifiers for NFSv4.1 or principal names for kerberized NFSv4.1.
    /// </summary>
    [TerraformProperty("ldap_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? LdapEnabled { get; set; }

    /// <summary>
    /// Name of the location. For zonal Flex pools specify a zone name, in all other cases a region name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The resource name of the storage pool. Needs to be unique per location/region.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// VPC network name with format: &#39;projects/{{project}}/global/networks/{{network}}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    [TerraformProperty("network")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Network { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// QoS (Quality of Service) type of the storage pool.
    /// Possible values are: AUTO, MANUAL. Possible values: [&amp;quot;QOS_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;AUTO&amp;quot;, &amp;quot;MANUAL&amp;quot;]
    /// </summary>
    [TerraformProperty("qos_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> QosType { get; set; }

    /// <summary>
    /// Specifies the replica zone for regional Flex pools. &#39;zone&#39; and &#39;replica_zone&#39; values can be swapped to initiate a
    /// [zone switch](https://cloud.google.com/netapp/volumes/docs/configure-and-use/storage-pools/edit-or-delete-storage-pool#switch_active_and_replica_zones).
    /// </summary>
    [TerraformProperty("replica_zone")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ReplicaZone { get; set; }

    /// <summary>
    /// Service level of the storage pool. Possible values: [&amp;quot;PREMIUM&amp;quot;, &amp;quot;EXTREME&amp;quot;, &amp;quot;STANDARD&amp;quot;, &amp;quot;FLEX&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceLevel is required")]
    [TerraformProperty("service_level")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServiceLevel { get; set; }

    /// <summary>
    /// Optional. Custom Performance Total IOPS of the pool If not provided, it will be calculated based on the totalThroughputMibps
    /// </summary>
    [TerraformProperty("total_iops")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> TotalIops { get; set; }

    /// <summary>
    /// Optional. Custom Performance Total Throughput of the pool (in MiB/s).
    /// </summary>
    [TerraformProperty("total_throughput_mibps")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> TotalThroughputMibps { get; set; }

    /// <summary>
    /// Type of the storage pool.
    /// This field is used to control whether the pool supports FILE based volumes only or UNIFIED (both FILE and BLOCK) volumes.
    /// If not specified during creation, it defaults to FILE. Possible values: [&amp;quot;STORAGE_POOL_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;FILE&amp;quot;, &amp;quot;UNIFIED&amp;quot;]
    /// </summary>
    [TerraformProperty("type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// Specifies the active zone for regional Flex pools. &#39;zone&#39; and &#39;replica_zone&#39; values can be swapped to initiate a
    /// [zone switch](https://cloud.google.com/netapp/volumes/docs/configure-and-use/storage-pools/edit-or-delete-storage-pool#switch_active_and_replica_zones).
    /// If you want to create a zonal Flex pool, specify a zone name for &#39;location&#39; and omit &#39;zone&#39;.
    /// </summary>
    [TerraformProperty("zone")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Zone { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleNetappStoragePoolTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Available throughput of the storage pool (in MiB/s).
    /// </summary>
    [TerraformProperty("available_throughput_mibps")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> AvailableThroughputMibps { get; }

    /// <summary>
    /// Total cold tier data rounded down to the nearest GiB used by the storage pool.
    /// </summary>
    [TerraformProperty("cold_tier_size_used_gib")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ColdTierSizeUsedGib { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// Reports if volumes in the pool are encrypted using a Google-managed encryption key or CMEK.
    /// </summary>
    [TerraformProperty("encryption_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EncryptionType { get; }

    /// <summary>
    /// Total hot tier data rounded down to the nearest GiB used by the storage pool.
    /// </summary>
    [TerraformProperty("hot_tier_size_used_gib")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> HotTierSizeUsedGib { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// Size allocated to volumes in the storage pool (in GiB).
    /// </summary>
    [TerraformProperty("volume_capacity_gib")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VolumeCapacityGib { get; }

    /// <summary>
    /// Number of volume in the storage pool.
    /// </summary>
    [TerraformProperty("volume_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> VolumeCount { get; }

}
