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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The resource name of the instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// The region of the Memcache instance. If it is not provided, the provider region is used.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Region { get; set; }

    /// <summary>
    /// The full name of the GCE network to connect the instance to.  If not provided,
    /// &#39;default&#39; will be used.
    /// </summary>
    [TerraformPropertyName("authorized_network")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AuthorizedNetwork => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "authorized_network");

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

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
    public TerraformProperty<TerraformProperty<bool>> DeletionProtection => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "deletion_protection");

    /// <summary>
    /// Endpoint for Discovery API
    /// </summary>
    [TerraformPropertyName("discovery_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DiscoveryEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "discovery_endpoint");

    /// <summary>
    /// A user-visible name for the instance.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DisplayName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// Resource labels to represent user-provided metadata.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Labels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "labels");

    /// <summary>
    /// Maintenance policy for an instance.
    /// </summary>
    [TerraformPropertyName("maintenance_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> MaintenancePolicy => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "maintenance_policy");

    /// <summary>
    /// Output only. Published maintenance schedule.
    /// </summary>
    [TerraformPropertyName("maintenance_schedule")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> MaintenanceSchedule => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "maintenance_schedule");

    /// <summary>
    /// The full version of memcached server running on this instance.
    /// </summary>
    [TerraformPropertyName("memcache_full_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MemcacheFullVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "memcache_full_version");

    /// <summary>
    /// Additional information about the instance state, if available.
    /// </summary>
    [TerraformPropertyName("memcache_nodes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> MemcacheNodes => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "memcache_nodes");

    /// <summary>
    /// User-specified parameters for this memcache instance.
    /// </summary>
    [TerraformPropertyName("memcache_parameters")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> MemcacheParameters => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "memcache_parameters");

    /// <summary>
    /// The major version of Memcached software. If not provided, latest supported version will be used.
    /// Currently the latest supported major version is MEMCACHE_1_5. The minor version will be automatically
    /// determined by our system based on the latest supported minor version. Default value: &amp;quot;MEMCACHE_1_5&amp;quot; Possible values: [&amp;quot;MEMCACHE_1_5&amp;quot;, &amp;quot;MEMCACHE_1_6_15&amp;quot;]
    /// </summary>
    [TerraformPropertyName("memcache_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MemcacheVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "memcache_version");

    /// <summary>
    /// Configuration for memcache nodes.
    /// </summary>
    [TerraformPropertyName("node_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> NodeConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "node_config");

    /// <summary>
    /// Number of nodes in the memcache instance.
    /// </summary>
    [TerraformPropertyName("node_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> NodeCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "node_count");

    /// <summary>
    /// Contains the name of allocated IP address ranges associated with
    /// the private service access connection for example, &amp;quot;test-default&amp;quot;
    /// associated with IP range 10.0.0.0/29.
    /// </summary>
    [TerraformPropertyName("reserved_ip_range_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ReservedIpRangeId => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "reserved_ip_range_id");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

    /// <summary>
    /// Zones where memcache nodes should be provisioned.  If not
    /// provided, all zones will be used.
    /// </summary>
    [TerraformPropertyName("zones")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> Zones => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "zones");

}
