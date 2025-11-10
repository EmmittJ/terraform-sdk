using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for lambda_function in .
/// Nesting mode: list
/// </summary>
public class AwsS3BucketNotificationLambdaFunctionBlock : TerraformBlock
{
    /// <summary>
    /// The events attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Events is required")]
    public HashSet<TerraformProperty<string>>? Events
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("events");
        set => WithProperty("events", value);
    }

    /// <summary>
    /// The filter_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? FilterPrefix
    {
        get => GetProperty<TerraformProperty<string>>("filter_prefix");
        set => WithProperty("filter_prefix", value);
    }

    /// <summary>
    /// The filter_suffix attribute.
    /// </summary>
    public TerraformProperty<string>? FilterSuffix
    {
        get => GetProperty<TerraformProperty<string>>("filter_suffix");
        set => WithProperty("filter_suffix", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The lambda_function_arn attribute.
    /// </summary>
    public TerraformProperty<string>? LambdaFunctionArn
    {
        get => GetProperty<TerraformProperty<string>>("lambda_function_arn");
        set => WithProperty("lambda_function_arn", value);
    }

}

/// <summary>
/// Block type for queue in .
/// Nesting mode: list
/// </summary>
public class AwsS3BucketNotificationQueueBlock : TerraformBlock
{
    /// <summary>
    /// The events attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Events is required")]
    public HashSet<TerraformProperty<string>>? Events
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("events");
        set => WithProperty("events", value);
    }

    /// <summary>
    /// The filter_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? FilterPrefix
    {
        get => GetProperty<TerraformProperty<string>>("filter_prefix");
        set => WithProperty("filter_prefix", value);
    }

    /// <summary>
    /// The filter_suffix attribute.
    /// </summary>
    public TerraformProperty<string>? FilterSuffix
    {
        get => GetProperty<TerraformProperty<string>>("filter_suffix");
        set => WithProperty("filter_suffix", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The queue_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueueArn is required")]
    public required TerraformProperty<string> QueueArn
    {
        get => GetProperty<TerraformProperty<string>>("queue_arn");
        set => WithProperty("queue_arn", value);
    }

}

/// <summary>
/// Block type for topic in .
/// Nesting mode: list
/// </summary>
public class AwsS3BucketNotificationTopicBlock : TerraformBlock
{
    /// <summary>
    /// The events attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Events is required")]
    public HashSet<TerraformProperty<string>>? Events
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("events");
        set => WithProperty("events", value);
    }

    /// <summary>
    /// The filter_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? FilterPrefix
    {
        get => GetProperty<TerraformProperty<string>>("filter_prefix");
        set => WithProperty("filter_prefix", value);
    }

    /// <summary>
    /// The filter_suffix attribute.
    /// </summary>
    public TerraformProperty<string>? FilterSuffix
    {
        get => GetProperty<TerraformProperty<string>>("filter_suffix");
        set => WithProperty("filter_suffix", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicArn is required")]
    public required TerraformProperty<string> TopicArn
    {
        get => GetProperty<TerraformProperty<string>>("topic_arn");
        set => WithProperty("topic_arn", value);
    }

}

/// <summary>
/// Manages a aws_s3_bucket_notification resource.
/// </summary>
public class AwsS3BucketNotification : TerraformResource
{
    public AwsS3BucketNotification(string name) : base("aws_s3_bucket_notification", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformProperty<string> Bucket
    {
        get => GetProperty<TerraformProperty<string>>("bucket");
        set => this.WithProperty("bucket", value);
    }

    /// <summary>
    /// The eventbridge attribute.
    /// </summary>
    public TerraformProperty<bool>? Eventbridge
    {
        get => GetProperty<TerraformProperty<bool>>("eventbridge");
        set => this.WithProperty("eventbridge", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for lambda_function.
    /// Nesting mode: list
    /// </summary>
    public List<AwsS3BucketNotificationLambdaFunctionBlock>? LambdaFunction
    {
        get => GetProperty<List<AwsS3BucketNotificationLambdaFunctionBlock>>("lambda_function");
        set => this.WithProperty("lambda_function", value);
    }

    /// <summary>
    /// Block for queue.
    /// Nesting mode: list
    /// </summary>
    public List<AwsS3BucketNotificationQueueBlock>? Queue
    {
        get => GetProperty<List<AwsS3BucketNotificationQueueBlock>>("queue");
        set => this.WithProperty("queue", value);
    }

    /// <summary>
    /// Block for topic.
    /// Nesting mode: list
    /// </summary>
    public List<AwsS3BucketNotificationTopicBlock>? Topic
    {
        get => GetProperty<List<AwsS3BucketNotificationTopicBlock>>("topic");
        set => this.WithProperty("topic", value);
    }

}
