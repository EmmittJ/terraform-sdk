using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for autoscaling_policy in GoogleComputeNodeGroup.
/// Nesting mode: list
/// </summary>
public class GoogleComputeNodeGroupAutoscalingPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "autoscaling_policy";

    /// <summary>
    /// Maximum size of the node group. Set to a value less than or equal
    /// to 100 and greater than or equal to min-nodes.
    /// </summary>
    public TerraformValue<double> MaxNodes
    {
        get => new TerraformReference<double>(this, "max_nodes");
        set => SetArgument("max_nodes", value);
    }

    /// <summary>
    /// Minimum size of the node group. Must be less
    /// than or equal to max-nodes. The default value is 0.
    /// </summary>
    public TerraformValue<double> MinNodes
    {
        get => new TerraformReference<double>(this, "min_nodes");
        set => SetArgument("min_nodes", value);
    }

    /// <summary>
    /// The autoscaling mode. Set to one of the following:
    ///   - OFF: Disables the autoscaler.
    ///   - ON: Enables scaling in and scaling out.
    ///   - ONLY_SCALE_OUT: Enables only scaling out.
    ///   You must use this mode if your node groups are configured to
    ///   restart their hosted VMs on minimal servers. Possible values: [&amp;quot;OFF&amp;quot;, &amp;quot;ON&amp;quot;, &amp;quot;ONLY_SCALE_OUT&amp;quot;]
    /// </summary>
    public TerraformValue<string> Mode
    {
        get => new TerraformReference<string>(this, "mode");
        set => SetArgument("mode", value);
    }

}


/// <summary>
/// Block type for maintenance_window in GoogleComputeNodeGroup.
/// Nesting mode: list
/// </summary>
public class GoogleComputeNodeGroupMaintenanceWindowBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "maintenance_window";

    /// <summary>
    /// instances.start time of the window. This must be in UTC format that resolves to one of 00:00, 04:00, 08:00, 12:00, 16:00, or 20:00. For example, both 13:00-5 and 08:00 are valid.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTime is required")]
    public required TerraformValue<string> StartTime
    {
        get => new TerraformReference<string>(this, "start_time");
        set => SetArgument("start_time", value);
    }

}


/// <summary>
/// Block type for share_settings in GoogleComputeNodeGroup.
/// Nesting mode: list
/// </summary>
public class GoogleComputeNodeGroupShareSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "share_settings";

    /// <summary>
    /// Node group sharing type. Possible values: [&amp;quot;ORGANIZATION&amp;quot;, &amp;quot;SPECIFIC_PROJECTS&amp;quot;, &amp;quot;LOCAL&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShareType is required")]
    public required TerraformValue<string> ShareType
    {
        get => new TerraformReference<string>(this, "share_type");
        set => SetArgument("share_type", value);
    }

    /// <summary>
    /// ProjectMap block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleComputeNodeGroupShareSettingsBlockProjectMapBlock>? ProjectMap
    {
        get => GetArgument<TerraformSet<GoogleComputeNodeGroupShareSettingsBlockProjectMapBlock>>("project_map");
        set => SetArgument("project_map", value);
    }

}

/// <summary>
/// Block type for project_map in GoogleComputeNodeGroupShareSettingsBlock.
/// Nesting mode: set
/// </summary>
public class GoogleComputeNodeGroupShareSettingsBlockProjectMapBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "project_map";

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The project id/number should be the same as the key of this project config in the project map.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectId is required")]
    public required TerraformValue<string> ProjectId
    {
        get => new TerraformReference<string>(this, "project_id");
        set => SetArgument("project_id", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleComputeNodeGroup.
/// Nesting mode: single
/// </summary>
public class GoogleComputeNodeGroupTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_compute_node_group Terraform resource.
/// Manages a google_compute_node_group resource.
/// </summary>
public partial class GoogleComputeNodeGroup(string name) : TerraformResource("google_compute_node_group", name)
{
    /// <summary>
    /// An optional textual description of the resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The initial number of nodes in the node group. One of &#39;initial_size&#39; or &#39;autoscaling_policy&#39; must be configured on resource creation.
    /// </summary>
    public TerraformValue<double>? InitialSize
    {
        get => new TerraformReference<double>(this, "initial_size");
        set => SetArgument("initial_size", value);
    }

    /// <summary>
    /// Specifies how to handle instances when a node in the group undergoes maintenance. Set to one of: DEFAULT, RESTART_IN_PLACE, or MIGRATE_WITHIN_NODE_GROUP. The default value is DEFAULT.
    /// </summary>
    public TerraformValue<string>? MaintenancePolicy
    {
        get => new TerraformReference<string>(this, "maintenance_policy");
        set => SetArgument("maintenance_policy", value);
    }

    /// <summary>
    /// Name of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The URL of the node template to which this node group belongs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeTemplate is required")]
    public required TerraformValue<string> NodeTemplate
    {
        get => new TerraformReference<string>(this, "node_template");
        set => SetArgument("node_template", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Zone where this node group is located
    /// </summary>
    public TerraformValue<string> Zone
    {
        get => new TerraformReference<string>(this, "zone");
        set => SetArgument("zone", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
    {
        get => new TerraformReference<string>(this, "creation_timestamp");
    }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
    {
        get => new TerraformReference<string>(this, "self_link");
    }

    /// <summary>
    /// The total number of nodes in the node group.
    /// </summary>
    public TerraformValue<double> Size
    {
        get => new TerraformReference<double>(this, "size");
    }

    /// <summary>
    /// AutoscalingPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoscalingPolicy block(s) allowed")]
    public TerraformList<GoogleComputeNodeGroupAutoscalingPolicyBlock>? AutoscalingPolicy
    {
        get => GetArgument<TerraformList<GoogleComputeNodeGroupAutoscalingPolicyBlock>>("autoscaling_policy");
        set => SetArgument("autoscaling_policy", value);
    }

    /// <summary>
    /// MaintenanceWindow block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindow block(s) allowed")]
    public TerraformList<GoogleComputeNodeGroupMaintenanceWindowBlock>? MaintenanceWindow
    {
        get => GetArgument<TerraformList<GoogleComputeNodeGroupMaintenanceWindowBlock>>("maintenance_window");
        set => SetArgument("maintenance_window", value);
    }

    /// <summary>
    /// ShareSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShareSettings block(s) allowed")]
    public TerraformList<GoogleComputeNodeGroupShareSettingsBlock>? ShareSettings
    {
        get => GetArgument<TerraformList<GoogleComputeNodeGroupShareSettingsBlock>>("share_settings");
        set => SetArgument("share_settings", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeNodeGroupTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeNodeGroupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
