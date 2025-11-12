using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleNetworkManagementOrganizationVpcFlowLogsConfigTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_network_management_organization_vpc_flow_logs_config resource.
/// </summary>
public partial class GoogleNetworkManagementOrganizationVpcFlowLogsConfig : TerraformResource
{
    public GoogleNetworkManagementOrganizationVpcFlowLogsConfig(string name) : base("google_network_management_organization_vpc_flow_logs_config", name)
    {
    }

    /// <summary>
    /// Optional. The aggregation interval for the logs. Default value is
    /// INTERVAL_5_SEC.   Possible values: INTERVAL_5_SEC INTERVAL_30_SEC INTERVAL_1_MIN INTERVAL_5_MIN INTERVAL_10_MIN INTERVAL_15_MIN
    /// </summary>
    [TerraformProperty("aggregation_interval")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AggregationInterval { get; set; }

    /// <summary>
    /// Determines whether to include cross project annotations in the logs.
    /// This field is available only for organization configurations. If not
    /// specified in org configs will be set to CROSS_PROJECT_METADATA_ENABLED.
    /// Possible values:
    /// CROSS_PROJECT_METADATA_ENABLED
    /// CROSS_PROJECT_METADATA_DISABLED Possible values: [&amp;quot;CROSS_PROJECT_METADATA_ENABLED&amp;quot;, &amp;quot;CROSS_PROJECT_METADATA_DISABLED&amp;quot;]
    /// </summary>
    [TerraformProperty("cross_project_metadata")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> CrossProjectMetadata { get; set; }

    /// <summary>
    /// Optional. The user-supplied description of the VPC Flow Logs configuration. Maximum
    /// of 512 characters.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Optional. Export filter used to define which VPC Flow Logs should be logged.
    /// </summary>
    [TerraformProperty("filter_expr")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FilterExpr { get; set; }

    /// <summary>
    /// Optional. The value of the field must be in (0, 1]. The sampling rate
    /// of VPC Flow Logs where 1.0 means all collected logs are reported. Setting the
    /// sampling rate to 0.0 is not allowed. If you want to disable VPC Flow Logs, use
    /// the state field instead. Default value is 1.0
    /// </summary>
    [TerraformProperty("flow_sampling")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> FlowSampling { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Optional. Resource labels to represent the user-provided metadata.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource
    /// within its parent collection as described in https://google.aip.dev/122. See documentation
    /// for resource type &#39;networkmanagement.googleapis.com/VpcFlowLogsConfig&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// Optional. Configures whether all, none or a subset of metadata fields
    /// should be added to the reported VPC flow logs. Default value is INCLUDE_ALL_METADATA.
    ///   Possible values:  METADATA_UNSPECIFIED INCLUDE_ALL_METADATA EXCLUDE_ALL_METADATA CUSTOM_METADATA
    /// </summary>
    [TerraformProperty("metadata")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Metadata { get; set; }

    /// <summary>
    /// Optional. Custom metadata fields to include in the reported VPC flow
    /// logs. Can only be specified if \&amp;quot;metadata\&amp;quot; was set to CUSTOM_METADATA.
    /// </summary>
    [TerraformProperty("metadata_fields")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? MetadataFields { get; set; }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Organization is required")]
    [TerraformProperty("organization")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Organization { get; set; }

    /// <summary>
    /// Optional. The state of the VPC Flow Log configuration. Default value
    /// is ENABLED. When creating a new configuration, it must be enabled.
    /// Possible values: ENABLED DISABLED
    /// </summary>
    [TerraformProperty("state")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> State { get; set; }

    /// <summary>
    /// Required. ID of the &#39;VpcFlowLogsConfig&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcFlowLogsConfigId is required")]
    [TerraformProperty("vpc_flow_logs_config_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VpcFlowLogsConfigId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleNetworkManagementOrganizationVpcFlowLogsConfigTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Output only. The time the config was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// Identifier. Unique name of the configuration using the form:     &#39;organizations/{org_id}/locations/global/vpcFlowLogsConfigs/{vpc_flow_logs_config_id}&#39;
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// Output only. The time the config was updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
