using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for autoscaling in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerAzureNodePoolAutoscalingBlock : TerraformBlock
{
    /// <summary>
    /// Maximum number of nodes in the node pool. Must be &amp;gt;= min_node_count.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxNodeCount is required")]
    public required TerraformProperty<double> MaxNodeCount
    {
        get => GetProperty<TerraformProperty<double>>("max_node_count");
        set => WithProperty("max_node_count", value);
    }

    /// <summary>
    /// Minimum number of nodes in the node pool. Must be &amp;gt;= 1 and &amp;lt;= max_node_count.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinNodeCount is required")]
    public required TerraformProperty<double> MinNodeCount
    {
        get => GetProperty<TerraformProperty<double>>("min_node_count");
        set => WithProperty("min_node_count", value);
    }

}

/// <summary>
/// Block type for config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerAzureNodePoolConfigBlock : TerraformBlock
{
    /// <summary>
    /// Optional. The initial labels assigned to nodes of this node pool. An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => WithProperty("labels", value);
    }

    /// <summary>
    /// Optional. A set of tags to apply to all underlying Azure resources for this node pool. This currently only includes Virtual Machine Scale Sets. Specify at most 50 pairs containing alphanumerics, spaces, and symbols (.+-=_:@/). Keys can be up to 127 Unicode characters. Values can be up to 255 Unicode characters.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => WithProperty("tags", value);
    }

    /// <summary>
    /// Optional. The Azure VM size name. Example: `Standard_DS2_v2`. See (/anthos/clusters/docs/azure/reference/supported-vms) for options. When unspecified, it defaults to `Standard_DS2_v2`.
    /// </summary>
    public TerraformProperty<string>? VmSize
    {
        get => GetProperty<TerraformProperty<string>>("vm_size");
        set => WithProperty("vm_size", value);
    }

}

/// <summary>
/// Block type for management in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerAzureNodePoolManagementBlock : TerraformBlock
{
    /// <summary>
    /// Optional. Whether or not the nodes will be automatically repaired.
    /// </summary>
    public TerraformProperty<bool>? AutoRepair
    {
        get => GetProperty<TerraformProperty<bool>>("auto_repair");
        set => WithProperty("auto_repair", value);
    }

}

/// <summary>
/// Block type for max_pods_constraint in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerAzureNodePoolMaxPodsConstraintBlock : TerraformBlock
{
    /// <summary>
    /// The maximum number of pods to schedule on a single node.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxPodsPerNode is required")]
    public required TerraformProperty<double> MaxPodsPerNode
    {
        get => GetProperty<TerraformProperty<double>>("max_pods_per_node");
        set => WithProperty("max_pods_per_node", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleContainerAzureNodePoolTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_container_azure_node_pool resource.
/// </summary>
public class GoogleContainerAzureNodePool : TerraformResource
{
    public GoogleContainerAzureNodePool(string name) : base("google_container_azure_node_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_annotations");
        this.DeclareOutput("etag");
        this.DeclareOutput("reconciling");
        this.DeclareOutput("state");
        this.DeclareOutput("uid");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// Optional. Annotations on the node pool. This field has the same restrictions as Kubernetes annotations. The total size of all keys and values combined is limited to 256k. Keys can have 2 segments: prefix (optional) and name (required), separated by a slash (/). Prefix must be a DNS subdomain. Name must be 63 characters or less, begin and end with alphanumerics, with dashes (-), underscores (_), dots (.), and alphanumerics between.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field `effective_annotations` for all of the annotations present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Annotations
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("annotations");
        set => this.WithProperty("annotations", value);
    }

    /// <summary>
    /// Optional. The Azure availability zone of the nodes in this nodepool. When unspecified, it defaults to `1`.
    /// </summary>
    public TerraformProperty<string>? AzureAvailabilityZone
    {
        get => GetProperty<TerraformProperty<string>>("azure_availability_zone");
        set => this.WithProperty("azure_availability_zone", value);
    }

    /// <summary>
    /// The azureCluster for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    public required TerraformProperty<string> Cluster
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
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name of this resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project for the resource
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The ARM ID of the subnet where the node pool VMs run. Make sure it&#39;s a subnet under the virtual network in the cluster configuration.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => this.WithProperty("subnet_id", value);
    }

    /// <summary>
    /// The Kubernetes version (e.g. `1.19.10-gke.1000`) running on this node pool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformProperty<string> Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => this.WithProperty("version", value);
    }

    /// <summary>
    /// Block for autoscaling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Autoscaling block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Autoscaling block(s) allowed")]
    public List<GoogleContainerAzureNodePoolAutoscalingBlock>? Autoscaling
    {
        get => GetProperty<List<GoogleContainerAzureNodePoolAutoscalingBlock>>("autoscaling");
        set => this.WithProperty("autoscaling", value);
    }

    /// <summary>
    /// Block for config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Config block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Config block(s) allowed")]
    public List<GoogleContainerAzureNodePoolConfigBlock>? Config
    {
        get => GetProperty<List<GoogleContainerAzureNodePoolConfigBlock>>("config");
        set => this.WithProperty("config", value);
    }

    /// <summary>
    /// Block for management.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Management block(s) allowed")]
    public List<GoogleContainerAzureNodePoolManagementBlock>? Management
    {
        get => GetProperty<List<GoogleContainerAzureNodePoolManagementBlock>>("management");
        set => this.WithProperty("management", value);
    }

    /// <summary>
    /// Block for max_pods_constraint.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MaxPodsConstraint block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaxPodsConstraint block(s) allowed")]
    public List<GoogleContainerAzureNodePoolMaxPodsConstraintBlock>? MaxPodsConstraint
    {
        get => GetProperty<List<GoogleContainerAzureNodePoolMaxPodsConstraintBlock>>("max_pods_constraint");
        set => this.WithProperty("max_pods_constraint", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleContainerAzureNodePoolTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleContainerAzureNodePoolTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Output only. The time at which this node pool was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveAnnotations => this["effective_annotations"];

    /// <summary>
    /// Allows clients to perform consistent read-modify-writes through optimistic concurrency control. May be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// Output only. If set, there are currently pending changes to the node pool.
    /// </summary>
    public TerraformExpression Reconciling => this["reconciling"];

    /// <summary>
    /// Output only. The current state of the node pool. Possible values: STATE_UNSPECIFIED, PROVISIONING, RUNNING, RECONCILING, STOPPING, ERROR, DEGRADED
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// Output only. A globally unique identifier for the node pool.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// Output only. The time at which this node pool was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
