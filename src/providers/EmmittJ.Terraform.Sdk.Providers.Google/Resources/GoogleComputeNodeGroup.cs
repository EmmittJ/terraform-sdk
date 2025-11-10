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
        set => SetProperty("max_nodes", value);
    }

    /// <summary>
    /// Minimum size of the node group. Must be less
    /// than or equal to max-nodes. The default value is 0.
    /// </summary>
    public TerraformProperty<double>? MinNodes
    {
        set => SetProperty("min_nodes", value);
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
        set => SetProperty("mode", value);
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
        set => SetProperty("start_time", value);
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
        set => SetProperty("share_type", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("creation_timestamp");
        SetOutput("self_link");
        SetOutput("size");
        SetOutput("description");
        SetOutput("id");
        SetOutput("initial_size");
        SetOutput("maintenance_policy");
        SetOutput("name");
        SetOutput("node_template");
        SetOutput("project");
        SetOutput("zone");
    }

    /// <summary>
    /// An optional textual description of the resource.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The initial number of nodes in the node group. One of &#39;initial_size&#39; or &#39;autoscaling_policy&#39; must be configured on resource creation.
    /// </summary>
    public TerraformProperty<double> InitialSize
    {
        get => GetRequiredOutput<TerraformProperty<double>>("initial_size");
        set => SetProperty("initial_size", value);
    }

    /// <summary>
    /// Specifies how to handle instances when a node in the group undergoes maintenance. Set to one of: DEFAULT, RESTART_IN_PLACE, or MIGRATE_WITHIN_NODE_GROUP. The default value is DEFAULT.
    /// </summary>
    public TerraformProperty<string> MaintenancePolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("maintenance_policy");
        set => SetProperty("maintenance_policy", value);
    }

    /// <summary>
    /// Name of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The URL of the node template to which this node group belongs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeTemplate is required")]
    public required TerraformProperty<string> NodeTemplate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("node_template");
        set => SetProperty("node_template", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Zone where this node group is located
    /// </summary>
    public TerraformProperty<string> Zone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("zone");
        set => SetProperty("zone", value);
    }

    /// <summary>
    /// Block for autoscaling_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoscalingPolicy block(s) allowed")]
    public List<GoogleComputeNodeGroupAutoscalingPolicyBlock>? AutoscalingPolicy
    {
        set => SetProperty("autoscaling_policy", value);
    }

    /// <summary>
    /// Block for maintenance_window.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindow block(s) allowed")]
    public List<GoogleComputeNodeGroupMaintenanceWindowBlock>? MaintenanceWindow
    {
        set => SetProperty("maintenance_window", value);
    }

    /// <summary>
    /// Block for share_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShareSettings block(s) allowed")]
    public List<GoogleComputeNodeGroupShareSettingsBlock>? ShareSettings
    {
        set => SetProperty("share_settings", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeNodeGroupTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
