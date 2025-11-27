using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cloudwatch_destination in AwsSesEventDestination.
/// Nesting mode: set
/// </summary>
public class AwsSesEventDestinationCloudwatchDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudwatch_destination";

    /// <summary>
    /// The default_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultValue is required")]
    public required TerraformValue<string> DefaultValue
    {
        get => new TerraformReference<string>(this, "default_value");
        set => SetArgument("default_value", value);
    }

    /// <summary>
    /// The dimension_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DimensionName is required")]
    public required TerraformValue<string> DimensionName
    {
        get => new TerraformReference<string>(this, "dimension_name");
        set => SetArgument("dimension_name", value);
    }

    /// <summary>
    /// The value_source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValueSource is required")]
    public required TerraformValue<string> ValueSource
    {
        get => new TerraformReference<string>(this, "value_source");
        set => SetArgument("value_source", value);
    }

}


/// <summary>
/// Block type for kinesis_destination in AwsSesEventDestination.
/// Nesting mode: list
/// </summary>
public class AwsSesEventDestinationKinesisDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kinesis_destination";

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The stream_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamArn is required")]
    public required TerraformValue<string> StreamArn
    {
        get => new TerraformReference<string>(this, "stream_arn");
        set => SetArgument("stream_arn", value);
    }

}


/// <summary>
/// Block type for sns_destination in AwsSesEventDestination.
/// Nesting mode: list
/// </summary>
public class AwsSesEventDestinationSnsDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sns_destination";

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicArn is required")]
    public required TerraformValue<string> TopicArn
    {
        get => new TerraformReference<string>(this, "topic_arn");
        set => SetArgument("topic_arn", value);
    }

}


/// <summary>
/// Represents a aws_ses_event_destination Terraform resource.
/// Manages a aws_ses_event_destination resource.
/// </summary>
public partial class AwsSesEventDestination(string name) : TerraformResource("aws_ses_event_destination", name)
{
    /// <summary>
    /// The configuration_set_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationSetName is required")]
    public required TerraformValue<string> ConfigurationSetName
    {
        get => new TerraformReference<string>(this, "configuration_set_name");
        set => SetArgument("configuration_set_name", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The matching_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MatchingTypes is required")]
    public required TerraformSet<string> MatchingTypes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "matching_types").ResolveNodes(ctx));
        set => SetArgument("matching_types", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// CloudwatchDestination block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSesEventDestinationCloudwatchDestinationBlock>? CloudwatchDestination
    {
        get => GetArgument<TerraformSet<AwsSesEventDestinationCloudwatchDestinationBlock>>("cloudwatch_destination");
        set => SetArgument("cloudwatch_destination", value);
    }

    /// <summary>
    /// KinesisDestination block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KinesisDestination block(s) allowed")]
    public TerraformList<AwsSesEventDestinationKinesisDestinationBlock>? KinesisDestination
    {
        get => GetArgument<TerraformList<AwsSesEventDestinationKinesisDestinationBlock>>("kinesis_destination");
        set => SetArgument("kinesis_destination", value);
    }

    /// <summary>
    /// SnsDestination block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SnsDestination block(s) allowed")]
    public TerraformList<AwsSesEventDestinationSnsDestinationBlock>? SnsDestination
    {
        get => GetArgument<TerraformList<AwsSesEventDestinationSnsDestinationBlock>>("sns_destination");
        set => SetArgument("sns_destination", value);
    }

}
