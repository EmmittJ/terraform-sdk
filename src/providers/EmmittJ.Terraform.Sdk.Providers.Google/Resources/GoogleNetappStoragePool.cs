using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleNetappStoragePool.
/// Nesting mode: single
/// </summary>
public class GoogleNetappStoragePoolTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_netapp_storage_pool Terraform resource.
/// Manages a google_netapp_storage_pool resource.
/// </summary>
public partial class GoogleNetappStoragePool(string name) : TerraformResource("google_netapp_storage_pool", name)
{
    /// <summary>
    /// Specifies the Active Directory policy to be used. Format: &#39;projects/{{project}}/locations/{{location}}/activeDirectories/{{name}}&#39;.
    /// The policy needs to be in the same location as the storage pool.
    /// </summary>
    public TerraformValue<string>? ActiveDirectory
    {
        get => GetArgument<TerraformValue<string>>("active_directory");
        set => SetArgument("active_directory", value);
    }

    /// <summary>
    /// Optional. True if the storage pool supports Auto Tiering enabled volumes. Default is false.
    /// Auto-tiering can be enabled after storage pool creation but it can&#39;t be disabled once enabled.
    /// </summary>
    public TerraformValue<bool>? AllowAutoTiering
    {
        get => GetArgument<TerraformValue<bool>>("allow_auto_tiering");
        set => SetArgument("allow_auto_tiering", value);
    }

    /// <summary>
    /// Capacity of the storage pool (in GiB).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityGib is required")]
    public required TerraformValue<string> CapacityGib
    {
        get => GetRequiredArgument<TerraformValue<string>>("capacity_gib");
        set => SetArgument("capacity_gib", value);
    }

