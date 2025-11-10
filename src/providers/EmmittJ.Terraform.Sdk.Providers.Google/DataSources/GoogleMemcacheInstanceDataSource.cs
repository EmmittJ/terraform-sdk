using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_memcache_instance.
/// </summary>
public class GoogleMemcacheInstanceDataSource : TerraformDataSource
{
    public GoogleMemcacheInstanceDataSource(string name) : base("google_memcache_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("authorized_network");
        this.DeclareOutput("create_time");
        this.DeclareOutput("deletion_protection");
        this.DeclareOutput("discovery_endpoint");
        this.DeclareOutput("display_name");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("labels");
        this.DeclareOutput("maintenance_policy");
        this.DeclareOutput("maintenance_schedule");
        this.DeclareOutput("memcache_full_version");
        this.DeclareOutput("memcache_nodes");
        this.DeclareOutput("memcache_parameters");
        this.DeclareOutput("memcache_version");
        this.DeclareOutput("node_config");
        this.DeclareOutput("node_count");
        this.DeclareOutput("reserved_ip_range_id");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("zones");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The resource name of the instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The region of the Memcache instance. If it is not provided, the provider region is used.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The full name of the GCE network to connect the instance to.  If not provided,
    /// &#39;default&#39; will be used.
    /// </summary>
    public TerraformExpression AuthorizedNetwork => this["authorized_network"];

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Whether Terraform will be prevented from destroying the instance.
    /// When a &#39;terraform destroy&#39; or &#39;terraform apply&#39; would delete the instance,
    /// the command will fail if this field is not set to false in Terraform state.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the instance will fail.
    /// When the field is set to false, deleting the instance is allowed.
    /// </summary>
    public TerraformExpression DeletionProtection => this["deletion_protection"];

    /// <summary>
    /// Endpoint for Discovery API
    /// </summary>
    public TerraformExpression DiscoveryEndpoint => this["discovery_endpoint"];

    /// <summary>
    /// A user-visible name for the instance.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Resource labels to represent user-provided metadata.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformExpression Labels => this["labels"];

    /// <summary>
    /// Maintenance policy for an instance.
    /// </summary>
    public TerraformExpression MaintenancePolicy => this["maintenance_policy"];

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
    /// User-specified parameters for this memcache instance.
    /// </summary>
    public TerraformExpression MemcacheParameters => this["memcache_parameters"];

    /// <summary>
    /// The major version of Memcached software. If not provided, latest supported version will be used.
    /// Currently the latest supported major version is MEMCACHE_1_5. The minor version will be automatically
    /// determined by our system based on the latest supported minor version. Default value: &amp;quot;MEMCACHE_1_5&amp;quot; Possible values: [&amp;quot;MEMCACHE_1_5&amp;quot;, &amp;quot;MEMCACHE_1_6_15&amp;quot;]
    /// </summary>
    public TerraformExpression MemcacheVersion => this["memcache_version"];

    /// <summary>
    /// Configuration for memcache nodes.
    /// </summary>
    public TerraformExpression NodeConfig => this["node_config"];

    /// <summary>
    /// Number of nodes in the memcache instance.
    /// </summary>
    public TerraformExpression NodeCount => this["node_count"];

    /// <summary>
    /// Contains the name of allocated IP address ranges associated with
    /// the private service access connection for example, &amp;quot;test-default&amp;quot;
    /// associated with IP range 10.0.0.0/29.
    /// </summary>
    public TerraformExpression ReservedIpRangeId => this["reserved_ip_range_id"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Zones where memcache nodes should be provisioned.  If not
    /// provided, all zones will be used.
    /// </summary>
    public TerraformExpression Zones => this["zones"];

}
