using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_memcache_instance resource.
/// </summary>
public class GoogleMemcacheInstance : TerraformResource
{
    public GoogleMemcacheInstance(string name) : base("google_memcache_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("discovery_endpoint");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("maintenance_schedule");
        this.DeclareOutput("memcache_full_version");
        this.DeclareOutput("memcache_nodes");
        this.DeclareOutput("terraform_labels");
    }

    /// <summary>
    /// The full name of the GCE network to connect the instance to.  If not provided,
    /// &#39;default&#39; will be used.
    /// </summary>
    public string? AuthorizedNetwork
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authorized_network")?.Value;
        set => this.WithProperty("authorized_network", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the instance.
    /// When a &#39;terraform destroy&#39; or &#39;terraform apply&#39; would delete the instance,
    /// the command will fail if this field is not set to false in Terraform state.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the instance will fail.
    /// When the field is set to false, deleting the instance is allowed.
    /// </summary>
    public bool? DeletionProtection
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("deletion_protection")?.Value;
        set => this.WithProperty("deletion_protection", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// A user-visible name for the instance.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Resource labels to represent user-provided metadata.
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
    /// The major version of Memcached software. If not provided, latest supported version will be used.
    /// Currently the latest supported major version is MEMCACHE_1_5. The minor version will be automatically
    /// determined by our system based on the latest supported minor version. Default value: &amp;quot;MEMCACHE_1_5&amp;quot; Possible values: [&amp;quot;MEMCACHE_1_5&amp;quot;, &amp;quot;MEMCACHE_1_6_15&amp;quot;]
    /// </summary>
    public string? MemcacheVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("memcache_version")?.Value;
        set => this.WithProperty("memcache_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource name of the instance.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Number of nodes in the memcache instance.
    /// </summary>
    public double? NodeCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("node_count")?.Value;
        set => this.WithProperty("node_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The region of the Memcache instance. If it is not provided, the provider region is used.
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Contains the name of allocated IP address ranges associated with
    /// the private service access connection for example, &amp;quot;test-default&amp;quot;
    /// associated with IP range 10.0.0.0/29.
    /// </summary>
    public List<string>? ReservedIpRangeId
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("reserved_ip_range_id")?.Value;
        set => this.WithProperty("reserved_ip_range_id", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// Zones where memcache nodes should be provisioned.  If not
    /// provided, all zones will be used.
    /// </summary>
    public HashSet<string>? Zones
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("zones")?.Value;
        set => this.WithProperty("zones", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Endpoint for Discovery API
    /// </summary>
    public TerraformExpression DiscoveryEndpoint => this["discovery_endpoint"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Output only. Published maintenance schedule.
    /// </summary>
    public TerraformExpression MaintenanceSchedule => this["maintenance_schedule"];

    /// <summary>
    /// The full version of memcached server running on this instance.
    /// </summary>
    public TerraformExpression MemcacheFullVersion => this["memcache_full_version"];

    /// <summary>
    /// Additional information about the instance state, if available.
    /// </summary>
    public TerraformExpression MemcacheNodes => this["memcache_nodes"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
