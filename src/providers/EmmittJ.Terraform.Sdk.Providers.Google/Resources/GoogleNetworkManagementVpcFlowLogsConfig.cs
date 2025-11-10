using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetworkManagementVpcFlowLogsConfigTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_network_management_vpc_flow_logs_config resource.
/// </summary>
public class GoogleNetworkManagementVpcFlowLogsConfig : TerraformResource
{
    public GoogleNetworkManagementVpcFlowLogsConfig(string name) : base("google_network_management_vpc_flow_logs_config", name)
    {
    }

    /// <summary>
    /// Optional. The aggregation interval for the logs. Default value is
    /// INTERVAL_5_SEC.   Possible values:  AGGREGATION_INTERVAL_UNSPECIFIED INTERVAL_5_SEC INTERVAL_30_SEC INTERVAL_1_MIN INTERVAL_5_MIN INTERVAL_10_MIN INTERVAL_15_MIN
    /// </summary>
    [TerraformPropertyName("aggregation_interval")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AggregationInterval { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "aggregation_interval");

    /// <summary>
    /// Optional. The user-supplied description of the VPC Flow Logs configuration. Maximum
    /// of 512 characters.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// Optional. Export filter used to define which VPC Flow Logs should be logged.
    /// </summary>
    [TerraformPropertyName("filter_expr")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FilterExpr { get; set; }

    /// <summary>
    /// Optional. The value of the field must be in (0, 1]. The sampling rate
    /// of VPC Flow Logs where 1.0 means all collected logs are reported. Setting the
    /// sampling rate to 0.0 is not allowed. If you want to disable VPC Flow Logs, use
    /// the state field instead. Default value is 1.0.
    /// </summary>
    [TerraformPropertyName("flow_sampling")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> FlowSampling { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "flow_sampling");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Traffic will be logged from the Interconnect Attachment. Format: projects/{project_id}/regions/{region}/interconnectAttachments/{name}
    /// </summary>
    [TerraformPropertyName("interconnect_attachment")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? InterconnectAttachment { get; set; }

    /// <summary>
    /// Optional. Resource labels to represent user-provided metadata.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource
    /// within its parent collection as described in https://google.aip.dev/122. See documentation
    /// for resource type &#39;networkmanagement.googleapis.com/VpcFlowLogsConfig&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// Optional. Configures whether all, none or a subset of metadata fields
    /// should be added to the reported VPC flow logs. Default value is INCLUDE_ALL_METADATA.
    ///   Possible values:  METADATA_UNSPECIFIED INCLUDE_ALL_METADATA EXCLUDE_ALL_METADATA CUSTOM_METADATA
    /// </summary>
    [TerraformPropertyName("metadata")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Metadata { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "metadata");

    /// <summary>
    /// Optional. Custom metadata fields to include in the reported VPC flow
    /// logs. Can only be specified if \&amp;quot;metadata\&amp;quot; was set to CUSTOM_METADATA.
    /// </summary>
    [TerraformPropertyName("metadata_fields")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? MetadataFields { get; set; }

    /// <summary>
    /// Traffic will be logged from VMs, VPN tunnels and Interconnect Attachments within the network. Format: projects/{project_id}/global/networks/{name}
    /// </summary>
    [TerraformPropertyName("network")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Network { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Optional. The state of the VPC Flow Log configuration. Default value
    /// is ENABLED. When creating a new configuration, it must be enabled.
    /// Possible values: STATE_UNSPECIFIED ENABLED DISABLED
    /// </summary>
    [TerraformPropertyName("state")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> State { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// Traffic will be logged from VMs within the subnetwork. Format: projects/{project_id}/regions/{region}/subnetworks/{name}
    /// </summary>
    [TerraformPropertyName("subnet")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Subnet { get; set; }

    /// <summary>
    /// Required. ID of the &#39;VpcFlowLogsConfig&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcFlowLogsConfigId is required")]
    [TerraformPropertyName("vpc_flow_logs_config_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VpcFlowLogsConfigId { get; set; }

    /// <summary>
    /// Traffic will be logged from the VPN Tunnel. Format: projects/{project_id}/regions/{region}/vpnTunnels/{name}
    /// </summary>
    [TerraformPropertyName("vpn_tunnel")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VpnTunnel { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleNetworkManagementVpcFlowLogsConfigTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Output only. The time the config was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// Identifier. Unique name of the configuration using the form:     &#39;projects/{project_id}/locations/global/vpcFlowLogsConfigs/{vpc_flow_logs_config_id}&#39;
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// Describes the state of the configured target resource for diagnostic
    /// purposes.
    /// Possible values:
    /// TARGET_RESOURCE_STATE_UNSPECIFIED
    /// TARGET_RESOURCE_EXISTS
    /// TARGET_RESOURCE_DOES_NOT_EXIST
    /// </summary>
    [TerraformPropertyName("target_resource_state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TargetResourceState => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "target_resource_state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

    /// <summary>
    /// Output only. The time the config was updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
