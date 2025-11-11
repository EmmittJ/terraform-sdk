using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for autoscaling_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleVmwareengineClusterAutoscalingSettingsBlock
{
    /// <summary>
    /// The minimum duration between consecutive autoscale operations.
    /// It starts once addition or removal of nodes is fully completed.
    /// Minimum cool down period is 30m.
    /// Cool down period must be in whole minutes (for example, 30m, 31m, 50m).
    /// Mandatory for successful addition of autoscaling settings in cluster.
    /// </summary>
    [TerraformPropertyName("cool_down_period")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CoolDownPeriod { get; set; }

    /// <summary>
    /// Maximum number of nodes of any type in a cluster.
    /// Mandatory for successful addition of autoscaling settings in cluster.
    /// </summary>
    [TerraformPropertyName("max_cluster_node_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxClusterNodeCount { get; set; }

    /// <summary>
    /// Minimum number of nodes of any type in a cluster.
    /// Mandatory for successful addition of autoscaling settings in cluster.
    /// </summary>
    [TerraformPropertyName("min_cluster_node_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MinClusterNodeCount { get; set; }

}

/// <summary>
/// Block type for node_type_configs in .
/// Nesting mode: set
/// </summary>
public class GoogleVmwareengineClusterNodeTypeConfigsBlock
{
    /// <summary>
    /// Customized number of cores available to each node of the type.
    /// This number must always be one of &#39;nodeType.availableCustomCoreCounts&#39;.
    /// If zero is provided max value from &#39;nodeType.availableCustomCoreCounts&#39; will be used.
    /// Once the customer is created then corecount cannot be changed.
    /// </summary>
    [TerraformPropertyName("custom_core_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? CustomCoreCount { get; set; }

    /// <summary>
    /// The number of nodes of this type in the cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeCount is required")]
    [TerraformPropertyName("node_count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> NodeCount { get; set; }

    /// <summary>
    /// The node_type_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeTypeId is required")]
    [TerraformPropertyName("node_type_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> NodeTypeId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleVmwareengineClusterTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_vmwareengine_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleVmwareengineCluster : TerraformResource
{
    public GoogleVmwareengineCluster(string name) : base("google_vmwareengine_cluster", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The ID of the Cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource name of the private cloud to create a new cluster in.
    /// Resource names are schemeless URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names.
    /// For example: projects/my-project/locations/us-west1-a/privateClouds/my-cloud
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformPropertyName("parent")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Parent { get; set; }

    /// <summary>
    /// Block for autoscaling_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoscalingSettings block(s) allowed")]
    [TerraformPropertyName("autoscaling_settings")]
    public TerraformList<TerraformBlock<GoogleVmwareengineClusterAutoscalingSettingsBlock>>? AutoscalingSettings { get; set; }

    /// <summary>
    /// Block for node_type_configs.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("node_type_configs")]
    public TerraformSet<TerraformBlock<GoogleVmwareengineClusterNodeTypeConfigsBlock>>? NodeTypeConfigs { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleVmwareengineClusterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Creation time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and
    /// up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// True if the cluster is a management cluster; false otherwise.
    /// There can only be one management cluster in a private cloud and it has to be the first one.
    /// </summary>
    [TerraformPropertyName("management")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Management => new TerraformReference(this, "management");

    /// <summary>
    /// State of the Cluster.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// System-generated unique identifier for the resource.
    /// </summary>
    [TerraformPropertyName("uid")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Uid => new TerraformReference(this, "uid");

    /// <summary>
    /// Last updated time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

}
