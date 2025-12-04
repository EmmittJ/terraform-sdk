using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleNetworkManagementVpcFlowLogsConfig.
/// Nesting mode: single
/// </summary>
public class GoogleNetworkManagementVpcFlowLogsConfigTimeoutsBlock : TerraformBlock
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
/// Represents a google_network_management_vpc_flow_logs_config Terraform resource.
/// Manages a google_network_management_vpc_flow_logs_config resource.
/// </summary>
public partial class GoogleNetworkManagementVpcFlowLogsConfig(string name) : TerraformResource("google_network_management_vpc_flow_logs_config", name)
{
    /// <summary>
    /// Optional. The aggregation interval for the logs. Default value is
    /// INTERVAL_5_SEC.   Possible values:  AGGREGATION_INTERVAL_UNSPECIFIED INTERVAL_5_SEC INTERVAL_30_SEC INTERVAL_1_MIN INTERVAL_5_MIN INTERVAL_10_MIN INTERVAL_15_MIN
    /// </summary>
    public TerraformValue<string>? AggregationInterval
    {
        get => GetArgument<TerraformValue<string>>("aggregation_interval");
        set => SetArgument("aggregation_interval", value);
    }

    /// <summary>
    /// Optional. The user-supplied description of the VPC Flow Logs configuration. Maximum
    /// of 512 characters.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Optional. Export filter used to define which VPC Flow Logs should be logged.
    /// </summary>
    public TerraformValue<string>? FilterExpr
    {
        get => GetArgument<TerraformValue<string>>("filter_expr");
        set => SetArgument("filter_expr", value);
    }

    /// <summary>
    /// Optional. The value of the field must be in (0, 1]. The sampling rate
    /// of VPC Flow Logs where 1.0 means all collected logs are reported. Setting the
    /// sampling rate to 0.0 is not allowed. If you want to disable VPC Flow Logs, use
    /// the state field instead. Default value is 1.0.
    /// </summary>
    public TerraformValue<double>? FlowSampling
    {
        get => GetArgument<TerraformValue<double>>("flow_sampling");
        set => SetArgument("flow_sampling", value);
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
    /// Traffic will be logged from the Interconnect Attachment. Format: projects/{project_id}/regions/{region}/interconnectAttachments/{name}
    /// </summary>
    public TerraformValue<string>? InterconnectAttachment
    {
        get => GetArgument<TerraformValue<string>>("interconnect_attachment");
        set => SetArgument("interconnect_attachment", value);
    }

    /// <summary>
    /// Optional. Resource labels to represent user-provided metadata.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource
    /// within its parent collection as described in https://google.aip.dev/122. See documentation
    /// for resource type &#39;networkmanagement.googleapis.com/VpcFlowLogsConfig&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Optional. Configures whether all, none or a subset of metadata fields
    /// should be added to the reported VPC flow logs. Default value is INCLUDE_ALL_METADATA.
    ///   Possible values:  METADATA_UNSPECIFIED INCLUDE_ALL_METADATA EXCLUDE_ALL_METADATA CUSTOM_METADATA
    /// </summary>
    public TerraformValue<string>? Metadata
    {
        get => GetArgument<TerraformValue<string>>("metadata");
        set => SetArgument("metadata", value);
    }

    /// <summary>
    /// Optional. Custom metadata fields to include in the reported VPC flow
    /// logs. Can only be specified if \&amp;quot;metadata\&amp;quot; was set to CUSTOM_METADATA.
    /// </summary>
    public TerraformList<string>? MetadataFields
    {
        get => GetArgument<TerraformList<string>>("metadata_fields");
        set => SetArgument("metadata_fields", value);
    }

    /// <summary>
    /// Traffic will be logged from VMs, VPN tunnels and Interconnect Attachments within the network. Format: projects/{project_id}/global/networks/{name}
    /// </summary>
    public TerraformValue<string>? Network
    {
        get => GetArgument<TerraformValue<string>>("network");
        set => SetArgument("network", value);
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
    /// Optional. The state of the VPC Flow Log configuration. Default value
    /// is ENABLED. When creating a new configuration, it must be enabled.
    /// Possible values: STATE_UNSPECIFIED ENABLED DISABLED
    /// </summary>
    public TerraformValue<string>? State
    {
        get => GetArgument<TerraformValue<string>>("state");
        set => SetArgument("state", value);
    }

    /// <summary>
    /// Traffic will be logged from VMs within the subnetwork. Format: projects/{project_id}/regions/{region}/subnetworks/{name}
    /// </summary>
    public TerraformValue<string>? Subnet
    {
        get => GetArgument<TerraformValue<string>>("subnet");
        set => SetArgument("subnet", value);
    }

    /// <summary>
    /// Required. ID of the &#39;VpcFlowLogsConfig&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcFlowLogsConfigId is required")]
    public required TerraformValue<string> VpcFlowLogsConfigId
    {
        get => GetArgument<TerraformValue<string>>("vpc_flow_logs_config_id");
        set => SetArgument("vpc_flow_logs_config_id", value);
    }

    /// <summary>
    /// Traffic will be logged from the VPN Tunnel. Format: projects/{project_id}/regions/{region}/vpnTunnels/{name}
    /// </summary>
    public TerraformValue<string>? VpnTunnel
    {
        get => GetArgument<TerraformValue<string>>("vpn_tunnel");
        set => SetArgument("vpn_tunnel", value);
    }

    /// <summary>
    /// Output only. The time the config was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// Identifier. Unique name of the configuration using the form:     &#39;projects/{project_id}/locations/global/vpcFlowLogsConfigs/{vpc_flow_logs_config_id}&#39;
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// Describes the state of the configured target resource for diagnostic
    /// purposes.
    /// Possible values:
    /// TARGET_RESOURCE_STATE_UNSPECIFIED
    /// TARGET_RESOURCE_EXISTS
    /// TARGET_RESOURCE_DOES_NOT_EXIST
    /// </summary>
    public TerraformValue<string> TargetResourceState
        => AsReference("target_resource_state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// Output only. The time the config was updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleNetworkManagementVpcFlowLogsConfigTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleNetworkManagementVpcFlowLogsConfigTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
