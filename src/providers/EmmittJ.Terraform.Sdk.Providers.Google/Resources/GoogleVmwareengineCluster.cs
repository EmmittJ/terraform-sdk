using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for autoscaling_settings in GoogleVmwareengineCluster.
/// Nesting mode: list
/// </summary>
public class GoogleVmwareengineClusterAutoscalingSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "autoscaling_settings";

    /// <summary>
    /// The minimum duration between consecutive autoscale operations.
    /// It starts once addition or removal of nodes is fully completed.
    /// Minimum cool down period is 30m.
    /// Cool down period must be in whole minutes (for example, 30m, 31m, 50m).
    /// Mandatory for successful addition of autoscaling settings in cluster.
    /// </summary>
    public TerraformValue<string>? CoolDownPeriod
    {
        get => GetArgument<TerraformValue<string>>("cool_down_period");
        set => SetArgument("cool_down_period", value);
    }

    /// <summary>
    /// Maximum number of nodes of any type in a cluster.
    /// Mandatory for successful addition of autoscaling settings in cluster.
    /// </summary>
    public TerraformValue<double>? MaxClusterNodeCount
    {
        get => GetArgument<TerraformValue<double>>("max_cluster_node_count");
        set => SetArgument("max_cluster_node_count", value);
    }

    /// <summary>
    /// Minimum number of nodes of any type in a cluster.
    /// Mandatory for successful addition of autoscaling settings in cluster.
    /// </summary>
    public TerraformValue<double>? MinClusterNodeCount
    {
        get => GetArgument<TerraformValue<double>>("min_cluster_node_count");
        set => SetArgument("min_cluster_node_count", value);
    }

    /// <summary>
    /// AutoscalingPolicies block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoscalingPolicies is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AutoscalingPolicies block(s) required")]
    public required TerraformSet<GoogleVmwareengineClusterAutoscalingSettingsBlockAutoscalingPoliciesBlock> AutoscalingPolicies
    {
        get => GetRequiredArgument<TerraformSet<GoogleVmwareengineClusterAutoscalingSettingsBlockAutoscalingPoliciesBlock>>("autoscaling_policies");
        set => SetArgument("autoscaling_policies", value);
    }

}

/// <summary>
/// Block type for autoscaling_policies in GoogleVmwareengineClusterAutoscalingSettingsBlock.
/// Nesting mode: set
/// </summary>
public class GoogleVmwareengineClusterAutoscalingSettingsBlockAutoscalingPoliciesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "autoscaling_policies";

    /// <summary>
    /// The autoscale_policy_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoscalePolicyId is required")]
    public required TerraformValue<string> AutoscalePolicyId
    {
        get => GetRequiredArgument<TerraformValue<string>>("autoscale_policy_id");
        set => SetArgument("autoscale_policy_id", value);
    }

    /// <summary>
    /// The canonical identifier of the node type to add or remove.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeTypeId is required")]
    public required TerraformValue<string> NodeTypeId
    {
        get => GetRequiredArgument<TerraformValue<string>>("node_type_id");
        set => SetArgument("node_type_id", value);
    }

    /// <summary>
    /// Number of nodes to add to a cluster during a scale-out operation.
    /// Must be divisible by 2 for stretched clusters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScaleOutSize is required")]
    public required TerraformValue<double> ScaleOutSize
    {
        get => GetRequiredArgument<TerraformValue<double>>("scale_out_size");
        set => SetArgument("scale_out_size", value);
    }

    /// <summary>
    /// ConsumedMemoryThresholds block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConsumedMemoryThresholds block(s) allowed")]
    public TerraformList<GoogleVmwareengineClusterAutoscalingSettingsBlockAutoscalingPoliciesBlockConsumedMemoryThresholdsBlock>? ConsumedMemoryThresholds
    {
        get => GetArgument<TerraformList<GoogleVmwareengineClusterAutoscalingSettingsBlockAutoscalingPoliciesBlockConsumedMemoryThresholdsBlock>>("consumed_memory_thresholds");
        set => SetArgument("consumed_memory_thresholds", value);
    }

    /// <summary>
    /// CpuThresholds block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CpuThresholds block(s) allowed")]
    public TerraformList<GoogleVmwareengineClusterAutoscalingSettingsBlockAutoscalingPoliciesBlockCpuThresholdsBlock>? CpuThresholds
    {
        get => GetArgument<TerraformList<GoogleVmwareengineClusterAutoscalingSettingsBlockAutoscalingPoliciesBlockCpuThresholdsBlock>>("cpu_thresholds");
        set => SetArgument("cpu_thresholds", value);
    }

    /// <summary>
    /// StorageThresholds block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageThresholds block(s) allowed")]
    public TerraformList<GoogleVmwareengineClusterAutoscalingSettingsBlockAutoscalingPoliciesBlockStorageThresholdsBlock>? StorageThresholds
    {
        get => GetArgument<TerraformList<GoogleVmwareengineClusterAutoscalingSettingsBlockAutoscalingPoliciesBlockStorageThresholdsBlock>>("storage_thresholds");
        set => SetArgument("storage_thresholds", value);
    }

}

