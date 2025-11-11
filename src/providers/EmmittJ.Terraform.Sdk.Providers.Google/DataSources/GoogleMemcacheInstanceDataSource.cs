using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_memcache_instance.
/// </summary>
public partial class GoogleMemcacheInstanceDataSource : TerraformDataSource
{
    public GoogleMemcacheInstanceDataSource(string name) : base("google_memcache_instance", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The resource name of the instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The region of the Memcache instance. If it is not provided, the provider region is used.
    /// </summary>
    [TerraformProperty("region")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Region { get; set; }

    /// <summary>
    /// The full name of the GCE network to connect the instance to.  If not provided,
    /// &#39;default&#39; will be used.
    /// </summary>
    [TerraformProperty("authorized_network")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AuthorizedNetwork { get; }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the instance.
    /// When a &#39;terraform destroy&#39; or &#39;terraform apply&#39; would delete the instance,
    /// the command will fail if this field is not set to false in Terraform state.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the instance will fail.
    /// When the field is set to false, deleting the instance is allowed.
    /// </summary>
    [TerraformProperty("deletion_protection")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> DeletionProtection { get; }

    /// <summary>
    /// Endpoint for Discovery API
    /// </summary>
    [TerraformProperty("discovery_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DiscoveryEndpoint { get; }

    /// <summary>
    /// A user-visible name for the instance.
    /// </summary>
    [TerraformProperty("display_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DisplayName { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// Resource labels to represent user-provided metadata.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Labels { get; }

    /// <summary>
    /// Maintenance policy for an instance.
    /// </summary>
    [TerraformProperty("maintenance_policy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> MaintenancePolicy { get; }

    /// <summary>
    /// Output only. Published maintenance schedule.
    /// </summary>
    [TerraformProperty("maintenance_schedule")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> MaintenanceSchedule { get; }

    /// <summary>
    /// The full version of memcached server running on this instance.
    /// </summary>
    [TerraformProperty("memcache_full_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> MemcacheFullVersion { get; }

    /// <summary>
    /// Additional information about the instance state, if available.
    /// </summary>
    [TerraformProperty("memcache_nodes")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> MemcacheNodes { get; }

    /// <summary>
    /// User-specified parameters for this memcache instance.
    /// </summary>
    [TerraformProperty("memcache_parameters")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> MemcacheParameters { get; }

    /// <summary>
    /// The major version of Memcached software. If not provided, latest supported version will be used.
    /// Currently the latest supported major version is MEMCACHE_1_5. The minor version will be automatically
    /// determined by our system based on the latest supported minor version. Default value: &amp;quot;MEMCACHE_1_5&amp;quot; Possible values: [&amp;quot;MEMCACHE_1_5&amp;quot;, &amp;quot;MEMCACHE_1_6_15&amp;quot;]
    /// </summary>
    [TerraformProperty("memcache_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> MemcacheVersion { get; }

    /// <summary>
    /// Configuration for memcache nodes.
    /// </summary>
    [TerraformProperty("node_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> NodeConfig { get; }

    /// <summary>
    /// Number of nodes in the memcache instance.
    /// </summary>
    [TerraformProperty("node_count")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> NodeCount { get; }

    /// <summary>
    /// Contains the name of allocated IP address ranges associated with
    /// the private service access connection for example, &amp;quot;test-default&amp;quot;
    /// associated with IP range 10.0.0.0/29.
    /// </summary>
    [TerraformProperty("reserved_ip_range_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> ReservedIpRangeId { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// Zones where memcache nodes should be provisioned.  If not
    /// provided, all zones will be used.
    /// </summary>
    [TerraformProperty("zones")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> Zones { get; }

}
