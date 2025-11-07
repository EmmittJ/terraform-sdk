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
    public TerraformProperty<string>? Cluster
    {
        get => GetProperty<TerraformProperty<string>>("cluster");
        set => this.WithProperty("cluster", value);
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
    /// The initial number of nodes for the pool. In regional or multi-zonal clusters, this is the number of nodes per zone. Changing this will force recreation of the resource.
    /// </summary>
    public TerraformProperty<double>? InitialNodeCount
    {
        get => GetProperty<TerraformProperty<double>>("initial_node_count");
        set => this.WithProperty("initial_node_count", value);
    }

    /// <summary>
    /// The location (region or zone) of the cluster.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The maximum number of pods per node in this node pool. Note that this does not work on node pools which are &amp;quot;route-based&amp;quot; - that is, node pools belonging to clusters that do not have IP Aliasing enabled.
    /// </summary>
    public TerraformProperty<double>? MaxPodsPerNode
    {
        get => GetProperty<TerraformProperty<double>>("max_pods_per_node");
        set => this.WithProperty("max_pods_per_node", value);
    }

    /// <summary>
    /// The name of the node pool. If left blank, Terraform will auto-generate a unique name.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Creates a unique name for the node pool beginning with the specified prefix. Conflicts with name.
    /// </summary>
    public TerraformProperty<string>? NamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("name_prefix");
        set => this.WithProperty("name_prefix", value);
    }

    /// <summary>
    /// The number of nodes per instance group. This field can be used to update the number of nodes per instance group but should not be used alongside autoscaling.
    /// </summary>
    public TerraformProperty<double>? NodeCount
    {
        get => GetProperty<TerraformProperty<double>>("node_count");
        set => this.WithProperty("node_count", value);
    }

    /// <summary>
    /// The list of zones in which the node pool&#39;s nodes should be located. Nodes must be in the region of their regional cluster or in the same region as their cluster&#39;s zone for zonal clusters. If unspecified, the cluster-level node_locations will be used.
    /// </summary>
    public TerraformProperty<HashSet<string>>? NodeLocations
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("node_locations");
        set => this.WithProperty("node_locations", value);
    }

    /// <summary>
    /// The ID of the project in which to create the node pool. If blank, the provider-configured project will be used.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The Kubernetes version for the nodes in this pool. Note that if this field and auto_upgrade are both specified, they will fight each other for what the node version should be, so setting both is highly discouraged. While a fuzzy version can be specified, it&#39;s recommended that you specify explicit versions as Terraform will see spurious diffs when fuzzy versions are used. See the google_container_engine_versions data source&#39;s version_prefix field to approximate fuzzy versions in a Terraform-compatible way.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => this.WithProperty("version", value);
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
