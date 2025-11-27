using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_memcache_instance Terraform data source.
/// Retrieves information about a google_memcache_instance.
/// </summary>
public partial class GoogleMemcacheInstanceDataSource(string name) : TerraformDataSource("google_memcache_instance", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The resource name of the instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The region of the Memcache instance. If it is not provided, the provider region is used.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The full name of the GCE network to connect the instance to.  If not provided,
    /// &#39;default&#39; will be used.
    /// </summary>
    public TerraformValue<string> AuthorizedNetwork
    {
        get => new TerraformReference<string>(this, "authorized_network");
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the instance.
    /// When a &#39;terraform destroy&#39; or &#39;terraform apply&#39; would delete the instance,
    /// the command will fail if this field is not set to false in Terraform state.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the instance will fail.
    /// When the field is set to false, deleting the instance is allowed.
    /// </summary>
    public TerraformValue<bool> DeletionProtection
    {
        get => new TerraformReference<bool>(this, "deletion_protection");
    }

    /// <summary>
    /// Endpoint for Discovery API
    /// </summary>
    public TerraformValue<string> DiscoveryEndpoint
    {
        get => new TerraformReference<string>(this, "discovery_endpoint");
    }

    /// <summary>
    /// A user-visible name for the instance.
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Resource labels to represent user-provided metadata.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string> Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Maintenance policy for an instance.
    /// </summary>
    public TerraformList<TerraformMap<object>> MaintenancePolicy
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "maintenance_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// Output only. Published maintenance schedule.
    /// </summary>
    public TerraformList<TerraformMap<object>> MaintenanceSchedule
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "maintenance_schedule").ResolveNodes(ctx));
    }

    /// <summary>
    /// The full version of memcached server running on this instance.
    /// </summary>
    public TerraformValue<string> MemcacheFullVersion
    {
        get => new TerraformReference<string>(this, "memcache_full_version");
    }

    /// <summary>
    /// Additional information about the instance state, if available.
    /// </summary>
    public TerraformList<TerraformMap<object>> MemcacheNodes
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "memcache_nodes").ResolveNodes(ctx));
    }

    /// <summary>
    /// User-specified parameters for this memcache instance.
    /// </summary>
    public TerraformList<TerraformMap<object>> MemcacheParameters
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "memcache_parameters").ResolveNodes(ctx));
    }

    /// <summary>
    /// The major version of Memcached software. If not provided, latest supported version will be used.
    /// Currently the latest supported major version is MEMCACHE_1_5. The minor version will be automatically
    /// determined by our system based on the latest supported minor version. Default value: &amp;quot;MEMCACHE_1_5&amp;quot; Possible values: [&amp;quot;MEMCACHE_1_5&amp;quot;, &amp;quot;MEMCACHE_1_6_15&amp;quot;]
    /// </summary>
    public TerraformValue<string> MemcacheVersion
    {
        get => new TerraformReference<string>(this, "memcache_version");
    }

    /// <summary>
    /// Configuration for memcache nodes.
    /// </summary>
    public TerraformList<TerraformMap<object>> NodeConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "node_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// Number of nodes in the memcache instance.
    /// </summary>
    public TerraformValue<double> NodeCount
    {
        get => new TerraformReference<double>(this, "node_count");
    }

    /// <summary>
    /// Contains the name of allocated IP address ranges associated with
    /// the private service access connection for example, &amp;quot;test-default&amp;quot;
    /// associated with IP range 10.0.0.0/29.
    /// </summary>
    public TerraformList<string> ReservedIpRangeId
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "reserved_ip_range_id").ResolveNodes(ctx));
    }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Zones where memcache nodes should be provisioned.  If not
    /// provided, all zones will be used.
    /// </summary>
    public TerraformSet<string> Zones
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "zones").ResolveNodes(ctx));
    }

}
