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
        set => SetProperty("events", value);
    }

    /// <summary>
    /// The filter_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? FilterPrefix
    {
        set => SetProperty("filter_prefix", value);
    }

    /// <summary>
    /// The filter_suffix attribute.
    /// </summary>
    public TerraformProperty<string>? FilterSuffix
    {
        set => SetProperty("filter_suffix", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The lambda_function_arn attribute.
    /// </summary>
    public TerraformProperty<string>? LambdaFunctionArn
    {
        set => SetProperty("lambda_function_arn", value);
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
        set => SetProperty("events", value);
    }

    /// <summary>
    /// The filter_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? FilterPrefix
    {
        set => SetProperty("filter_prefix", value);
    }

    /// <summary>
    /// The filter_suffix attribute.
    /// </summary>
    public TerraformProperty<string>? FilterSuffix
    {
        set => SetProperty("filter_suffix", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The queue_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueueArn is required")]
    public required TerraformProperty<string> QueueArn
    {
        set => SetProperty("queue_arn", value);
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
        set => SetProperty("events", value);
    }

    /// <summary>
    /// The filter_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? FilterPrefix
    {
        set => SetProperty("filter_prefix", value);
    }

    /// <summary>
    /// The filter_suffix attribute.
    /// </summary>
    public TerraformProperty<string>? FilterSuffix
    {
        set => SetProperty("filter_suffix", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicArn is required")]
    public required TerraformProperty<string> TopicArn
    {
        set => SetProperty("topic_arn", value);
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
        SetOutput("bucket");
        SetOutput("eventbridge");
        SetOutput("id");
        SetOutput("region");
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformProperty<string> Bucket
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bucket");
        set => SetProperty("bucket", value);
    }

    /// <summary>
    /// The eventbridge attribute.
    /// </summary>
    public TerraformProperty<bool> Eventbridge
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("eventbridge");
        set => SetProperty("eventbridge", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Block for lambda_function.
    /// Nesting mode: list
    /// </summary>
    public List<AwsS3BucketNotificationLambdaFunctionBlock>? LambdaFunction
    {
        set => SetProperty("lambda_function", value);
    }

    /// <summary>
    /// Block for queue.
    /// Nesting mode: list
    /// </summary>
    public List<AwsS3BucketNotificationQueueBlock>? Queue
    {
        set => SetProperty("queue", value);
    }

    /// <summary>
    /// Block for topic.
    /// Nesting mode: list
    /// </summary>
    public List<AwsS3BucketNotificationTopicBlock>? Topic
    {
        set => SetProperty("topic", value);
    }

}
