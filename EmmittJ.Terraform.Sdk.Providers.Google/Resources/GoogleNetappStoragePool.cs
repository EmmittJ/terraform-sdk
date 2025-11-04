using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
        this.DeclareOutput("available_throughput_mibps");
        this.DeclareOutput("cold_tier_size_used_gib");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("encryption_type");
        this.DeclareOutput("hot_tier_size_used_gib");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("volume_capacity_gib");
        this.DeclareOutput("volume_count");
    }

    /// <summary>
    /// Specifies the Active Directory policy to be used. Format: &#39;projects/{{project}}/locations/{{location}}/activeDirectories/{{name}}&#39;.
    /// The policy needs to be in the same location as the storage pool.
    /// </summary>
    public string? ActiveDirectory
    {
        get => GetProperty<TerraformLiteralProperty<string>>("active_directory")?.Value;
        set => this.WithProperty("active_directory", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Optional. True if the storage pool supports Auto Tiering enabled volumes. Default is false.
    /// Auto-tiering can be enabled after storage pool creation but it can&#39;t be disabled once enabled.
    /// </summary>
    public bool? AllowAutoTiering
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_auto_tiering")?.Value;
        set => this.WithProperty("allow_auto_tiering", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Capacity of the storage pool (in GiB).
    /// </summary>
    public string? CapacityGib
    {
        get => GetProperty<TerraformLiteralProperty<string>>("capacity_gib")?.Value;
        set => this.WithProperty("capacity_gib", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Optional. True if using Independent Scaling of capacity and performance (Hyperdisk). Default is false.
    /// </summary>
    public bool? CustomPerformanceEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("custom_performance_enabled")?.Value;
        set => this.WithProperty("custom_performance_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Flag indicating that the hot-tier threshold will be auto-increased by 10% of the hot-tier when it hits 100%. Default is true.
    /// The increment will kick in only if the new size after increment is still less than or equal to storage pool size.
    /// </summary>
    public bool? EnableHotTierAutoResize
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_hot_tier_auto_resize")?.Value;
        set => this.WithProperty("enable_hot_tier_auto_resize", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Total hot tier capacity for the Storage Pool. It is applicable only to Flex service level.
    /// It should be less than the minimum storage pool size and cannot be more than the current storage pool size. It cannot be decreased once set.
    /// </summary>
    public string? HotTierSizeGib
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hot_tier_size_gib")?.Value;
        set => this.WithProperty("hot_tier_size_gib", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Specifies the CMEK policy to be used for volume encryption. Format: &#39;projects/{{project}}/locations/{{location}}/kmsConfigs/{{name}}&#39;.
    /// The policy needs to be in the same location as the storage pool.
    /// </summary>
    public string? KmsConfig
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_config")?.Value;
        set => this.WithProperty("kms_config", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Labels as key value pairs. Example: &#39;{ &amp;quot;owner&amp;quot;: &amp;quot;Bob&amp;quot;, &amp;quot;department&amp;quot;: &amp;quot;finance&amp;quot;, &amp;quot;purpose&amp;quot;: &amp;quot;testing&amp;quot; }&#39;.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, string>? Labels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("labels")?.Value;
        set => this.WithProperty("labels", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// When enabled, the volumes uses Active Directory as LDAP name service for UID/GID lookups. Required to enable extended group support for NFSv3,
    /// using security identifiers for NFSv4.1 or principal names for kerberized NFSv4.1.
    /// </summary>
    public bool? LdapEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ldap_enabled")?.Value;
        set => this.WithProperty("ldap_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Name of the location. For zonal Flex pools specify a zone name, in all other cases a region name.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource name of the storage pool. Needs to be unique per location/region.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// VPC network name with format: &#39;projects/{{project}}/global/networks/{{network}}&#39;
    /// </summary>
    public string? Network
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network")?.Value;
        set => this.WithProperty("network", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// QoS (Quality of Service) type of the storage pool.
    /// Possible values are: AUTO, MANUAL. Possible values: [&amp;quot;QOS_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;AUTO&amp;quot;, &amp;quot;MANUAL&amp;quot;]
    /// </summary>
    public string? QosType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("qos_type")?.Value;
        set => this.WithProperty("qos_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Specifies the replica zone for regional Flex pools. &#39;zone&#39; and &#39;replica_zone&#39; values can be swapped to initiate a
    /// [zone switch](https://cloud.google.com/netapp/volumes/docs/configure-and-use/storage-pools/edit-or-delete-storage-pool#switch_active_and_replica_zones).
    /// </summary>
    public string? ReplicaZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("replica_zone")?.Value;
        set => this.WithProperty("replica_zone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Service level of the storage pool. Possible values: [&amp;quot;PREMIUM&amp;quot;, &amp;quot;EXTREME&amp;quot;, &amp;quot;STANDARD&amp;quot;, &amp;quot;FLEX&amp;quot;]
    /// </summary>
    public string? ServiceLevel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_level")?.Value;
        set => this.WithProperty("service_level", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Optional. Custom Performance Total IOPS of the pool If not provided, it will be calculated based on the totalThroughputMibps
    /// </summary>
    public string? TotalIops
    {
        get => GetProperty<TerraformLiteralProperty<string>>("total_iops")?.Value;
        set => this.WithProperty("total_iops", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Optional. Custom Performance Total Throughput of the pool (in MiB/s).
    /// </summary>
    public string? TotalThroughputMibps
    {
        get => GetProperty<TerraformLiteralProperty<string>>("total_throughput_mibps")?.Value;
        set => this.WithProperty("total_throughput_mibps", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Specifies the active zone for regional Flex pools. &#39;zone&#39; and &#39;replica_zone&#39; values can be swapped to initiate a
    /// [zone switch](https://cloud.google.com/netapp/volumes/docs/configure-and-use/storage-pools/edit-or-delete-storage-pool#switch_active_and_replica_zones).
    /// If you want to create a zonal Flex pool, specify a zone name for &#39;location&#39; and omit &#39;zone&#39;.
    /// </summary>
    public string? Zone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("zone")?.Value;
        set => this.WithProperty("zone", value == null ? null : new TerraformLiteralProperty<string>(value));
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
