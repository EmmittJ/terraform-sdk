using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetworkManagementVpcFlowLogsConfigTimeoutsBlock : TerraformBlock
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
/// Manages a google_network_management_vpc_flow_logs_config resource.
/// </summary>
public class GoogleNetworkManagementVpcFlowLogsConfig : TerraformResource
{
    public GoogleNetworkManagementVpcFlowLogsConfig(string name) : base("google_network_management_vpc_flow_logs_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("effective_labels");
        SetOutput("name");
        SetOutput("target_resource_state");
        SetOutput("terraform_labels");
        SetOutput("update_time");
        SetOutput("aggregation_interval");
        SetOutput("description");
        SetOutput("filter_expr");
        SetOutput("flow_sampling");
        SetOutput("id");
        SetOutput("interconnect_attachment");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("metadata");
        SetOutput("metadata_fields");
        SetOutput("network");
        SetOutput("project");
        SetOutput("state");
        SetOutput("subnet");
        SetOutput("vpc_flow_logs_config_id");
        SetOutput("vpn_tunnel");
    }

    /// <summary>
    /// Optional. The aggregation interval for the logs. Default value is
    /// INTERVAL_5_SEC.   Possible values:  AGGREGATION_INTERVAL_UNSPECIFIED INTERVAL_5_SEC INTERVAL_30_SEC INTERVAL_1_MIN INTERVAL_5_MIN INTERVAL_10_MIN INTERVAL_15_MIN
    /// </summary>
    public TerraformProperty<string> AggregationInterval
    {
        get => GetRequiredOutput<TerraformProperty<string>>("aggregation_interval");
        set => SetProperty("aggregation_interval", value);
    }

    /// <summary>
    /// Optional. The user-supplied description of the VPC Flow Logs configuration. Maximum
    /// of 512 characters.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// Optional. Export filter used to define which VPC Flow Logs should be logged.
    /// </summary>
    public TerraformProperty<string> FilterExpr
    {
        get => GetRequiredOutput<TerraformProperty<string>>("filter_expr");
        set => SetProperty("filter_expr", value);
    }

    /// <summary>
    /// Optional. The value of the field must be in (0, 1]. The sampling rate
    /// of VPC Flow Logs where 1.0 means all collected logs are reported. Setting the
    /// sampling rate to 0.0 is not allowed. If you want to disable VPC Flow Logs, use
    /// the state field instead. Default value is 1.0.
    /// </summary>
    public TerraformProperty<double> FlowSampling
    {
        get => GetRequiredOutput<TerraformProperty<double>>("flow_sampling");
        set => SetProperty("flow_sampling", value);
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
    /// Traffic will be logged from the Interconnect Attachment. Format: projects/{project_id}/regions/{region}/interconnectAttachments/{name}
    /// </summary>
    public TerraformProperty<string> InterconnectAttachment
    {
        get => GetRequiredOutput<TerraformProperty<string>>("interconnect_attachment");
        set => SetProperty("interconnect_attachment", value);
    }

    /// <summary>
    /// Optional. Resource labels to represent user-provided metadata.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource
    /// within its parent collection as described in https://google.aip.dev/122. See documentation
    /// for resource type &#39;networkmanagement.googleapis.com/VpcFlowLogsConfig&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// Optional. Configures whether all, none or a subset of metadata fields
    /// should be added to the reported VPC flow logs. Default value is INCLUDE_ALL_METADATA.
    ///   Possible values:  METADATA_UNSPECIFIED INCLUDE_ALL_METADATA EXCLUDE_ALL_METADATA CUSTOM_METADATA
    /// </summary>
    public TerraformProperty<string> Metadata
    {
        get => GetRequiredOutput<TerraformProperty<string>>("metadata");
        set => SetProperty("metadata", value);
    }

    /// <summary>
    /// Optional. Custom metadata fields to include in the reported VPC flow
    /// logs. Can only be specified if \&amp;quot;metadata\&amp;quot; was set to CUSTOM_METADATA.
    /// </summary>
    public List<TerraformProperty<string>> MetadataFields
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("metadata_fields");
        set => SetProperty("metadata_fields", value);
    }

    /// <summary>
    /// Traffic will be logged from VMs, VPN tunnels and Interconnect Attachments within the network. Format: projects/{project_id}/global/networks/{name}
    /// </summary>
    public TerraformProperty<string> Network
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network");
        set => SetProperty("network", value);
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
    /// Optional. The state of the VPC Flow Log configuration. Default value
    /// is ENABLED. When creating a new configuration, it must be enabled.
    /// Possible values: STATE_UNSPECIFIED ENABLED DISABLED
    /// </summary>
    public TerraformProperty<string> State
    {
        get => GetRequiredOutput<TerraformProperty<string>>("state");
        set => SetProperty("state", value);
    }

    /// <summary>
    /// Traffic will be logged from VMs within the subnetwork. Format: projects/{project_id}/regions/{region}/subnetworks/{name}
    /// </summary>
    public TerraformProperty<string> Subnet
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subnet");
        set => SetProperty("subnet", value);
    }

    /// <summary>
    /// Required. ID of the &#39;VpcFlowLogsConfig&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcFlowLogsConfigId is required")]
    public required TerraformProperty<string> VpcFlowLogsConfigId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vpc_flow_logs_config_id");
        set => SetProperty("vpc_flow_logs_config_id", value);
    }

    /// <summary>
    /// Traffic will be logged from the VPN Tunnel. Format: projects/{project_id}/regions/{region}/vpnTunnels/{name}
    /// </summary>
    public TerraformProperty<string> VpnTunnel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vpn_tunnel");
        set => SetProperty("vpn_tunnel", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleNetworkManagementVpcFlowLogsConfigTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Output only. The time the config was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Identifier. Unique name of the configuration using the form:     &#39;projects/{project_id}/locations/global/vpcFlowLogsConfigs/{vpc_flow_logs_config_id}&#39;
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Describes the state of the configured target resource for diagnostic
    /// purposes.
    /// Possible values:
    /// TARGET_RESOURCE_STATE_UNSPECIFIED
    /// TARGET_RESOURCE_EXISTS
    /// TARGET_RESOURCE_DOES_NOT_EXIST
    /// </summary>
    public TerraformExpression TargetResourceState => this["target_resource_state"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Output only. The time the config was updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
