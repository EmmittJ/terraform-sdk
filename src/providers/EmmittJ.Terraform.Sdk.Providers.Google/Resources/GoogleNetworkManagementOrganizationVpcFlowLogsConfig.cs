using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleNetworkManagementOrganizationVpcFlowLogsConfig.
/// Nesting mode: single
/// </summary>
public class GoogleNetworkManagementOrganizationVpcFlowLogsConfigTimeoutsBlock : TerraformBlock
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
/// Represents a google_network_management_organization_vpc_flow_logs_config Terraform resource.
/// Manages a google_network_management_organization_vpc_flow_logs_config resource.
/// </summary>
public partial class GoogleNetworkManagementOrganizationVpcFlowLogsConfig(string name) : TerraformResource("google_network_management_organization_vpc_flow_logs_config", name)
{
    /// <summary>
    /// Optional. The aggregation interval for the logs. Default value is
    /// INTERVAL_5_SEC.   Possible values: INTERVAL_5_SEC INTERVAL_30_SEC INTERVAL_1_MIN INTERVAL_5_MIN INTERVAL_10_MIN INTERVAL_15_MIN
    /// </summary>
    public TerraformValue<string>? AggregationInterval
    {
        get => GetArgument<TerraformValue<string>>("aggregation_interval");
        set => SetArgument("aggregation_interval", value);
    }

    /// <summary>
    /// Determines whether to include cross project annotations in the logs.
    /// This field is available only for organization configurations. If not
    /// specified in org configs will be set to CROSS_PROJECT_METADATA_ENABLED.
    /// Possible values:
    /// CROSS_PROJECT_METADATA_ENABLED
    /// CROSS_PROJECT_METADATA_DISABLED Possible values: [&amp;quot;CROSS_PROJECT_METADATA_ENABLED&amp;quot;, &amp;quot;CROSS_PROJECT_METADATA_DISABLED&amp;quot;]
    /// </summary>
    public TerraformValue<string>? CrossProjectMetadata
    {
        get => GetArgument<TerraformValue<string>>("cross_project_metadata");
        set => SetArgument("cross_project_metadata", value);
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
    /// the state field instead. Default value is 1.0
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
    /// Optional. Resource labels to represent the user-provided metadata.
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
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Organization is required")]
    public required TerraformValue<string> Organization
    {
        get => GetArgument<TerraformValue<string>>("organization");
        set => SetArgument("organization", value);
    }

    /// <summary>
    /// Optional. The state of the VPC Flow Log configuration. Default value
    /// is ENABLED. When creating a new configuration, it must be enabled.
    /// Possible values: ENABLED DISABLED
    /// </summary>
    public TerraformValue<string>? State
    {
        get => GetArgument<TerraformValue<string>>("state");
        set => SetArgument("state", value);
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
    /// Identifier. Unique name of the configuration using the form:     &#39;organizations/{org_id}/locations/global/vpcFlowLogsConfigs/{vpc_flow_logs_config_id}&#39;
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

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
    public GoogleNetworkManagementOrganizationVpcFlowLogsConfigTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleNetworkManagementOrganizationVpcFlowLogsConfigTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
