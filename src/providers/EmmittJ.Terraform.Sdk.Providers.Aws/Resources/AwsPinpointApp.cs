using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for campaign_hook in AwsPinpointApp.
/// Nesting mode: list
/// </summary>
public class AwsPinpointAppCampaignHookBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "campaign_hook";

    /// <summary>
    /// The lambda_function_name attribute.
    /// </summary>
    public TerraformValue<string>? LambdaFunctionName
    {
        get => GetArgument<TerraformValue<string>>("lambda_function_name");
        set => SetArgument("lambda_function_name", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformValue<string>? Mode
    {
        get => GetArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The web_url attribute.
    /// </summary>
    public TerraformValue<string>? WebUrl
    {
        get => GetArgument<TerraformValue<string>>("web_url");
        set => SetArgument("web_url", value);
    }

}


/// <summary>
/// Block type for limits in AwsPinpointApp.
/// Nesting mode: list
/// </summary>
public class AwsPinpointAppLimitsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "limits";

    /// <summary>
    /// The daily attribute.
    /// </summary>
    public TerraformValue<double>? Daily
    {
        get => GetArgument<TerraformValue<double>>("daily");
        set => SetArgument("daily", value);
    }

    /// <summary>
    /// The maximum_duration attribute.
    /// </summary>
    public TerraformValue<double>? MaximumDuration
    {
        get => GetArgument<TerraformValue<double>>("maximum_duration");
        set => SetArgument("maximum_duration", value);
    }

    /// <summary>
    /// The messages_per_second attribute.
    /// </summary>
    public TerraformValue<double>? MessagesPerSecond
    {
        get => GetArgument<TerraformValue<double>>("messages_per_second");
        set => SetArgument("messages_per_second", value);
    }

    /// <summary>
    /// The total attribute.
    /// </summary>
    public TerraformValue<double>? Total
    {
        get => GetArgument<TerraformValue<double>>("total");
        set => SetArgument("total", value);
    }

}


/// <summary>
/// Block type for quiet_time in AwsPinpointApp.
/// Nesting mode: list
/// </summary>
public class AwsPinpointAppQuietTimeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "quiet_time";

    /// <summary>
    /// The end attribute.
    /// </summary>
    public TerraformValue<string>? End
    {
        get => GetArgument<TerraformValue<string>>("end");
        set => SetArgument("end", value);
    }

    /// <summary>
    /// The start attribute.
    /// </summary>
    public TerraformValue<string>? Start
    {
        get => GetArgument<TerraformValue<string>>("start");
        set => SetArgument("start", value);
    }

}


/// <summary>
/// Represents a aws_pinpoint_app Terraform resource.
/// Manages a aws_pinpoint_app resource.
/// </summary>
public partial class AwsPinpointApp(string name) : TerraformResource("aws_pinpoint_app", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name") ?? CreateReference("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformValue<string> NamePrefix
    {
        get => GetArgument<TerraformValue<string>>("name_prefix") ?? CreateReference("name_prefix");
        set => SetArgument("name_prefix", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
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
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The application_id attribute.
    /// </summary>
    public TerraformValue<string> ApplicationId
        => CreateReference("application_id");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// CampaignHook block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CampaignHook block(s) allowed")]
    public TerraformList<AwsPinpointAppCampaignHookBlock>? CampaignHook
    {
        get => GetArgument<TerraformList<AwsPinpointAppCampaignHookBlock>>("campaign_hook");
        set => SetArgument("campaign_hook", value);
    }

    /// <summary>
    /// Limits block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Limits block(s) allowed")]
    public TerraformList<AwsPinpointAppLimitsBlock>? Limits
    {
        get => GetArgument<TerraformList<AwsPinpointAppLimitsBlock>>("limits");
        set => SetArgument("limits", value);
    }

    /// <summary>
    /// QuietTime block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QuietTime block(s) allowed")]
    public TerraformList<AwsPinpointAppQuietTimeBlock>? QuietTime
    {
        get => GetArgument<TerraformList<AwsPinpointAppQuietTimeBlock>>("quiet_time");
        set => SetArgument("quiet_time", value);
    }

}
