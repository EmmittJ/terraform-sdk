using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsConnectInstance.
/// Nesting mode: single
/// </summary>
public class AwsConnectInstanceTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a aws_connect_instance Terraform resource.
/// Manages a aws_connect_instance resource.
/// </summary>
public partial class AwsConnectInstance(string name) : TerraformResource("aws_connect_instance", name)
{
    /// <summary>
    /// The auto_resolve_best_voices_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AutoResolveBestVoicesEnabled
    {
        get => GetArgument<TerraformValue<bool>>("auto_resolve_best_voices_enabled");
        set => SetArgument("auto_resolve_best_voices_enabled", value);
    }

    /// <summary>
    /// The contact_flow_logs_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ContactFlowLogsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("contact_flow_logs_enabled");
        set => SetArgument("contact_flow_logs_enabled", value);
    }

    /// <summary>
    /// The contact_lens_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ContactLensEnabled
    {
        get => GetArgument<TerraformValue<bool>>("contact_lens_enabled");
        set => SetArgument("contact_lens_enabled", value);
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    public TerraformValue<string>? DirectoryId
    {
        get => GetArgument<TerraformValue<string>>("directory_id");
        set => SetArgument("directory_id", value);
    }

    /// <summary>
    /// The early_media_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? EarlyMediaEnabled
    {
        get => GetArgument<TerraformValue<bool>>("early_media_enabled");
        set => SetArgument("early_media_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The identity_management_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityManagementType is required")]
    public required TerraformValue<string> IdentityManagementType
    {
        get => GetRequiredArgument<TerraformValue<string>>("identity_management_type");
        set => SetArgument("identity_management_type", value);
    }

    /// <summary>
    /// The inbound_calls_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InboundCallsEnabled is required")]
    public required TerraformValue<bool> InboundCallsEnabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("inbound_calls_enabled");
        set => SetArgument("inbound_calls_enabled", value);
    }

    /// <summary>
    /// The instance_alias attribute.
    /// </summary>
    public TerraformValue<string>? InstanceAlias
    {
        get => GetArgument<TerraformValue<string>>("instance_alias");
        set => SetArgument("instance_alias", value);
    }

    /// <summary>
    /// The multi_party_conference_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? MultiPartyConferenceEnabled
    {
        get => GetArgument<TerraformValue<bool>>("multi_party_conference_enabled");
        set => SetArgument("multi_party_conference_enabled", value);
    }

    /// <summary>
    /// The outbound_calls_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OutboundCallsEnabled is required")]
    public required TerraformValue<bool> OutboundCallsEnabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("outbound_calls_enabled");
        set => SetArgument("outbound_calls_enabled", value);
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
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    public TerraformValue<string> CreatedTime
        => AsReference("created_time");

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

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsConnectInstanceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsConnectInstanceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
