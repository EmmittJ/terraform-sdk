using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for lambda_function in .
/// Nesting mode: list
/// </summary>
public class AwsS3BucketNotificationLambdaFunctionBlock : ITerraformBlock
{
    /// <summary>
    /// The events attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Events is required")]
    [TerraformPropertyName("events")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Events { get; set; }

    /// <summary>
    /// The filter_prefix attribute.
    /// </summary>
    [TerraformPropertyName("filter_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FilterPrefix { get; set; }

    /// <summary>
    /// The filter_suffix attribute.
    /// </summary>
    [TerraformPropertyName("filter_suffix")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FilterSuffix { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "id");

    /// <summary>
    /// The lambda_function_arn attribute.
    /// </summary>
    [TerraformPropertyName("lambda_function_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LambdaFunctionArn { get; set; }

}

/// <summary>
/// Block type for queue in .
/// Nesting mode: list
/// </summary>
public class AwsS3BucketNotificationQueueBlock : ITerraformBlock
{
    /// <summary>
    /// The events attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Events is required")]
    [TerraformPropertyName("events")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Events { get; set; }

    /// <summary>
    /// The filter_prefix attribute.
    /// </summary>
    [TerraformPropertyName("filter_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FilterPrefix { get; set; }

    /// <summary>
    /// The filter_suffix attribute.
    /// </summary>
    [TerraformPropertyName("filter_suffix")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FilterSuffix { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "id");

    /// <summary>
    /// The queue_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueueArn is required")]
    [TerraformPropertyName("queue_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> QueueArn { get; set; }

}

/// <summary>
/// Block type for topic in .
/// Nesting mode: list
/// </summary>
public class AwsS3BucketNotificationTopicBlock : ITerraformBlock
{
    /// <summary>
    /// The events attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Events is required")]
    [TerraformPropertyName("events")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Events { get; set; }

    /// <summary>
    /// The filter_prefix attribute.
    /// </summary>
    [TerraformPropertyName("filter_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FilterPrefix { get; set; }

    /// <summary>
    /// The filter_suffix attribute.
    /// </summary>
    [TerraformPropertyName("filter_suffix")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FilterSuffix { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "id");

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicArn is required")]
    [TerraformPropertyName("topic_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TopicArn { get; set; }

}

/// <summary>
/// Manages a aws_s3_bucket_notification resource.
/// </summary>
public class AwsS3BucketNotification : TerraformResource
{
    public AwsS3BucketNotification(string name) : base("aws_s3_bucket_notification", name)
    {
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformPropertyName("bucket")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Bucket { get; set; }

    /// <summary>
    /// The eventbridge attribute.
    /// </summary>
    [TerraformPropertyName("eventbridge")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Eventbridge { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for lambda_function.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("lambda_function")]
    public TerraformList<TerraformBlock<AwsS3BucketNotificationLambdaFunctionBlock>>? LambdaFunction { get; set; } = new();

    /// <summary>
    /// Block for queue.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("queue")]
    public TerraformList<TerraformBlock<AwsS3BucketNotificationQueueBlock>>? Queue { get; set; } = new();

    /// <summary>
    /// Block for topic.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("topic")]
    public TerraformList<TerraformBlock<AwsS3BucketNotificationTopicBlock>>? Topic { get; set; } = new();

}
