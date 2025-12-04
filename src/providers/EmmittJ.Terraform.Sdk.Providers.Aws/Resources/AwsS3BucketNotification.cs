using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for lambda_function in AwsS3BucketNotification.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketNotificationLambdaFunctionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lambda_function";

    /// <summary>
    /// The events attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Events is required")]
    public required TerraformSet<string> Events
    {
        get => GetRequiredArgument<TerraformSet<string>>("events");
        set => SetArgument("events", value);
    }

    /// <summary>
    /// The filter_prefix attribute.
    /// </summary>
    public TerraformValue<string>? FilterPrefix
    {
        get => GetArgument<TerraformValue<string>>("filter_prefix");
        set => SetArgument("filter_prefix", value);
    }

    /// <summary>
    /// The filter_suffix attribute.
    /// </summary>
    public TerraformValue<string>? FilterSuffix
    {
        get => GetArgument<TerraformValue<string>>("filter_suffix");
        set => SetArgument("filter_suffix", value);
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
    /// The lambda_function_arn attribute.
    /// </summary>
    public TerraformValue<string>? LambdaFunctionArn
    {
        get => GetArgument<TerraformValue<string>>("lambda_function_arn");
        set => SetArgument("lambda_function_arn", value);
    }

}


/// <summary>
/// Block type for queue in AwsS3BucketNotification.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketNotificationQueueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "queue";

    /// <summary>
    /// The events attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Events is required")]
    public required TerraformSet<string> Events
    {
        get => GetRequiredArgument<TerraformSet<string>>("events");
        set => SetArgument("events", value);
    }

    /// <summary>
    /// The filter_prefix attribute.
    /// </summary>
    public TerraformValue<string>? FilterPrefix
    {
        get => GetArgument<TerraformValue<string>>("filter_prefix");
        set => SetArgument("filter_prefix", value);
    }

    /// <summary>
    /// The filter_suffix attribute.
    /// </summary>
    public TerraformValue<string>? FilterSuffix
    {
        get => GetArgument<TerraformValue<string>>("filter_suffix");
        set => SetArgument("filter_suffix", value);
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
    /// The queue_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueueArn is required")]
    public required TerraformValue<string> QueueArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("queue_arn");
        set => SetArgument("queue_arn", value);
    }

}


/// <summary>
/// Block type for topic in AwsS3BucketNotification.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketNotificationTopicBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "topic";

    /// <summary>
    /// The events attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Events is required")]
    public required TerraformSet<string> Events
    {
        get => GetRequiredArgument<TerraformSet<string>>("events");
        set => SetArgument("events", value);
    }

    /// <summary>
    /// The filter_prefix attribute.
    /// </summary>
    public TerraformValue<string>? FilterPrefix
    {
        get => GetArgument<TerraformValue<string>>("filter_prefix");
        set => SetArgument("filter_prefix", value);
    }

    /// <summary>
    /// The filter_suffix attribute.
    /// </summary>
    public TerraformValue<string>? FilterSuffix
    {
        get => GetArgument<TerraformValue<string>>("filter_suffix");
        set => SetArgument("filter_suffix", value);
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
/// Represents a aws_s3_bucket_notification Terraform resource.
/// Manages a aws_s3_bucket_notification resource.
/// </summary>
public partial class AwsS3BucketNotification(string name) : TerraformResource("aws_s3_bucket_notification", name)
{
    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The eventbridge attribute.
    /// </summary>
    public TerraformValue<bool>? Eventbridge
    {
        get => GetArgument<TerraformValue<bool>>("eventbridge");
        set => SetArgument("eventbridge", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// LambdaFunction block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsS3BucketNotificationLambdaFunctionBlock>? LambdaFunction
    {
        get => GetArgument<TerraformList<AwsS3BucketNotificationLambdaFunctionBlock>>("lambda_function");
        set => SetArgument("lambda_function", value);
    }

    /// <summary>
    /// Queue block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsS3BucketNotificationQueueBlock>? Queue
    {
        get => GetArgument<TerraformList<AwsS3BucketNotificationQueueBlock>>("queue");
        set => SetArgument("queue", value);
    }

    /// <summary>
    /// Topic block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsS3BucketNotificationTopicBlock>? Topic
    {
        get => GetArgument<TerraformList<AwsS3BucketNotificationTopicBlock>>("topic");
        set => SetArgument("topic", value);
    }

}