/// <summary>
/// Block type for consumed_memory_thresholds in GoogleVmwareengineClusterAutoscalingSettingsBlockAutoscalingPoliciesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVmwareengineClusterAutoscalingSettingsBlockAutoscalingPoliciesBlockConsumedMemoryThresholdsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "consumed_memory_thresholds";

    /// <summary>
    /// The utilization triggering the scale-in operation in percent.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScaleIn is required")]
    public required TerraformValue<double> ScaleIn
    {
        get => GetRequiredArgument<TerraformValue<double>>("scale_in");
        set => SetArgument("scale_in", value);
    }

    /// <summary>
    /// The utilization triggering the scale-out operation in percent.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScaleOut is required")]
    public required TerraformValue<double> ScaleOut
    {
        get => GetRequiredArgument<TerraformValue<double>>("scale_out");
        set => SetArgument("scale_out", value);
    }

}

/// <summary>
/// Block type for cpu_thresholds in GoogleVmwareengineClusterAutoscalingSettingsBlockAutoscalingPoliciesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVmwareengineClusterAutoscalingSettingsBlockAutoscalingPoliciesBlockCpuThresholdsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cpu_thresholds";

    /// <summary>
    /// The utilization triggering the scale-in operation in percent.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScaleIn is required")]
    public required TerraformValue<double> ScaleIn
    {
        get => GetRequiredArgument<TerraformValue<double>>("scale_in");
        set => SetArgument("scale_in", value);
    }

    /// <summary>
    /// The utilization triggering the scale-out operation in percent.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScaleOut is required")]
    public required TerraformValue<double> ScaleOut
    {
        get => GetRequiredArgument<TerraformValue<double>>("scale_out");
        set => SetArgument("scale_out", value);
    }

}

/// <summary>
/// Block type for storage_thresholds in GoogleVmwareengineClusterAutoscalingSettingsBlockAutoscalingPoliciesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVmwareengineClusterAutoscalingSettingsBlockAutoscalingPoliciesBlockStorageThresholdsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_thresholds";

    /// <summary>
    /// The utilization triggering the scale-in operation in percent.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScaleIn is required")]
    public required TerraformValue<double> ScaleIn
    {
        get => GetRequiredArgument<TerraformValue<double>>("scale_in");
        set => SetArgument("scale_in", value);
    }

    /// <summary>
    /// The utilization triggering the scale-out operation in percent.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScaleOut is required")]
    public required TerraformValue<double> ScaleOut
    {
        get => GetRequiredArgument<TerraformValue<double>>("scale_out");
        set => SetArgument("scale_out", value);
    }

}


/// <summary>
/// Block type for node_type_configs in GoogleVmwareengineCluster.
/// Nesting mode: set
/// </summary>
public class GoogleVmwareengineClusterNodeTypeConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "node_type_configs";

    /// <summary>
    /// Customized number of cores available to each node of the type.
    /// This number must always be one of &#39;nodeType.availableCustomCoreCounts&#39;.
    /// If zero is provided max value from &#39;nodeType.availableCustomCoreCounts&#39; will be used.
    /// Once the customer is created then corecount cannot be changed.
    /// </summary>
    public TerraformValue<double>? CustomCoreCount
    {
        get => GetArgument<TerraformValue<double>>("custom_core_count");
        set => SetArgument("custom_core_count", value);
    }

    /// <summary>
    /// The number of nodes of this type in the cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeCount is required")]
    public required TerraformValue<double> NodeCount
    {
        get => GetRequiredArgument<TerraformValue<double>>("node_count");
        set => SetArgument("node_count", value);
    }

    /// <summary>
    /// The node_type_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeTypeId is required")]
    public required TerraformValue<string> NodeTypeId
    {
        get => GetRequiredArgument<TerraformValue<string>>("node_type_id");
        set => SetArgument("node_type_id", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleVmwareengineCluster.
/// Nesting mode: single
/// </summary>
public class GoogleVmwareengineClusterTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_vmwareengine_cluster Terraform resource.
/// Manages a google_vmwareengine_cluster resource.
/// </summary>
public partial class GoogleVmwareengineCluster(string name) : TerraformResource("google_vmwareengine_cluster", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ID of the Cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource name of the private cloud to create a new cluster in.
    /// Resource names are schemeless URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names.
    /// For example: projects/my-project/locations/us-west1-a/privateClouds/my-cloud
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformValue<string> Parent
    {
        get => GetRequiredArgument<TerraformValue<string>>("parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// Creation time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and
    /// up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> CreateTime
        => CreateReference("create_time");

    /// <summary>
    /// True if the cluster is a management cluster; false otherwise.
    /// There can only be one management cluster in a private cloud and it has to be the first one.
    /// </summary>
    public TerraformValue<bool> Management
        => CreateReference("management");

    /// <summary>
    /// State of the Cluster.
    /// </summary>
    public TerraformValue<string> State
        => CreateReference("state");

    /// <summary>
    /// System-generated unique identifier for the resource.
    /// </summary>
    public TerraformValue<string> Uid
        => CreateReference("uid");

    /// <summary>
    /// Last updated time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => CreateReference("update_time");

    /// <summary>
    /// AutoscalingSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoscalingSettings block(s) allowed")]
    public TerraformList<GoogleVmwareengineClusterAutoscalingSettingsBlock>? AutoscalingSettings
    {
        get => GetArgument<TerraformList<GoogleVmwareengineClusterAutoscalingSettingsBlock>>("autoscaling_settings");
        set => SetArgument("autoscaling_settings", value);
    }

    /// <summary>
    /// NodeTypeConfigs block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleVmwareengineClusterNodeTypeConfigsBlock>? NodeTypeConfigs
    {
        get => GetArgument<TerraformSet<GoogleVmwareengineClusterNodeTypeConfigsBlock>>("node_type_configs");
        set => SetArgument("node_type_configs", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleVmwareengineClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleVmwareengineClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
