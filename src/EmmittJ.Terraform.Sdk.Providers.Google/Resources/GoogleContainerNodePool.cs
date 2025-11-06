using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_container_node_pool resource.
/// </summary>
public class GoogleContainerNodePool : TerraformResource
{
    public GoogleContainerNodePool(string name) : base("google_container_node_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("instance_group_urls");
        this.DeclareOutput("managed_instance_group_urls");
        this.DeclareOutput("operation");
    }

    /// <summary>
    /// The cluster to create the node pool for. Cluster must be present in location provided for zonal clusters.
    /// </summary>
    public string? Cluster
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster")?.Value;
        set => this.WithProperty("cluster", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The initial number of nodes for the pool. In regional or multi-zonal clusters, this is the number of nodes per zone. Changing this will force recreation of the resource.
    /// </summary>
    public double? InitialNodeCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("initial_node_count")?.Value;
        set => this.WithProperty("initial_node_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The location (region or zone) of the cluster.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The maximum number of pods per node in this node pool. Note that this does not work on node pools which are &amp;quot;route-based&amp;quot; - that is, node pools belonging to clusters that do not have IP Aliasing enabled.
    /// </summary>
    public double? MaxPodsPerNode
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_pods_per_node")?.Value;
        set => this.WithProperty("max_pods_per_node", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The name of the node pool. If left blank, Terraform will auto-generate a unique name.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Creates a unique name for the node pool beginning with the specified prefix. Conflicts with name.
    /// </summary>
    public string? NamePrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name_prefix")?.Value;
        set => this.WithProperty("name_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The number of nodes per instance group. This field can be used to update the number of nodes per instance group but should not be used alongside autoscaling.
    /// </summary>
    public double? NodeCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("node_count")?.Value;
        set => this.WithProperty("node_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The list of zones in which the node pool&#39;s nodes should be located. Nodes must be in the region of their regional cluster or in the same region as their cluster&#39;s zone for zonal clusters. If unspecified, the cluster-level node_locations will be used.
    /// </summary>
    public HashSet<string>? NodeLocations
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("node_locations")?.Value;
        set => this.WithProperty("node_locations", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The ID of the project in which to create the node pool. If blank, the provider-configured project will be used.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The Kubernetes version for the nodes in this pool. Note that if this field and auto_upgrade are both specified, they will fight each other for what the node version should be, so setting both is highly discouraged. While a fuzzy version can be specified, it&#39;s recommended that you specify explicit versions as Terraform will see spurious diffs when fuzzy versions are used. See the google_container_engine_versions data source&#39;s version_prefix field to approximate fuzzy versions in a Terraform-compatible way.
    /// </summary>
    public string? Version
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version")?.Value;
        set => this.WithProperty("version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource URLs of the managed instance groups associated with this node pool.
    /// </summary>
    public TerraformExpression InstanceGroupUrls => this["instance_group_urls"];

    /// <summary>
    /// List of instance group URLs which have been assigned to this node pool.
    /// </summary>
    public TerraformExpression ManagedInstanceGroupUrls => this["managed_instance_group_urls"];

    /// <summary>
    /// The operation attribute.
    /// </summary>
    public TerraformExpression Operation => this["operation"];

}
