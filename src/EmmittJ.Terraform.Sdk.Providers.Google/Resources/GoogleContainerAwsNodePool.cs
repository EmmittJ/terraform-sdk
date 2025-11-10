using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for autoscaling in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerAwsNodePoolAutoscalingBlock : TerraformBlock
{
    /// <summary>
    /// Maximum number of nodes in the NodePool. Must be &amp;gt;= min_node_count.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxNodeCount is required")]
    public required TerraformProperty<double> MaxNodeCount
    {
        get => GetProperty<TerraformProperty<double>>("max_node_count");
        set => WithProperty("max_node_count", value);
    }

    /// <summary>
    /// Minimum number of nodes in the NodePool. Must be &amp;gt;= 1 and &amp;lt;= max_node_count.
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
public class GoogleContainerAwsNodePoolConfigBlock : TerraformBlock
{
    /// <summary>
    /// The name of the AWS IAM role assigned to nodes in the pool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IamInstanceProfile is required")]
    public required TerraformProperty<string> IamInstanceProfile
    {
        get => GetProperty<TerraformProperty<string>>("iam_instance_profile");
        set => WithProperty("iam_instance_profile", value);
    }

    /// <summary>
    /// Optional. The AWS instance type. When unspecified, it defaults to `m5.large`.
    /// </summary>
    public TerraformProperty<string>? InstanceType
    {
        get => GetProperty<TerraformProperty<string>>("instance_type");
        set => WithProperty("instance_type", value);
    }

    /// <summary>
    /// Optional. The initial labels assigned to nodes of this node pool. An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => WithProperty("labels", value);
    }

    /// <summary>
    /// Optional. The IDs of additional security groups to add to nodes in this pool. The manager will automatically create security groups with minimum rules needed for a functioning cluster.
    /// </summary>
    public List<TerraformProperty<string>>? SecurityGroupIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("security_group_ids");
        set => WithProperty("security_group_ids", value);
    }

    /// <summary>
    /// Optional. Key/value metadata to assign to each underlying AWS resource. Specify at most 50 pairs containing alphanumerics, spaces, and symbols (.+-=_:@/). Keys can be up to 127 Unicode characters. Values can be up to 255 Unicode characters.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => WithProperty("tags", value);
    }

}

/// <summary>
/// Block type for kubelet_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerAwsNodePoolKubeletConfigBlock : TerraformBlock
{
    /// <summary>
    /// Whether or not to enable CPU CFS quota. Defaults to true.
    /// </summary>
    public TerraformProperty<bool>? CpuCfsQuota
    {
        get => GetProperty<TerraformProperty<bool>>("cpu_cfs_quota");
        set => WithProperty("cpu_cfs_quota", value);
    }

    /// <summary>
    /// Optional. The CPU CFS quota period to use for the node. Defaults to &amp;quot;100ms&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? CpuCfsQuotaPeriod
    {
        get => GetProperty<TerraformProperty<string>>("cpu_cfs_quota_period");
        set => WithProperty("cpu_cfs_quota_period", value);
    }

    /// <summary>
    /// The CpuManagerPolicy to use for the node. Defaults to &amp;quot;none&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? CpuManagerPolicy
    {
        get => GetProperty<TerraformProperty<string>>("cpu_manager_policy");
        set => WithProperty("cpu_manager_policy", value);
    }

    /// <summary>
    /// Optional. The maximum number of PIDs in each pod running on the node. The limit scales automatically based on underlying machine size if left unset.
    /// </summary>
    public TerraformProperty<double>? PodPidsLimit
    {
        get => GetProperty<TerraformProperty<double>>("pod_pids_limit");
        set => WithProperty("pod_pids_limit", value);
    }

}

/// <summary>
/// Block type for management in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerAwsNodePoolManagementBlock : TerraformBlock
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
public class GoogleContainerAwsNodePoolMaxPodsConstraintBlock : TerraformBlock
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
public class GoogleContainerAwsNodePoolTimeoutsBlock : TerraformBlock
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
/// Block type for update_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerAwsNodePoolUpdateSettingsBlock : TerraformBlock
{
}

/// <summary>
/// Manages a google_container_aws_node_pool resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleContainerAwsNodePool : TerraformResource
{
    public GoogleContainerAwsNodePool(string name) : base("google_container_aws_node_pool", name)
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
    /// Optional. Annotations on the node pool. This field has the same restrictions as Kubernetes annotations. The total size of all keys and values combined is limited to 256k. Key can have 2 segments: prefix (optional) and name (required), separated by a slash (/). Prefix must be a DNS subdomain. Name must be 63 characters or less, begin and end with alphanumerics, with dashes (-), underscores (_), dots (.), and alphanumerics between.
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
    /// The awsCluster for the resource
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
    /// The subnet where the node pool node run.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => this.WithProperty("subnet_id", value);
    }

    /// <summary>
    /// The Kubernetes version to run on this node pool (e.g. `1.19.10-gke.1000`). You can list all supported versions on a given Google Cloud region by calling GetAwsServerConfig.
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
    public List<GoogleContainerAwsNodePoolAutoscalingBlock>? Autoscaling
    {
        get => GetProperty<List<GoogleContainerAwsNodePoolAutoscalingBlock>>("autoscaling");
        set => this.WithProperty("autoscaling", value);
    }

    /// <summary>
    /// Block for config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Config block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Config block(s) allowed")]
    public List<GoogleContainerAwsNodePoolConfigBlock>? Config
    {
        get => GetProperty<List<GoogleContainerAwsNodePoolConfigBlock>>("config");
        set => this.WithProperty("config", value);
    }

    /// <summary>
    /// Block for kubelet_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KubeletConfig block(s) allowed")]
    public List<GoogleContainerAwsNodePoolKubeletConfigBlock>? KubeletConfig
    {
        get => GetProperty<List<GoogleContainerAwsNodePoolKubeletConfigBlock>>("kubelet_config");
        set => this.WithProperty("kubelet_config", value);
    }

    /// <summary>
    /// Block for management.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Management block(s) allowed")]
    public List<GoogleContainerAwsNodePoolManagementBlock>? Management
    {
        get => GetProperty<List<GoogleContainerAwsNodePoolManagementBlock>>("management");
        set => this.WithProperty("management", value);
    }

    /// <summary>
    /// Block for max_pods_constraint.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MaxPodsConstraint block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaxPodsConstraint block(s) allowed")]
    public List<GoogleContainerAwsNodePoolMaxPodsConstraintBlock>? MaxPodsConstraint
    {
        get => GetProperty<List<GoogleContainerAwsNodePoolMaxPodsConstraintBlock>>("max_pods_constraint");
        set => this.WithProperty("max_pods_constraint", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleContainerAwsNodePoolTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleContainerAwsNodePoolTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for update_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpdateSettings block(s) allowed")]
    public List<GoogleContainerAwsNodePoolUpdateSettingsBlock>? UpdateSettings
    {
        get => GetProperty<List<GoogleContainerAwsNodePoolUpdateSettingsBlock>>("update_settings");
        set => this.WithProperty("update_settings", value);
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
    /// Output only. If set, there are currently changes in flight to the node pool.
    /// </summary>
    public TerraformExpression Reconciling => this["reconciling"];

    /// <summary>
    /// Output only. The lifecycle state of the node pool. Possible values: STATE_UNSPECIFIED, PROVISIONING, RUNNING, RECONCILING, STOPPING, ERROR, DEGRADED
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
