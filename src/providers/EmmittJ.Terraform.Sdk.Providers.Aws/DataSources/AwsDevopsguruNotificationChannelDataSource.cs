using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filters in AwsDevopsguruNotificationChannelDataSource.
/// Nesting mode: list
/// </summary>
public class AwsDevopsguruNotificationChannelDataSourceFiltersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filters";

    /// <summary>
    /// The message_types attribute.
    /// </summary>
    public TerraformList<string> MessageTypes
        => CreateReference("message_types");

    /// <summary>
    /// The severities attribute.
    /// </summary>
    public TerraformList<string> Severities
        => CreateReference("severities");

}


/// <summary>
/// Block type for sns in AwsDevopsguruNotificationChannelDataSource.
/// Nesting mode: list
/// </summary>
public class AwsDevopsguruNotificationChannelDataSourceSnsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sns";

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    public TerraformValue<string> TopicArn
        => CreateReference("topic_arn");

}


/// <summary>
/// Represents a aws_devopsguru_notification_channel Terraform data source.
/// Retrieves information about a aws_devopsguru_notification_channel.
/// </summary>
public partial class AwsDevopsguruNotificationChannelDataSource(string name) : TerraformDataSource("aws_devopsguru_notification_channel", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetRequiredArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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
    /// Filters block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsDevopsguruNotificationChannelDataSourceFiltersBlock>? Filters
    {
        get => GetArgument<TerraformList<AwsDevopsguruNotificationChannelDataSourceFiltersBlock>>("filters");
        set => SetArgument("filters", value);
    }

    /// <summary>
    /// Sns block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsDevopsguruNotificationChannelDataSourceSnsBlock>? Sns
    {
        get => GetArgument<TerraformList<AwsDevopsguruNotificationChannelDataSourceSnsBlock>>("sns");
        set => SetArgument("sns", value);
    }

}
