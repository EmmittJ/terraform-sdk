using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for management_cluster in GoogleVmwareenginePrivateCloud.
/// Nesting mode: list
/// </summary>
public class GoogleVmwareenginePrivateCloudManagementClusterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "management_cluster";

    /// <summary>
    /// The user-provided identifier of the new Cluster. The identifier must meet the following requirements:
    ///   * Only contains 1-63 alphanumeric characters and hyphens
    ///   * Begins with an alphabetical character
    ///   * Ends with a non-hyphen character
    ///   * Not formatted as a UUID
    ///   * Complies with RFC 1034 (https://datatracker.ietf.org/doc/html/rfc1034) (section 3.5)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    public required TerraformValue<string> ClusterId
    {
        get => GetArgument<TerraformValue<string>>("cluster_id");
        set => SetArgument("cluster_id", value);
    }

    /// <summary>
    /// AutoscalingSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoscalingSettings block(s) allowed")]
    public TerraformList<GoogleVmwareenginePrivateCloudManagementClusterBlockAutoscalingSettingsBlock>? AutoscalingSettings
    {
        get => GetArgument<TerraformList<GoogleVmwareenginePrivateCloudManagementClusterBlockAutoscalingSettingsBlock>>("autoscaling_settings");
        set => SetArgument("autoscaling_settings", value);
    }

    /// <summary>
    /// NodeTypeConfigs block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleVmwareenginePrivateCloudManagementClusterBlockNodeTypeConfigsBlock>? NodeTypeConfigs
    {
        get => GetArgument<TerraformSet<GoogleVmwareenginePrivateCloudManagementClusterBlockNodeTypeConfigsBlock>>("node_type_configs");
        set => SetArgument("node_type_configs", value);
    }

    /// <summary>
    /// StretchedClusterConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StretchedClusterConfig block(s) allowed")]
    public TerraformList<GoogleVmwareenginePrivateCloudManagementClusterBlockStretchedClusterConfigBlock>? StretchedClusterConfig
    {
        get => GetArgument<TerraformList<GoogleVmwareenginePrivateCloudManagementClusterBlockStretchedClusterConfigBlock>>("stretched_cluster_config");
        set => SetArgument("stretched_cluster_config", value);
    }

}

/// <summary>
/// Block type for autoscaling_settings in GoogleVmwareenginePrivateCloudManagementClusterBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVmwareenginePrivateCloudManagementClusterBlockAutoscalingSettingsBlock : TerraformBlock
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
    public required TerraformSet<GoogleVmwareenginePrivateCloudManagementClusterBlockAutoscalingSettingsBlockAutoscalingPoliciesBlock> AutoscalingPolicies
    {
        get => GetRequiredArgument<TerraformSet<GoogleVmwareenginePrivateCloudManagementClusterBlockAutoscalingSettingsBlockAutoscalingPoliciesBlock>>("autoscaling_policies");
        set => SetArgument("autoscaling_policies", value);
    }

}

/// <summary>
/// Block type for autoscaling_policies in GoogleVmwareenginePrivateCloudManagementClusterBlockAutoscalingSettingsBlock.
/// Nesting mode: set
/// </summary>
public class GoogleVmwareenginePrivateCloudManagementClusterBlockAutoscalingSettingsBlockAutoscalingPoliciesBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("autoscale_policy_id");
        set => SetArgument("autoscale_policy_id", value);
    }

    /// <summary>
    /// The canonical identifier of the node type to add or remove.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeTypeId is required")]
    public required TerraformValue<string> NodeTypeId
    {
        get => GetArgument<TerraformValue<string>>("node_type_id");
        set => SetArgument("node_type_id", value);
    }

    /// <summary>
    /// Number of nodes to add to a cluster during a scale-out operation.
    /// Must be divisible by 2 for stretched clusters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScaleOutSize is required")]
    public required TerraformValue<double> ScaleOutSize
    {
        get => GetArgument<TerraformValue<double>>("scale_out_size");
        set => SetArgument("scale_out_size", value);
    }

    /// <summary>
    /// ConsumedMemoryThresholds block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConsumedMemoryThresholds block(s) allowed")]
    public TerraformList<GoogleVmwareenginePrivateCloudManagementClusterBlockAutoscalingSettingsBlockAutoscalingPoliciesBlockConsumedMemoryThresholdsBlock>? ConsumedMemoryThresholds
    {
        get => GetArgument<TerraformList<GoogleVmwareenginePrivateCloudManagementClusterBlockAutoscalingSettingsBlockAutoscalingPoliciesBlockConsumedMemoryThresholdsBlock>>("consumed_memory_thresholds");
        set => SetArgument("consumed_memory_thresholds", value);
    }

    /// <summary>
    /// CpuThresholds block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CpuThresholds block(s) allowed")]
    public TerraformList<GoogleVmwareenginePrivateCloudManagementClusterBlockAutoscalingSettingsBlockAutoscalingPoliciesBlockCpuThresholdsBlock>? CpuThresholds
    {
        get => GetArgument<TerraformList<GoogleVmwareenginePrivateCloudManagementClusterBlockAutoscalingSettingsBlockAutoscalingPoliciesBlockCpuThresholdsBlock>>("cpu_thresholds");
        set => SetArgument("cpu_thresholds", value);
    }

    /// <summary>
    /// StorageThresholds block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageThresholds block(s) allowed")]
    public TerraformList<GoogleVmwareenginePrivateCloudManagementClusterBlockAutoscalingSettingsBlockAutoscalingPoliciesBlockStorageThresholdsBlock>? StorageThresholds
    {
        get => GetArgument<TerraformList<GoogleVmwareenginePrivateCloudManagementClusterBlockAutoscalingSettingsBlockAutoscalingPoliciesBlockStorageThresholdsBlock>>("storage_thresholds");
        set => SetArgument("storage_thresholds", value);
    }

}

