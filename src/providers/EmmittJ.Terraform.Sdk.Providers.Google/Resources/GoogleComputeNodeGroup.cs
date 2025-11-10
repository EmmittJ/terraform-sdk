using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for autoscaling_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeNodeGroupAutoscalingPolicyBlock : ITerraformBlock
{
    /// <summary>
    /// Maximum size of the node group. Set to a value less than or equal
    /// to 100 and greater than or equal to min-nodes.
    /// </summary>
    [TerraformPropertyName("max_nodes")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MaxNodes { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "max_nodes");

    /// <summary>
    /// Minimum size of the node group. Must be less
    /// than or equal to max-nodes. The default value is 0.
    /// </summary>
    [TerraformPropertyName("min_nodes")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MinNodes { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "min_nodes");

    /// <summary>
    /// The autoscaling mode. Set to one of the following:
    ///   - OFF: Disables the autoscaler.
    ///   - ON: Enables scaling in and scaling out.
    ///   - ONLY_SCALE_OUT: Enables only scaling out.
    ///   You must use this mode if your node groups are configured to
    ///   restart their hosted VMs on minimal servers. Possible values: [&amp;quot;OFF&amp;quot;, &amp;quot;ON&amp;quot;, &amp;quot;ONLY_SCALE_OUT&amp;quot;]
    /// </summary>
    [TerraformPropertyName("mode")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Mode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "mode");

}

/// <summary>
/// Block type for maintenance_window in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeNodeGroupMaintenanceWindowBlock : ITerraformBlock
{
    /// <summary>
    /// instances.start time of the window. This must be in UTC format that resolves to one of 00:00, 04:00, 08:00, 12:00, 16:00, or 20:00. For example, both 13:00-5 and 08:00 are valid.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTime is required")]
    [TerraformPropertyName("start_time")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StartTime { get; set; }

}

/// <summary>
/// Block type for share_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeNodeGroupShareSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// Node group sharing type. Possible values: [&amp;quot;ORGANIZATION&amp;quot;, &amp;quot;SPECIFIC_PROJECTS&amp;quot;, &amp;quot;LOCAL&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShareType is required")]
    [TerraformPropertyName("share_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ShareType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeNodeGroupTimeoutsBlock : ITerraformBlock
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
/// Manages a google_compute_node_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeNodeGroup : TerraformResource
{
    public GoogleComputeNodeGroup(string name) : base("google_compute_node_group", name)
    {
    }

    /// <summary>
    /// An optional textual description of the resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The initial number of nodes in the node group. One of &#39;initial_size&#39; or &#39;autoscaling_policy&#39; must be configured on resource creation.
    /// </summary>
    [TerraformPropertyName("initial_size")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? InitialSize { get; set; }

    /// <summary>
    /// Specifies how to handle instances when a node in the group undergoes maintenance. Set to one of: DEFAULT, RESTART_IN_PLACE, or MIGRATE_WITHIN_NODE_GROUP. The default value is DEFAULT.
    /// </summary>
    [TerraformPropertyName("maintenance_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MaintenancePolicy { get; set; }

    /// <summary>
    /// Name of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The URL of the node template to which this node group belongs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeTemplate is required")]
    [TerraformPropertyName("node_template")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> NodeTemplate { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Zone where this node group is located
    /// </summary>
    [TerraformPropertyName("zone")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Zone { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "zone");

    /// <summary>
    /// Block for autoscaling_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoscalingPolicy block(s) allowed")]
    [TerraformPropertyName("autoscaling_policy")]
    public TerraformList<TerraformBlock<GoogleComputeNodeGroupAutoscalingPolicyBlock>>? AutoscalingPolicy { get; set; } = new();

    /// <summary>
    /// Block for maintenance_window.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindow block(s) allowed")]
    [TerraformPropertyName("maintenance_window")]
    public TerraformList<TerraformBlock<GoogleComputeNodeGroupMaintenanceWindowBlock>>? MaintenanceWindow { get; set; } = new();

    /// <summary>
    /// Block for share_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShareSettings block(s) allowed")]
    [TerraformPropertyName("share_settings")]
    public TerraformList<TerraformBlock<GoogleComputeNodeGroupShareSettingsBlock>>? ShareSettings { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputeNodeGroupTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationTimestamp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_timestamp");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link");

    /// <summary>
    /// The total number of nodes in the node group.
    /// </summary>
    [TerraformPropertyName("size")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Size => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "size");

}