    /// <summary>
    /// Optional. True if using Independent Scaling of capacity and performance (Hyperdisk). Default is false.
    /// </summary>
    public TerraformValue<bool> CustomPerformanceEnabled
    {
        get => GetArgument<TerraformValue<bool>>("custom_performance_enabled") ?? AsReference("custom_performance_enabled");
        set => SetArgument("custom_performance_enabled", value);
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Flag indicating that the hot-tier threshold will be auto-increased by 10% of the hot-tier when it hits 100%. Default is true.
    /// The increment will kick in only if the new size after increment is still less than or equal to storage pool size.
    /// </summary>
    public TerraformValue<bool>? EnableHotTierAutoResize
    {
        get => GetArgument<TerraformValue<bool>>("enable_hot_tier_auto_resize");
        set => SetArgument("enable_hot_tier_auto_resize", value);
    }

    /// <summary>
    /// Total hot tier capacity for the Storage Pool. It is applicable only to Flex service level.
    /// It should be less than the minimum storage pool size and cannot be more than the current storage pool size. It cannot be decreased once set.
    /// </summary>
    public TerraformValue<string>? HotTierSizeGib
    {
        get => GetArgument<TerraformValue<string>>("hot_tier_size_gib");
        set => SetArgument("hot_tier_size_gib", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Specifies the CMEK policy to be used for volume encryption. Format: &#39;projects/{{project}}/locations/{{location}}/kmsConfigs/{{name}}&#39;.
    /// The policy needs to be in the same location as the storage pool.
    /// </summary>
    public TerraformValue<string>? KmsConfig
    {
        get => GetArgument<TerraformValue<string>>("kms_config");
        set => SetArgument("kms_config", value);
    }

    /// <summary>
    /// Labels as key value pairs. Example: &#39;{ &amp;quot;owner&amp;quot;: &amp;quot;Bob&amp;quot;, &amp;quot;department&amp;quot;: &amp;quot;finance&amp;quot;, &amp;quot;purpose&amp;quot;: &amp;quot;testing&amp;quot; }&#39;.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// When enabled, the volumes uses Active Directory as LDAP name service for UID/GID lookups. Required to enable extended group support for NFSv3,
    /// using security identifiers for NFSv4.1 or principal names for kerberized NFSv4.1.
    /// </summary>
    public TerraformValue<bool>? LdapEnabled
    {
        get => GetArgument<TerraformValue<bool>>("ldap_enabled");
        set => SetArgument("ldap_enabled", value);
    }

    /// <summary>
    /// Name of the location. For zonal Flex pools specify a zone name, in all other cases a region name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The resource name of the storage pool. Needs to be unique per location/region.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// VPC network name with format: &#39;projects/{{project}}/global/networks/{{network}}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformValue<string> Network
    {
        get => GetRequiredArgument<TerraformValue<string>>("network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// QoS (Quality of Service) type of the storage pool.
    /// Possible values are: AUTO, MANUAL. Possible values: [&amp;quot;QOS_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;AUTO&amp;quot;, &amp;quot;MANUAL&amp;quot;]
    /// </summary>
    public TerraformValue<string> QosType
    {
        get => GetArgument<TerraformValue<string>>("qos_type") ?? AsReference("qos_type");
        set => SetArgument("qos_type", value);
    }

    /// <summary>
    /// Specifies the replica zone for regional Flex pools. &#39;zone&#39; and &#39;replica_zone&#39; values can be swapped to initiate a
    /// [zone switch](https://cloud.google.com/netapp/volumes/docs/configure-and-use/storage-pools/edit-or-delete-storage-pool#switch_active_and_replica_zones).
    /// </summary>
    public TerraformValue<string>? ReplicaZone
    {
        get => GetArgument<TerraformValue<string>>("replica_zone");
        set => SetArgument("replica_zone", value);
    }

    /// <summary>
    /// Service level of the storage pool. Possible values: [&amp;quot;PREMIUM&amp;quot;, &amp;quot;EXTREME&amp;quot;, &amp;quot;STANDARD&amp;quot;, &amp;quot;FLEX&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceLevel is required")]
    public required TerraformValue<string> ServiceLevel
    {
        get => GetRequiredArgument<TerraformValue<string>>("service_level");
        set => SetArgument("service_level", value);
    }

    /// <summary>
    /// Optional. Custom Performance Total IOPS of the pool If not provided, it will be calculated based on the totalThroughputMibps
    /// </summary>
    public TerraformValue<string> TotalIops
    {
        get => GetArgument<TerraformValue<string>>("total_iops") ?? AsReference("total_iops");
        set => SetArgument("total_iops", value);
    }

    /// <summary>
    /// Optional. Custom Performance Total Throughput of the pool (in MiB/s).
    /// </summary>
    public TerraformValue<string> TotalThroughputMibps
    {
        get => GetArgument<TerraformValue<string>>("total_throughput_mibps") ?? AsReference("total_throughput_mibps");
        set => SetArgument("total_throughput_mibps", value);
    }

    /// <summary>
    /// Type of the storage pool.
    /// This field is used to control whether the pool supports FILE based volumes only or UNIFIED (both FILE and BLOCK) volumes.
    /// If not specified during creation, it defaults to FILE. Possible values: [&amp;quot;STORAGE_POOL_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;FILE&amp;quot;, &amp;quot;UNIFIED&amp;quot;]
    /// </summary>
    public TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type") ?? AsReference("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Specifies the active zone for regional Flex pools. &#39;zone&#39; and &#39;replica_zone&#39; values can be swapped to initiate a
    /// [zone switch](https://cloud.google.com/netapp/volumes/docs/configure-and-use/storage-pools/edit-or-delete-storage-pool#switch_active_and_replica_zones).
    /// If you want to create a zonal Flex pool, specify a zone name for &#39;location&#39; and omit &#39;zone&#39;.
    /// </summary>
    public TerraformValue<string> Zone
    {
        get => GetArgument<TerraformValue<string>>("zone") ?? AsReference("zone");
        set => SetArgument("zone", value);
    }

    /// <summary>
    /// Available throughput of the storage pool (in MiB/s).
    /// </summary>
    public TerraformValue<double> AvailableThroughputMibps
        => AsReference("available_throughput_mibps");

    /// <summary>
    /// Total cold tier data rounded down to the nearest GiB used by the storage pool.
    /// </summary>
    public TerraformValue<string> ColdTierSizeUsedGib
        => AsReference("cold_tier_size_used_gib");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// Reports if volumes in the pool are encrypted using a Google-managed encryption key or CMEK.
    /// </summary>
    public TerraformValue<string> EncryptionType
        => AsReference("encryption_type");

    /// <summary>
    /// Total hot tier data rounded down to the nearest GiB used by the storage pool.
    /// </summary>
    public TerraformValue<string> HotTierSizeUsedGib
        => AsReference("hot_tier_size_used_gib");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// Size allocated to volumes in the storage pool (in GiB).
    /// </summary>
    public TerraformValue<string> VolumeCapacityGib
        => AsReference("volume_capacity_gib");

    /// <summary>
    /// Number of volume in the storage pool.
    /// </summary>
    public TerraformValue<double> VolumeCount
        => AsReference("volume_count");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleNetappStoragePoolTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleNetappStoragePoolTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
