using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetappStoragePoolTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_netapp_storage_pool resource.
/// </summary>
public class GoogleNetappStoragePool : TerraformResource
{
    public GoogleNetappStoragePool(string name) : base("google_netapp_storage_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("available_throughput_mibps");
        SetOutput("cold_tier_size_used_gib");
        SetOutput("effective_labels");
        SetOutput("encryption_type");
        SetOutput("hot_tier_size_used_gib");
        SetOutput("terraform_labels");
        SetOutput("volume_capacity_gib");
        SetOutput("volume_count");
        SetOutput("active_directory");
        SetOutput("allow_auto_tiering");
        SetOutput("capacity_gib");
        SetOutput("custom_performance_enabled");
        SetOutput("description");
        SetOutput("enable_hot_tier_auto_resize");
        SetOutput("hot_tier_size_gib");
        SetOutput("id");
        SetOutput("kms_config");
        SetOutput("labels");
        SetOutput("ldap_enabled");
        SetOutput("location");
        SetOutput("name");
        SetOutput("network");
        SetOutput("project");
        SetOutput("qos_type");
        SetOutput("replica_zone");
        SetOutput("service_level");
        SetOutput("total_iops");
        SetOutput("total_throughput_mibps");
        SetOutput("type");
        SetOutput("zone");
    }

    /// <summary>
    /// Specifies the Active Directory policy to be used. Format: &#39;projects/{{project}}/locations/{{location}}/activeDirectories/{{name}}&#39;.
    /// The policy needs to be in the same location as the storage pool.
    /// </summary>
    public TerraformProperty<string> ActiveDirectory
    {
        get => GetRequiredOutput<TerraformProperty<string>>("active_directory");
        set => SetProperty("active_directory", value);
    }

