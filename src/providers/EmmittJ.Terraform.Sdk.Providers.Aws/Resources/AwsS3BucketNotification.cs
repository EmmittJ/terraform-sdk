using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for lambda_function in .
/// Nesting mode: list
/// </summary>
public partial class AwsS3BucketNotificationLambdaFunctionBlock() : TerraformBlock("lambda_function")
{
    /// <summary>
    /// The events attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Events is required")]
    [TerraformProperty("events")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Events { get; set; }

    /// <summary>
    /// The filter_prefix attribute.
    /// </summary>
    [TerraformProperty("filter_prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FilterPrefix { get; set; }

    /// <summary>
    /// The filter_suffix attribute.
    /// </summary>
    [TerraformProperty("filter_suffix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FilterSuffix { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The lambda_function_arn attribute.
    /// </summary>
    [TerraformProperty("lambda_function_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LambdaFunctionArn { get; set; }

}

/// <summary>
/// Block type for queue in .
/// Nesting mode: list
/// </summary>
public partial class AwsS3BucketNotificationQueueBlock() : TerraformBlock("queue")
{
    /// <summary>
    /// The events attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Events is required")]
    [TerraformProperty("events")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Events { get; set; }

    /// <summary>
    /// The filter_prefix attribute.
    /// </summary>
    [TerraformProperty("filter_prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FilterPrefix { get; set; }

    /// <summary>
    /// The filter_suffix attribute.
    /// </summary>
    [TerraformProperty("filter_suffix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FilterSuffix { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The queue_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueueArn is required")]
    [TerraformProperty("queue_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> QueueArn { get; set; }

}

/// <summary>
/// Block type for topic in .
/// Nesting mode: list
/// </summary>
public partial class AwsS3BucketNotificationTopicBlock() : TerraformBlock("topic")
{
    /// <summary>
    /// The events attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Events is required")]
    [TerraformProperty("events")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Events { get; set; }

    /// <summary>
    /// The filter_prefix attribute.
    /// </summary>
    [TerraformProperty("filter_prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FilterPrefix { get; set; }

    /// <summary>
    /// The filter_suffix attribute.
    /// </summary>
    [TerraformProperty("filter_suffix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FilterSuffix { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicArn is required")]
    [TerraformProperty("topic_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TopicArn { get; set; }

}

/// <summary>
/// Manages a aws_s3_bucket_notification resource.
/// </summary>
public partial class AwsS3BucketNotification : TerraformResource
{
    public AwsS3BucketNotification(string name) : base("aws_s3_bucket_notification", name)
    {
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformProperty("bucket")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Bucket { get; set; }

    /// <summary>
    /// The eventbridge attribute.
    /// </summary>
    [TerraformProperty("eventbridge")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Eventbridge { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for lambda_function.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("lambda_function")]
    public TerraformList<AwsS3BucketNotificationLambdaFunctionBlock> LambdaFunction { get; set; } = new();

    /// <summary>
    /// Block for queue.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("queue")]
    public TerraformList<AwsS3BucketNotificationQueueBlock> Queue { get; set; } = new();

    /// <summary>
    /// Block for topic.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("topic")]
    public TerraformList<AwsS3BucketNotificationTopicBlock> Topic { get; set; } = new();

}
