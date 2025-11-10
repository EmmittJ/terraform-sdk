using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for autoscaling in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerAwsNodePoolAutoscalingBlock : ITerraformBlock
{
    /// <summary>
    /// Maximum number of nodes in the NodePool. Must be &amp;gt;= min_node_count.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxNodeCount is required")]
    [TerraformPropertyName("max_node_count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MaxNodeCount { get; set; }

    /// <summary>
    /// Minimum number of nodes in the NodePool. Must be &amp;gt;= 1 and &amp;lt;= max_node_count.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinNodeCount is required")]
    [TerraformPropertyName("min_node_count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MinNodeCount { get; set; }

}

/// <summary>
/// Block type for config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerAwsNodePoolConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The name of the AWS IAM role assigned to nodes in the pool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IamInstanceProfile is required")]
    [TerraformPropertyName("iam_instance_profile")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> IamInstanceProfile { get; set; }

    /// <summary>
    /// Optional. The AWS instance type. When unspecified, it defaults to `m5.large`.
    /// </summary>
    [TerraformPropertyName("instance_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> InstanceType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "instance_type");

    /// <summary>
    /// Optional. The initial labels assigned to nodes of this node pool. An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// Optional. The IDs of additional security groups to add to nodes in this pool. The manager will automatically create security groups with minimum rules needed for a functioning cluster.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? SecurityGroupIds { get; set; }

    /// <summary>
    /// Optional. Key/value metadata to assign to each underlying AWS resource. Specify at most 50 pairs containing alphanumerics, spaces, and symbols (.+-=_:@/). Keys can be up to 127 Unicode characters. Values can be up to 255 Unicode characters.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

}

/// <summary>
/// Block type for kubelet_config in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerAwsNodePoolKubeletConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Whether or not to enable CPU CFS quota. Defaults to true.
    /// </summary>
    [TerraformPropertyName("cpu_cfs_quota")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> CpuCfsQuota { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "cpu_cfs_quota");

    /// <summary>
    /// Optional. The CPU CFS quota period to use for the node. Defaults to &amp;quot;100ms&amp;quot;.
    /// </summary>
    [TerraformPropertyName("cpu_cfs_quota_period")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CpuCfsQuotaPeriod { get; set; }

    /// <summary>
    /// The CpuManagerPolicy to use for the node. Defaults to &amp;quot;none&amp;quot;.
    /// </summary>
    [TerraformPropertyName("cpu_manager_policy")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CpuManagerPolicy { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "cpu_manager_policy");

    /// <summary>
    /// Optional. The maximum number of PIDs in each pod running on the node. The limit scales automatically based on underlying machine size if left unset.
    /// </summary>
    [TerraformPropertyName("pod_pids_limit")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? PodPidsLimit { get; set; }

}

/// <summary>
/// Block type for management in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerAwsNodePoolManagementBlock : ITerraformBlock
{
    /// <summary>
    /// Optional. Whether or not the nodes will be automatically repaired.
    /// </summary>
    [TerraformPropertyName("auto_repair")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> AutoRepair { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "auto_repair");

}

/// <summary>
/// Block type for max_pods_constraint in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerAwsNodePoolMaxPodsConstraintBlock : ITerraformBlock
{
    /// <summary>
    /// The maximum number of pods to schedule on a single node.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxPodsPerNode is required")]
    [TerraformPropertyName("max_pods_per_node")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MaxPodsPerNode { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleContainerAwsNodePoolTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for update_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerAwsNodePoolUpdateSettingsBlock : ITerraformBlock
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
    }

    /// <summary>
    /// Optional. Annotations on the node pool. This field has the same restrictions as Kubernetes annotations. The total size of all keys and values combined is limited to 256k. Key can have 2 segments: prefix (optional) and name (required), separated by a slash (/). Prefix must be a DNS subdomain. Name must be 63 characters or less, begin and end with alphanumerics, with dashes (-), underscores (_), dots (.), and alphanumerics between.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field `effective_annotations` for all of the annotations present on the resource.
    /// </summary>
    [TerraformPropertyName("annotations")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Annotations { get; set; }

    /// <summary>
    /// The awsCluster for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    [TerraformPropertyName("cluster")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Cluster { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name of this resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project for the resource
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The subnet where the node pool node run.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformPropertyName("subnet_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SubnetId { get; set; }

    /// <summary>
    /// The Kubernetes version to run on this node pool (e.g. `1.19.10-gke.1000`). You can list all supported versions on a given Google Cloud region by calling GetAwsServerConfig.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformPropertyName("version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Version { get; set; }

    /// <summary>
    /// Block for autoscaling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Autoscaling is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Autoscaling block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Autoscaling block(s) allowed")]
    [TerraformPropertyName("autoscaling")]
    public TerraformList<TerraformBlock<GoogleContainerAwsNodePoolAutoscalingBlock>>? Autoscaling { get; set; } = new();

    /// <summary>
    /// Block for config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Config is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Config block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Config block(s) allowed")]
    [TerraformPropertyName("config")]
    public TerraformList<TerraformBlock<GoogleContainerAwsNodePoolConfigBlock>>? Config { get; set; } = new();

    /// <summary>
    /// Block for kubelet_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KubeletConfig block(s) allowed")]
    [TerraformPropertyName("kubelet_config")]
    public TerraformList<TerraformBlock<GoogleContainerAwsNodePoolKubeletConfigBlock>>? KubeletConfig { get; set; } = new();

    /// <summary>
    /// Block for management.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Management block(s) allowed")]
    [TerraformPropertyName("management")]
    public TerraformList<TerraformBlock<GoogleContainerAwsNodePoolManagementBlock>>? Management { get; set; } = new();

    /// <summary>
    /// Block for max_pods_constraint.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxPodsConstraint is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MaxPodsConstraint block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaxPodsConstraint block(s) allowed")]
    [TerraformPropertyName("max_pods_constraint")]
    public TerraformList<TerraformBlock<GoogleContainerAwsNodePoolMaxPodsConstraintBlock>>? MaxPodsConstraint { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleContainerAwsNodePoolTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for update_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpdateSettings block(s) allowed")]
    [TerraformPropertyName("update_settings")]
    public TerraformList<TerraformBlock<GoogleContainerAwsNodePoolUpdateSettingsBlock>>? UpdateSettings { get; set; } = new();

    /// <summary>
    /// Output only. The time at which this node pool was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_annotations")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveAnnotations => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_annotations");

    /// <summary>
    /// Allows clients to perform consistent read-modify-writes through optimistic concurrency control. May be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Etag => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "etag");

    /// <summary>
    /// Output only. If set, there are currently changes in flight to the node pool.
    /// </summary>
    [TerraformPropertyName("reconciling")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Reconciling => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "reconciling");

    /// <summary>
    /// Output only. The lifecycle state of the node pool. Possible values: STATE_UNSPECIFIED, PROVISIONING, RUNNING, RECONCILING, STOPPING, ERROR, DEGRADED
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// Output only. A globally unique identifier for the node pool.
    /// </summary>
    [TerraformPropertyName("uid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Uid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "uid");

    /// <summary>
    /// Output only. The time at which this node pool was last updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