/// <summary>
/// Block type for consumed_memory_thresholds in GoogleVmwareenginePrivateCloudManagementClusterBlockAutoscalingSettingsBlockAutoscalingPoliciesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVmwareenginePrivateCloudManagementClusterBlockAutoscalingSettingsBlockAutoscalingPoliciesBlockConsumedMemoryThresholdsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<double>>("scale_in");
        set => SetArgument("scale_in", value);
    }

    /// <summary>
    /// The utilization triggering the scale-out operation in percent.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScaleOut is required")]
    public required TerraformValue<double> ScaleOut
    {
        get => GetArgument<TerraformValue<double>>("scale_out");
        set => SetArgument("scale_out", value);
    }

}

/// <summary>
/// Block type for cpu_thresholds in GoogleVmwareenginePrivateCloudManagementClusterBlockAutoscalingSettingsBlockAutoscalingPoliciesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVmwareenginePrivateCloudManagementClusterBlockAutoscalingSettingsBlockAutoscalingPoliciesBlockCpuThresholdsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<double>>("scale_in");
        set => SetArgument("scale_in", value);
    }

    /// <summary>
    /// The utilization triggering the scale-out operation in percent.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScaleOut is required")]
    public required TerraformValue<double> ScaleOut
    {
        get => GetArgument<TerraformValue<double>>("scale_out");
        set => SetArgument("scale_out", value);
    }

}

/// <summary>
/// Block type for storage_thresholds in GoogleVmwareenginePrivateCloudManagementClusterBlockAutoscalingSettingsBlockAutoscalingPoliciesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVmwareenginePrivateCloudManagementClusterBlockAutoscalingSettingsBlockAutoscalingPoliciesBlockStorageThresholdsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<double>>("scale_in");
        set => SetArgument("scale_in", value);
    }

    /// <summary>
    /// The utilization triggering the scale-out operation in percent.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScaleOut is required")]
    public required TerraformValue<double> ScaleOut
    {
        get => GetArgument<TerraformValue<double>>("scale_out");
        set => SetArgument("scale_out", value);
    }

}

/// <summary>
/// Block type for node_type_configs in GoogleVmwareenginePrivateCloudManagementClusterBlock.
/// Nesting mode: set
/// </summary>
public class GoogleVmwareenginePrivateCloudManagementClusterBlockNodeTypeConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "node_type_configs";

    /// <summary>
    /// Customized number of cores available to each node of the type.
    /// This number must always be one of &#39;nodeType.availableCustomCoreCounts&#39;.
    /// If zero is provided max value from &#39;nodeType.availableCustomCoreCounts&#39; will be used.
    /// This cannot be changed once the PrivateCloud is created.
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
        get => GetArgument<TerraformValue<double>>("node_count");
        set => SetArgument("node_count", value);
    }

    /// <summary>
    /// The node_type_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeTypeId is required")]
    public required TerraformValue<string> NodeTypeId
    {
        get => GetArgument<TerraformValue<string>>("node_type_id");
        set => SetArgument("node_type_id", value);
    }

}

/// <summary>
/// Block type for stretched_cluster_config in GoogleVmwareenginePrivateCloudManagementClusterBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVmwareenginePrivateCloudManagementClusterBlockStretchedClusterConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "stretched_cluster_config";

    /// <summary>
    /// Zone that will remain operational when connection between the two zones is lost.
    /// Specify the zone in the following format: projects/{project}/locations/{location}.
    /// </summary>
    public TerraformValue<string>? PreferredLocation
    {
        get => GetArgument<TerraformValue<string>>("preferred_location");
        set => SetArgument("preferred_location", value);
    }

    /// <summary>
    /// Additional zone for a higher level of availability and load balancing.
    /// Specify the zone in the following format: projects/{project}/locations/{location}.
    /// </summary>
    public TerraformValue<string>? SecondaryLocation
    {
        get => GetArgument<TerraformValue<string>>("secondary_location");
        set => SetArgument("secondary_location", value);
    }

}


