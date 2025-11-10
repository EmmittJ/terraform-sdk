using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for autoscaling_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeNodeGroupAutoscalingPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Maximum size of the node group. Set to a value less than or equal
    /// to 100 and greater than or equal to min-nodes.
    /// </summary>
    public TerraformProperty<double>? MaxNodes
    {
        get => GetProperty<TerraformProperty<double>>("max_nodes");
        set => WithProperty("max_nodes", value);
    }

    /// <summary>
    /// Minimum size of the node group. Must be less
    /// than or equal to max-nodes. The default value is 0.
    /// </summary>
    public TerraformProperty<double>? MinNodes
    {
        get => GetProperty<TerraformProperty<double>>("min_nodes");
        set => WithProperty("min_nodes", value);
    }

    /// <summary>
    /// The autoscaling mode. Set to one of the following:
    ///   - OFF: Disables the autoscaler.
    ///   - ON: Enables scaling in and scaling out.
    ///   - ONLY_SCALE_OUT: Enables only scaling out.
    ///   You must use this mode if your node groups are configured to
    ///   restart their hosted VMs on minimal servers. Possible values: [&amp;quot;OFF&amp;quot;, &amp;quot;ON&amp;quot;, &amp;quot;ONLY_SCALE_OUT&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Mode
    {
        get => GetProperty<TerraformProperty<string>>("mode");
        set => WithProperty("mode", value);
    }

}

/// <summary>
/// Block type for maintenance_window in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeNodeGroupMaintenanceWindowBlock : TerraformBlock
{
    /// <summary>
    /// instances.start time of the window. This must be in UTC format that resolves to one of 00:00, 04:00, 08:00, 12:00, 16:00, or 20:00. For example, both 13:00-5 and 08:00 are valid.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTime is required")]
    public required TerraformProperty<string> StartTime
    {
        get => GetProperty<TerraformProperty<string>>("start_time");
        set => WithProperty("start_time", value);
    }

}

/// <summary>
/// Block type for share_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeNodeGroupShareSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Node group sharing type. Possible values: [&amp;quot;ORGANIZATION&amp;quot;, &amp;quot;SPECIFIC_PROJECTS&amp;quot;, &amp;quot;LOCAL&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShareType is required")]
    public required TerraformProperty<string> ShareType
    {
        get => GetProperty<TerraformProperty<string>>("share_type");
        set => WithProperty("share_type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeNodeGroupTimeoutsBlock : TerraformBlock
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
/// Manages a google_compute_node_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeNodeGroup : TerraformResource
{
    public GoogleComputeNodeGroup(string name) : base("google_compute_node_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("creation_timestamp");
        this.DeclareOutput("self_link");
        this.DeclareOutput("size");
    }

    /// <summary>
    /// An optional textual description of the resource.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The initial number of nodes in the node group. One of &#39;initial_size&#39; or &#39;autoscaling_policy&#39; must be configured on resource creation.
    /// </summary>
    public TerraformProperty<double>? InitialSize
    {
        get => GetProperty<TerraformProperty<double>>("initial_size");
        set => this.WithProperty("initial_size", value);
    }

    /// <summary>
    /// Specifies how to handle instances when a node in the group undergoes maintenance. Set to one of: DEFAULT, RESTART_IN_PLACE, or MIGRATE_WITHIN_NODE_GROUP. The default value is DEFAULT.
    /// </summary>
    public TerraformProperty<string>? MaintenancePolicy
    {
        get => GetProperty<TerraformProperty<string>>("maintenance_policy");
        set => this.WithProperty("maintenance_policy", value);
    }

    /// <summary>
    /// Name of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The URL of the node template to which this node group belongs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeTemplate is required")]
    public required TerraformProperty<string> NodeTemplate
    {
        get => GetProperty<TerraformProperty<string>>("node_template");
        set => this.WithProperty("node_template", value);
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
    /// Zone where this node group is located
    /// </summary>
    public TerraformProperty<string>? Zone
    {
        get => GetProperty<TerraformProperty<string>>("zone");
        set => this.WithProperty("zone", value);
    }

    /// <summary>
    /// Block for autoscaling_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoscalingPolicy block(s) allowed")]
    public List<GoogleComputeNodeGroupAutoscalingPolicyBlock>? AutoscalingPolicy
    {
        get => GetProperty<List<GoogleComputeNodeGroupAutoscalingPolicyBlock>>("autoscaling_policy");
        set => this.WithProperty("autoscaling_policy", value);
    }

    /// <summary>
    /// Block for maintenance_window.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindow block(s) allowed")]
    public List<GoogleComputeNodeGroupMaintenanceWindowBlock>? MaintenanceWindow
    {
        get => GetProperty<List<GoogleComputeNodeGroupMaintenanceWindowBlock>>("maintenance_window");
        set => this.WithProperty("maintenance_window", value);
    }

    /// <summary>
    /// Block for share_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShareSettings block(s) allowed")]
    public List<GoogleComputeNodeGroupShareSettingsBlock>? ShareSettings
    {
        get => GetProperty<List<GoogleComputeNodeGroupShareSettingsBlock>>("share_settings");
        set => this.WithProperty("share_settings", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeNodeGroupTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleComputeNodeGroupTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// The total number of nodes in the node group.
    /// </summary>
    public TerraformExpression Size => this["size"];

}
