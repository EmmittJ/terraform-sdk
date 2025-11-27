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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The instance_alias attribute.
    /// </summary>
    public TerraformValue<string> InstanceAlias
    {
        get => new TerraformReference<string>(this, "instance_alias");
        set => SetArgument("instance_alias", value);
    }

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    public TerraformValue<string> InstanceId
    {
        get => new TerraformReference<string>(this, "instance_id");
        set => SetArgument("instance_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The auto_resolve_best_voices_enabled attribute.
    /// </summary>
    public TerraformValue<bool> AutoResolveBestVoicesEnabled
    {
        get => new TerraformReference<bool>(this, "auto_resolve_best_voices_enabled");
    }

    /// <summary>
    /// The contact_flow_logs_enabled attribute.
    /// </summary>
    public TerraformValue<bool> ContactFlowLogsEnabled
    {
        get => new TerraformReference<bool>(this, "contact_flow_logs_enabled");
    }

    /// <summary>
    /// The contact_lens_enabled attribute.
    /// </summary>
    public TerraformValue<bool> ContactLensEnabled
    {
        get => new TerraformReference<bool>(this, "contact_lens_enabled");
    }

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    public TerraformValue<string> CreatedTime
    {
        get => new TerraformReference<string>(this, "created_time");
    }

    /// <summary>
    /// The early_media_enabled attribute.
    /// </summary>
    public TerraformValue<bool> EarlyMediaEnabled
    {
        get => new TerraformReference<bool>(this, "early_media_enabled");
    }

    /// <summary>
    /// The identity_management_type attribute.
    /// </summary>
    public TerraformValue<string> IdentityManagementType
    {
        get => new TerraformReference<string>(this, "identity_management_type");
    }

    /// <summary>
    /// The inbound_calls_enabled attribute.
    /// </summary>
    public TerraformValue<bool> InboundCallsEnabled
    {
        get => new TerraformReference<bool>(this, "inbound_calls_enabled");
    }

    /// <summary>
    /// The multi_party_conference_enabled attribute.
    /// </summary>
    public TerraformValue<bool> MultiPartyConferenceEnabled
    {
        get => new TerraformReference<bool>(this, "multi_party_conference_enabled");
    }

    /// <summary>
    /// The outbound_calls_enabled attribute.
    /// </summary>
    public TerraformValue<bool> OutboundCallsEnabled
    {
        get => new TerraformReference<bool>(this, "outbound_calls_enabled");
    }

    /// <summary>
    /// The service_role attribute.
    /// </summary>
    public TerraformValue<string> ServiceRole
    {
        get => new TerraformReference<string>(this, "service_role");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

}
