using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for autoscaling_settings in .
/// Nesting mode: list
/// </summary>
public partial class GoogleVmwareengineClusterAutoscalingSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The minimum duration between consecutive autoscale operations.
    /// It starts once addition or removal of nodes is fully completed.
    /// Minimum cool down period is 30m.
    /// Cool down period must be in whole minutes (for example, 30m, 31m, 50m).
    /// Mandatory for successful addition of autoscaling settings in cluster.
    /// </summary>
    [TerraformProperty("cool_down_period")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CoolDownPeriod { get; set; }

    /// <summary>
    /// Maximum number of nodes of any type in a cluster.
    /// Mandatory for successful addition of autoscaling settings in cluster.
    /// </summary>
    [TerraformProperty("max_cluster_node_count")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxClusterNodeCount { get; set; }

    /// <summary>
    /// Minimum number of nodes of any type in a cluster.
    /// Mandatory for successful addition of autoscaling settings in cluster.
    /// </summary>
    [TerraformProperty("min_cluster_node_count")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MinClusterNodeCount { get; set; }

}

/// <summary>
/// Block type for node_type_configs in .
/// Nesting mode: set
/// </summary>
public partial class GoogleVmwareengineClusterNodeTypeConfigsBlock : TerraformBlockBase
{
    /// <summary>
    /// Customized number of cores available to each node of the type.
    /// This number must always be one of &#39;nodeType.availableCustomCoreCounts&#39;.
    /// If zero is provided max value from &#39;nodeType.availableCustomCoreCounts&#39; will be used.
    /// Once the customer is created then corecount cannot be changed.
    /// </summary>
    [TerraformProperty("custom_core_count")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? CustomCoreCount { get; set; }

    /// <summary>
    /// The number of nodes of this type in the cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeCount is required")]
    [TerraformProperty("node_count")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> NodeCount { get; set; }

    /// <summary>
    /// The node_type_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeTypeId is required")]
    [TerraformProperty("node_type_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> NodeTypeId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleVmwareengineClusterTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_vmwareengine_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleVmwareengineCluster : TerraformResource
{
    public GoogleVmwareengineCluster(string name) : base("google_vmwareengine_cluster", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ID of the Cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource name of the private cloud to create a new cluster in.
    /// Resource names are schemeless URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names.
    /// For example: projects/my-project/locations/us-west1-a/privateClouds/my-cloud
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformProperty("parent")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Parent { get; set; }

    /// <summary>
    /// Block for autoscaling_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoscalingSettings block(s) allowed")]
    [TerraformProperty("autoscaling_settings")]
    public TerraformList<TerraformBlock<GoogleVmwareengineClusterAutoscalingSettingsBlock>>? AutoscalingSettings { get; set; }

    /// <summary>
    /// Block for node_type_configs.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("node_type_configs")]
    public TerraformSet<TerraformBlock<GoogleVmwareengineClusterNodeTypeConfigsBlock>>? NodeTypeConfigs { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleVmwareengineClusterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Creation time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and
    /// up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// True if the cluster is a management cluster; false otherwise.
    /// There can only be one management cluster in a private cloud and it has to be the first one.
    /// </summary>
    [TerraformProperty("management")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> Management { get; }

    /// <summary>
    /// State of the Cluster.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> State { get; }

    /// <summary>
    /// System-generated unique identifier for the resource.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Uid { get; }

    /// <summary>
    /// Last updated time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

}
