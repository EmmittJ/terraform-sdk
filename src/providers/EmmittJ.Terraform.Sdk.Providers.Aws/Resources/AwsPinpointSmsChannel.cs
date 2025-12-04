using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_pinpoint_sms_channel Terraform resource.
/// Manages a aws_pinpoint_sms_channel resource.
/// </summary>
public partial class AwsPinpointSmsChannel(string name) : TerraformResource("aws_pinpoint_sms_channel", name)
{
    /// <summary>
    /// The application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    public required TerraformValue<string> ApplicationId
    {
        get => GetArgument<TerraformValue<string>>("application_id");
        set => SetArgument("application_id", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The sender_id attribute.
    /// </summary>
    public TerraformValue<string>? SenderId
    {
        get => GetArgument<TerraformValue<string>>("sender_id");
        set => SetArgument("sender_id", value);
    }

    /// <summary>
    /// The short_code attribute.
    /// </summary>
    public TerraformValue<string>? ShortCode
    {
        get => GetArgument<TerraformValue<string>>("short_code");
        set => SetArgument("short_code", value);
    }

    /// <summary>
    /// The promotional_messages_per_second attribute.
    /// </summary>
    public TerraformValue<double> PromotionalMessagesPerSecond
        => AsReference("promotional_messages_per_second");

    /// <summary>
    /// The transactional_messages_per_second attribute.
    /// </summary>
    public TerraformValue<double> TransactionalMessagesPerSecond
        => AsReference("transactional_messages_per_second");

}
