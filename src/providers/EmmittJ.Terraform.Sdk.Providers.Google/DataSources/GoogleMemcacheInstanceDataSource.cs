using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_memcache_instance.
/// </summary>
public class GoogleMemcacheInstanceDataSource : TerraformDataSource
{
    public GoogleMemcacheInstanceDataSource(string name) : base("google_memcache_instance", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The resource name of the instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The region of the Memcache instance. If it is not provided, the provider region is used.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Region { get; set; }

    /// <summary>
    /// The full name of the GCE network to connect the instance to.  If not provided,
    /// &#39;default&#39; will be used.
    /// </summary>
    [TerraformPropertyName("authorized_network")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AuthorizedNetwork => new TerraformReference(this, "authorized_network");

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// Whether Terraform will be prevented from destroying the instance.
    /// When a &#39;terraform destroy&#39; or &#39;terraform apply&#39; would delete the instance,
    /// the command will fail if this field is not set to false in Terraform state.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the instance will fail.
    /// When the field is set to false, deleting the instance is allowed.
    /// </summary>
    [TerraformPropertyName("deletion_protection")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> DeletionProtection => new TerraformReference(this, "deletion_protection");

    /// <summary>
    /// Endpoint for Discovery API
    /// </summary>
    [TerraformPropertyName("discovery_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DiscoveryEndpoint => new TerraformReference(this, "discovery_endpoint");

    /// <summary>
    /// A user-visible name for the instance.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DisplayName => new TerraformReference(this, "display_name");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// Resource labels to represent user-provided metadata.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Labels => new TerraformReference(this, "labels");

    /// <summary>
    /// Maintenance policy for an instance.
    /// </summary>
    [TerraformPropertyName("maintenance_policy")]
    // Output-only attribute - read-only reference
    public TerraformList<object> MaintenancePolicy => new TerraformReference(this, "maintenance_policy");

    /// <summary>
    /// Output only. Published maintenance schedule.
    /// </summary>
    [TerraformPropertyName("maintenance_schedule")]
    // Output-only attribute - read-only reference
    public TerraformList<object> MaintenanceSchedule => new TerraformReference(this, "maintenance_schedule");

    /// <summary>
    /// The full version of memcached server running on this instance.
    /// </summary>
    [TerraformPropertyName("memcache_full_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MemcacheFullVersion => new TerraformReference(this, "memcache_full_version");

    /// <summary>
    /// Additional information about the instance state, if available.
    /// </summary>
    [TerraformPropertyName("memcache_nodes")]
    // Output-only attribute - read-only reference
    public TerraformList<object> MemcacheNodes => new TerraformReference(this, "memcache_nodes");

    /// <summary>
    /// User-specified parameters for this memcache instance.
    /// </summary>
    [TerraformPropertyName("memcache_parameters")]
    // Output-only attribute - read-only reference
    public TerraformList<object> MemcacheParameters => new TerraformReference(this, "memcache_parameters");

    /// <summary>
    /// The major version of Memcached software. If not provided, latest supported version will be used.
    /// Currently the latest supported major version is MEMCACHE_1_5. The minor version will be automatically
    /// determined by our system based on the latest supported minor version. Default value: &amp;quot;MEMCACHE_1_5&amp;quot; Possible values: [&amp;quot;MEMCACHE_1_5&amp;quot;, &amp;quot;MEMCACHE_1_6_15&amp;quot;]
    /// </summary>
    [TerraformPropertyName("memcache_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MemcacheVersion => new TerraformReference(this, "memcache_version");

    /// <summary>
    /// Configuration for memcache nodes.
    /// </summary>
    [TerraformPropertyName("node_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> NodeConfig => new TerraformReference(this, "node_config");

    /// <summary>
    /// Number of nodes in the memcache instance.
    /// </summary>
    [TerraformPropertyName("node_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> NodeCount => new TerraformReference(this, "node_count");

    /// <summary>
    /// Contains the name of allocated IP address ranges associated with
    /// the private service access connection for example, &amp;quot;test-default&amp;quot;
    /// associated with IP range 10.0.0.0/29.
    /// </summary>
    [TerraformPropertyName("reserved_ip_range_id")]
    // Output-only attribute - read-only reference
    public TerraformList<string> ReservedIpRangeId => new TerraformReference(this, "reserved_ip_range_id");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

    /// <summary>
    /// Zones where memcache nodes should be provisioned.  If not
    /// provided, all zones will be used.
    /// </summary>
    [TerraformPropertyName("zones")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> Zones => new TerraformReference(this, "zones");

}
