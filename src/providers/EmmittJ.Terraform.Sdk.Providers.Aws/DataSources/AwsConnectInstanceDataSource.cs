using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_connect_instance Terraform data source.
/// Retrieves information about a aws_connect_instance.
/// </summary>
public partial class AwsConnectInstanceDataSource(string name) : TerraformDataSource("aws_connect_instance", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The instance_alias attribute.
    /// </summary>
    public TerraformValue<string> InstanceAlias
    {
        get => GetArgument<TerraformValue<string>>("instance_alias") ?? AsReference("instance_alias");
        set => SetArgument("instance_alias", value);
    }

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    public TerraformValue<string> InstanceId
    {
        get => GetArgument<TerraformValue<string>>("instance_id") ?? AsReference("instance_id");
        set => SetArgument("instance_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? AsReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The auto_resolve_best_voices_enabled attribute.
    /// </summary>
    public TerraformValue<bool> AutoResolveBestVoicesEnabled
        => AsReference("auto_resolve_best_voices_enabled");

    /// <summary>
    /// The contact_flow_logs_enabled attribute.
    /// </summary>
    public TerraformValue<bool> ContactFlowLogsEnabled
        => AsReference("contact_flow_logs_enabled");

    /// <summary>
    /// The contact_lens_enabled attribute.
    /// </summary>
    public TerraformValue<bool> ContactLensEnabled
        => AsReference("contact_lens_enabled");

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    public TerraformValue<string> CreatedTime
        => AsReference("created_time");

    /// <summary>
    /// The early_media_enabled attribute.
    /// </summary>
    public TerraformValue<bool> EarlyMediaEnabled
        => AsReference("early_media_enabled");

    /// <summary>
    /// The identity_management_type attribute.
    /// </summary>
    public TerraformValue<string> IdentityManagementType
        => AsReference("identity_management_type");

    /// <summary>
    /// The inbound_calls_enabled attribute.
    /// </summary>
    public TerraformValue<bool> InboundCallsEnabled
        => AsReference("inbound_calls_enabled");

    /// <summary>
    /// The multi_party_conference_enabled attribute.
    /// </summary>
    public TerraformValue<bool> MultiPartyConferenceEnabled
        => AsReference("multi_party_conference_enabled");

    /// <summary>
    /// The outbound_calls_enabled attribute.
    /// </summary>
    public TerraformValue<bool> OutboundCallsEnabled
        => AsReference("outbound_calls_enabled");

    /// <summary>
    /// The service_role attribute.
    /// </summary>
    public TerraformValue<string> ServiceRole
        => AsReference("service_role");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

}
