using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for autoscaling_policy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeNodeGroupAutoscalingPolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// Maximum size of the node group. Set to a value less than or equal
    /// to 100 and greater than or equal to min-nodes.
    /// </summary>
    [TerraformProperty("max_nodes")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MaxNodes { get; set; }

    /// <summary>
    /// Minimum size of the node group. Must be less
    /// than or equal to max-nodes. The default value is 0.
    /// </summary>
    [TerraformProperty("min_nodes")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MinNodes { get; set; }

    /// <summary>
    /// The autoscaling mode. Set to one of the following:
    ///   - OFF: Disables the autoscaler.
    ///   - ON: Enables scaling in and scaling out.
    ///   - ONLY_SCALE_OUT: Enables only scaling out.
    ///   You must use this mode if your node groups are configured to
    ///   restart their hosted VMs on minimal servers. Possible values: [&amp;quot;OFF&amp;quot;, &amp;quot;ON&amp;quot;, &amp;quot;ONLY_SCALE_OUT&amp;quot;]
    /// </summary>
    [TerraformProperty("mode")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Mode { get; set; }

}

/// <summary>
/// Block type for maintenance_window in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeNodeGroupMaintenanceWindowBlock : TerraformBlockBase
{
    /// <summary>
    /// instances.start time of the window. This must be in UTC format that resolves to one of 00:00, 04:00, 08:00, 12:00, 16:00, or 20:00. For example, both 13:00-5 and 08:00 are valid.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTime is required")]
    [TerraformProperty("start_time")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StartTime { get; set; }

}

/// <summary>
/// Block type for share_settings in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeNodeGroupShareSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// Node group sharing type. Possible values: [&amp;quot;ORGANIZATION&amp;quot;, &amp;quot;SPECIFIC_PROJECTS&amp;quot;, &amp;quot;LOCAL&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShareType is required")]
    [TerraformProperty("share_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ShareType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeNodeGroupTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_compute_node_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleComputeNodeGroup : TerraformResource
{
    public GoogleComputeNodeGroup(string name) : base("google_compute_node_group", name)
    {
    }

    /// <summary>
    /// An optional textual description of the resource.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The initial number of nodes in the node group. One of &#39;initial_size&#39; or &#39;autoscaling_policy&#39; must be configured on resource creation.
    /// </summary>
    [TerraformProperty("initial_size")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? InitialSize { get; set; }

    /// <summary>
    /// Specifies how to handle instances when a node in the group undergoes maintenance. Set to one of: DEFAULT, RESTART_IN_PLACE, or MIGRATE_WITHIN_NODE_GROUP. The default value is DEFAULT.
    /// </summary>
    [TerraformProperty("maintenance_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MaintenancePolicy { get; set; }

    /// <summary>
    /// Name of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The URL of the node template to which this node group belongs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeTemplate is required")]
    [TerraformProperty("node_template")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NodeTemplate { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Zone where this node group is located
    /// </summary>
    [TerraformProperty("zone")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Zone { get; set; }

    /// <summary>
    /// Block for autoscaling_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoscalingPolicy block(s) allowed")]
    [TerraformProperty("autoscaling_policy")]
    public partial TerraformList<TerraformBlock<GoogleComputeNodeGroupAutoscalingPolicyBlock>>? AutoscalingPolicy { get; set; }

    /// <summary>
    /// Block for maintenance_window.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindow block(s) allowed")]
    [TerraformProperty("maintenance_window")]
    public partial TerraformList<TerraformBlock<GoogleComputeNodeGroupMaintenanceWindowBlock>>? MaintenanceWindow { get; set; }

    /// <summary>
    /// Block for share_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShareSettings block(s) allowed")]
    [TerraformProperty("share_settings")]
    public partial TerraformList<TerraformBlock<GoogleComputeNodeGroupShareSettingsBlock>>? ShareSettings { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleComputeNodeGroupTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformProperty("creation_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreationTimestamp { get; }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SelfLink { get; }

    /// <summary>
    /// The total number of nodes in the node group.
    /// </summary>
    [TerraformProperty("size")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Size { get; }

}