/// <summary>
/// Block type for network_config in GoogleVmwareenginePrivateCloud.
/// Nesting mode: list
/// </summary>
public class GoogleVmwareenginePrivateCloudNetworkConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_config";

    /// <summary>
    /// DNS Server IP of the Private Cloud.
    /// </summary>
    public TerraformValue<string> DnsServerIp
        => AsReference("dns_server_ip");

    /// <summary>
    /// Management CIDR used by VMware management appliances.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagementCidr is required")]
    public required TerraformValue<string> ManagementCidr
    {
        get => GetArgument<TerraformValue<string>>("management_cidr");
        set => SetArgument("management_cidr", value);
    }

    /// <summary>
    /// The IP address layout version of the management IP address range.
    /// Possible versions include:
    /// * managementIpAddressLayoutVersion=1: Indicates the legacy IP address layout used by some existing private clouds. This is no longer supported for new private clouds
    /// as it does not support all features.
    /// * managementIpAddressLayoutVersion=2: Indicates the latest IP address layout
    /// used by all newly created private clouds. This version supports all current features.
    /// </summary>
    public TerraformValue<double> ManagementIpAddressLayoutVersion
        => AsReference("management_ip_address_layout_version");

    /// <summary>
    /// The relative resource name of the VMware Engine network attached to the private cloud.
    /// Specify the name in the following form: projects/{project}/locations/{location}/vmwareEngineNetworks/{vmwareEngineNetworkId}
    /// where {project} can either be a project number or a project ID.
    /// </summary>
    public TerraformValue<string>? VmwareEngineNetwork
    {
        get => GetArgument<TerraformValue<string>>("vmware_engine_network");
        set => SetArgument("vmware_engine_network", value);
    }

    /// <summary>
    /// The canonical name of the VMware Engine network in
    /// the form: projects/{project_number}/locations/{location}/vmwareEngineNetworks/{vmwareEngineNetworkId}
    /// </summary>
    public TerraformValue<string> VmwareEngineNetworkCanonical
        => AsReference("vmware_engine_network_canonical");

}


/// <summary>
/// Block type for timeouts in GoogleVmwareenginePrivateCloud.
/// Nesting mode: single
/// </summary>
public class GoogleVmwareenginePrivateCloudTimeoutsBlock : TerraformBlock
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
/// Represents a google_vmwareengine_private_cloud Terraform resource.
/// Manages a google_vmwareengine_private_cloud resource.
/// </summary>
public partial class GoogleVmwareenginePrivateCloud(string name) : TerraformResource("google_vmwareengine_private_cloud", name)
{
    /// <summary>
    /// The number of hours to delay this request. You can set this value to an hour between 0 to 8, where setting it to 0 starts the deletion request immediately. If no value is set, a default value is set at the API Level.
    /// </summary>
    public TerraformValue<double>? DeletionDelayHours
    {
        get => GetArgument<TerraformValue<double>>("deletion_delay_hours");
        set => SetArgument("deletion_delay_hours", value);
    }

    /// <summary>
    /// User-provided description for this private cloud.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location where the PrivateCloud should reside.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The ID of the PrivateCloud.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// While set true, deletion_delay_hours value will be sent in the request even for zero value of the field. This field is only useful for setting 0 value to the deletion_delay_hours field. It can be used both alone and together with deletion_delay_hours.
    /// </summary>
    public TerraformValue<bool>? SendDeletionDelayHoursIfZero
    {
        get => GetArgument<TerraformValue<bool>>("send_deletion_delay_hours_if_zero");
        set => SetArgument("send_deletion_delay_hours_if_zero", value);
    }

    /// <summary>
    /// Initial type of the private cloud. Possible values: [&amp;quot;STANDARD&amp;quot;, &amp;quot;TIME_LIMITED&amp;quot;, &amp;quot;STRETCHED&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Creation time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// Time when the resource was scheduled for deletion.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> DeleteTime
        => AsReference("delete_time");

    /// <summary>
    /// Time when the resource will be irreversibly deleted.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> ExpireTime
        => AsReference("expire_time");

    /// <summary>
    /// Details about a HCX Cloud Manager appliance.
    /// </summary>
    public TerraformList<TerraformMap<object>> Hcx
        => AsReference("hcx");

    /// <summary>
    /// Details about a NSX Manager appliance.
    /// </summary>
    public TerraformList<TerraformMap<object>> Nsx
        => AsReference("nsx");

    /// <summary>
    /// State of the resource. New values may be added to this enum when appropriate.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// System-generated unique identifier for the resource.
    /// </summary>
    public TerraformValue<string> Uid
        => AsReference("uid");

    /// <summary>
    /// Last update time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Details about a vCenter Server management appliance.
    /// </summary>
    public TerraformList<TerraformMap<object>> Vcenter
        => AsReference("vcenter");

    /// <summary>
    /// ManagementCluster block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagementCluster is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ManagementCluster block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagementCluster block(s) allowed")]
    public required TerraformList<GoogleVmwareenginePrivateCloudManagementClusterBlock> ManagementCluster
    {
        get => GetRequiredArgument<TerraformList<GoogleVmwareenginePrivateCloudManagementClusterBlock>>("management_cluster");
        set => SetArgument("management_cluster", value);
    }

    /// <summary>
    /// NetworkConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    public required TerraformList<GoogleVmwareenginePrivateCloudNetworkConfigBlock> NetworkConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleVmwareenginePrivateCloudNetworkConfigBlock>>("network_config");
        set => SetArgument("network_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleVmwareenginePrivateCloudTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleVmwareenginePrivateCloudTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