    /// <summary>
    /// Optional. True if the storage pool supports Auto Tiering enabled volumes. Default is false.
    /// Auto-tiering can be enabled after storage pool creation but it can&#39;t be disabled once enabled.
    /// </summary>
    public TerraformProperty<bool> AllowAutoTiering
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("allow_auto_tiering");
        set => SetProperty("allow_auto_tiering", value);
    }

    /// <summary>
    /// Capacity of the storage pool (in GiB).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityGib is required")]
    public required TerraformProperty<string> CapacityGib
    {
        get => GetRequiredOutput<TerraformProperty<string>>("capacity_gib");
        set => SetProperty("capacity_gib", value);
    }

    /// <summary>
    /// Optional. True if using Independent Scaling of capacity and performance (Hyperdisk). Default is false.
    /// </summary>
    public TerraformProperty<bool> CustomPerformanceEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("custom_performance_enabled");
        set => SetProperty("custom_performance_enabled", value);
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// Flag indicating that the hot-tier threshold will be auto-increased by 10% of the hot-tier when it hits 100%. Default is true.
    /// The increment will kick in only if the new size after increment is still less than or equal to storage pool size.
    /// </summary>
    public TerraformProperty<bool> EnableHotTierAutoResize
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_hot_tier_auto_resize");
        set => SetProperty("enable_hot_tier_auto_resize", value);
    }

    /// <summary>
    /// Total hot tier capacity for the Storage Pool. It is applicable only to Flex service level.
    /// It should be less than the minimum storage pool size and cannot be more than the current storage pool size. It cannot be decreased once set.
    /// </summary>
    public TerraformProperty<string> HotTierSizeGib
    {
        get => GetRequiredOutput<TerraformProperty<string>>("hot_tier_size_gib");
        set => SetProperty("hot_tier_size_gib", value);
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
    /// Specifies the CMEK policy to be used for volume encryption. Format: &#39;projects/{{project}}/locations/{{location}}/kmsConfigs/{{name}}&#39;.
    /// The policy needs to be in the same location as the storage pool.
    /// </summary>
    public TerraformProperty<string> KmsConfig
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_config");
        set => SetProperty("kms_config", value);
    }

    /// <summary>
    /// Labels as key value pairs. Example: &#39;{ &amp;quot;owner&amp;quot;: &amp;quot;Bob&amp;quot;, &amp;quot;department&amp;quot;: &amp;quot;finance&amp;quot;, &amp;quot;purpose&amp;quot;: &amp;quot;testing&amp;quot; }&#39;.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// When enabled, the volumes uses Active Directory as LDAP name service for UID/GID lookups. Required to enable extended group support for NFSv3,
    /// using security identifiers for NFSv4.1 or principal names for kerberized NFSv4.1.
    /// </summary>
    public TerraformProperty<bool> LdapEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("ldap_enabled");
        set => SetProperty("ldap_enabled", value);
    }

    /// <summary>
    /// Name of the location. For zonal Flex pools specify a zone name, in all other cases a region name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The resource name of the storage pool. Needs to be unique per location/region.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// VPC network name with format: &#39;projects/{{project}}/global/networks/{{network}}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformProperty<string> Network
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network");
        set => SetProperty("network", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// QoS (Quality of Service) type of the storage pool.
    /// Possible values are: AUTO, MANUAL. Possible values: [&amp;quot;QOS_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;AUTO&amp;quot;, &amp;quot;MANUAL&amp;quot;]
    /// </summary>
    public TerraformProperty<string> QosType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("qos_type");
        set => SetProperty("qos_type", value);
    }

    /// <summary>
    /// Specifies the replica zone for regional Flex pools. &#39;zone&#39; and &#39;replica_zone&#39; values can be swapped to initiate a
    /// [zone switch](https://cloud.google.com/netapp/volumes/docs/configure-and-use/storage-pools/edit-or-delete-storage-pool#switch_active_and_replica_zones).
    /// </summary>
    public TerraformProperty<string> ReplicaZone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("replica_zone");
        set => SetProperty("replica_zone", value);
    }

    /// <summary>
    /// Service level of the storage pool. Possible values: [&amp;quot;PREMIUM&amp;quot;, &amp;quot;EXTREME&amp;quot;, &amp;quot;STANDARD&amp;quot;, &amp;quot;FLEX&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceLevel is required")]
    public required TerraformProperty<string> ServiceLevel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_level");
        set => SetProperty("service_level", value);
    }

    /// <summary>
    /// Optional. Custom Performance Total IOPS of the pool If not provided, it will be calculated based on the totalThroughputMibps
    /// </summary>
    public TerraformProperty<string> TotalIops
    {
        get => GetRequiredOutput<TerraformProperty<string>>("total_iops");
        set => SetProperty("total_iops", value);
    }

    /// <summary>
    /// Optional. Custom Performance Total Throughput of the pool (in MiB/s).
    /// </summary>
    public TerraformProperty<string> TotalThroughputMibps
    {
        get => GetRequiredOutput<TerraformProperty<string>>("total_throughput_mibps");
        set => SetProperty("total_throughput_mibps", value);
    }

    /// <summary>
    /// Type of the storage pool.
    /// This field is used to control whether the pool supports FILE based volumes only or UNIFIED (both FILE and BLOCK) volumes.
    /// If not specified during creation, it defaults to FILE. Possible values: [&amp;quot;STORAGE_POOL_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;FILE&amp;quot;, &amp;quot;UNIFIED&amp;quot;]
    /// </summary>
    public TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// Specifies the active zone for regional Flex pools. &#39;zone&#39; and &#39;replica_zone&#39; values can be swapped to initiate a
    /// [zone switch](https://cloud.google.com/netapp/volumes/docs/configure-and-use/storage-pools/edit-or-delete-storage-pool#switch_active_and_replica_zones).
    /// If you want to create a zonal Flex pool, specify a zone name for &#39;location&#39; and omit &#39;zone&#39;.
    /// </summary>
    public TerraformProperty<string> Zone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("zone");
        set => SetProperty("zone", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleNetappStoragePoolTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Available throughput of the storage pool (in MiB/s).
    /// </summary>
    public TerraformExpression AvailableThroughputMibps => this["available_throughput_mibps"];

    /// <summary>
    /// Total cold tier data rounded down to the nearest GiB used by the storage pool.
    /// </summary>
    public TerraformExpression ColdTierSizeUsedGib => this["cold_tier_size_used_gib"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Reports if volumes in the pool are encrypted using a Google-managed encryption key or CMEK.
    /// </summary>
    public TerraformExpression EncryptionType => this["encryption_type"];

    /// <summary>
    /// Total hot tier data rounded down to the nearest GiB used by the storage pool.
    /// </summary>
    public TerraformExpression HotTierSizeUsedGib => this["hot_tier_size_used_gib"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Size allocated to volumes in the storage pool (in GiB).
    /// </summary>
    public TerraformExpression VolumeCapacityGib => this["volume_capacity_gib"];

    /// <summary>
    /// Number of volume in the storage pool.
    /// </summary>
    public TerraformExpression VolumeCount => this["volume_count"];

}
