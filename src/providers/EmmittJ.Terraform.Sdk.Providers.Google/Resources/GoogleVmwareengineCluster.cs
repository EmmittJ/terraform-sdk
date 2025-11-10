using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for autoscaling_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleVmwareengineClusterAutoscalingSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The minimum duration between consecutive autoscale operations.
    /// It starts once addition or removal of nodes is fully completed.
    /// Minimum cool down period is 30m.
    /// Cool down period must be in whole minutes (for example, 30m, 31m, 50m).
    /// Mandatory for successful addition of autoscaling settings in cluster.
    /// </summary>
    public TerraformProperty<string>? CoolDownPeriod
    {
        set => SetProperty("cool_down_period", value);
    }

    /// <summary>
    /// Maximum number of nodes of any type in a cluster.
    /// Mandatory for successful addition of autoscaling settings in cluster.
    /// </summary>
    public TerraformProperty<double>? MaxClusterNodeCount
    {
        set => SetProperty("max_cluster_node_count", value);
    }

    /// <summary>
    /// Minimum number of nodes of any type in a cluster.
    /// Mandatory for successful addition of autoscaling settings in cluster.
    /// </summary>
    public TerraformProperty<double>? MinClusterNodeCount
    {
        set => SetProperty("min_cluster_node_count", value);
    }

}

/// <summary>
/// Block type for node_type_configs in .
/// Nesting mode: set
/// </summary>
public class GoogleVmwareengineClusterNodeTypeConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Customized number of cores available to each node of the type.
    /// This number must always be one of &#39;nodeType.availableCustomCoreCounts&#39;.
    /// If zero is provided max value from &#39;nodeType.availableCustomCoreCounts&#39; will be used.
    /// Once the customer is created then corecount cannot be changed.
    /// </summary>
    public TerraformProperty<double>? CustomCoreCount
    {
        set => SetProperty("custom_core_count", value);
    }

    /// <summary>
    /// The number of nodes of this type in the cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeCount is required")]
    public required TerraformProperty<double> NodeCount
    {
        set => SetProperty("node_count", value);
    }

    /// <summary>
    /// The node_type_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeTypeId is required")]
    public required TerraformProperty<string> NodeTypeId
    {
        set => SetProperty("node_type_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleVmwareengineClusterTimeoutsBlock : TerraformBlock
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
/// Manages a google_vmwareengine_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleVmwareengineCluster : TerraformResource
{
    public GoogleVmwareengineCluster(string name) : base("google_vmwareengine_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("management");
        SetOutput("state");
        SetOutput("uid");
        SetOutput("update_time");
        SetOutput("id");
        SetOutput("name");
        SetOutput("parent");
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
    /// The ID of the Cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource name of the private cloud to create a new cluster in.
    /// Resource names are schemeless URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names.
    /// For example: projects/my-project/locations/us-west1-a/privateClouds/my-cloud
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformProperty<string> Parent
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parent");
        set => SetProperty("parent", value);
    }

    /// <summary>
    /// Block for autoscaling_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoscalingSettings block(s) allowed")]
    public List<GoogleVmwareengineClusterAutoscalingSettingsBlock>? AutoscalingSettings
    {
        set => SetProperty("autoscaling_settings", value);
    }

    /// <summary>
    /// Block for node_type_configs.
    /// Nesting mode: set
    /// </summary>
    public HashSet<GoogleVmwareengineClusterNodeTypeConfigsBlock>? NodeTypeConfigs
    {
        set => SetProperty("node_type_configs", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleVmwareengineClusterTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Creation time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and
    /// up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// True if the cluster is a management cluster; false otherwise.
    /// There can only be one management cluster in a private cloud and it has to be the first one.
    /// </summary>
    public TerraformExpression Management => this["management"];

    /// <summary>
    /// State of the Cluster.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// System-generated unique identifier for the resource.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// Last updated time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
