using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filters in AwsDevopsguruNotificationChannel.
/// Nesting mode: list
/// </summary>
public class AwsDevopsguruNotificationChannelFiltersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filters";

    /// <summary>
    /// The message_types attribute.
    /// </summary>
    public TerraformSet<string>? MessageTypes
    {
        get => GetArgument<TerraformSet<string>>("message_types");
        set => SetArgument("message_types", value);
    }

    /// <summary>
    /// The severities attribute.
    /// </summary>
    public TerraformSet<string>? Severities
    {
        get => GetArgument<TerraformSet<string>>("severities");
        set => SetArgument("severities", value);
    }

}


/// <summary>
/// Block type for sns in AwsDevopsguruNotificationChannel.
/// Nesting mode: list
/// </summary>
public class AwsDevopsguruNotificationChannelSnsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sns";

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicArn is required")]
    public required TerraformValue<string> TopicArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("topic_arn");
        set => SetArgument("topic_arn", value);
    }

}


/// <summary>
/// Represents a aws_devopsguru_notification_channel Terraform resource.
/// Manages a aws_devopsguru_notification_channel resource.
/// </summary>
public partial class AwsDevopsguruNotificationChannel(string name) : TerraformResource("aws_devopsguru_notification_channel", name)
{
    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// Filters block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsDevopsguruNotificationChannelFiltersBlock>? Filters
    {
        get => GetArgument<TerraformList<AwsDevopsguruNotificationChannelFiltersBlock>>("filters");
        set => SetArgument("filters", value);
    }

    /// <summary>
    /// Sns block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsDevopsguruNotificationChannelSnsBlock>? Sns
    {
        get => GetArgument<TerraformList<AwsDevopsguruNotificationChannelSnsBlock>>("sns");
        set => SetArgument("sns", value);
    }

}
