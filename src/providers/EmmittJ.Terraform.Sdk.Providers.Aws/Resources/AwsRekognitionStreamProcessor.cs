using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for data_sharing_preference in .
/// Nesting mode: list
/// </summary>
public class AwsRekognitionStreamProcessorDataSharingPreferenceBlock
{
    /// <summary>
    /// Do you want to share data with Rekognition to improve model performance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OptIn is required")]
    [TerraformPropertyName("opt_in")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> OptIn { get; set; }

}

/// <summary>
/// Block type for input in .
/// Nesting mode: list
/// </summary>
public class AwsRekognitionStreamProcessorInputBlock
{
}

/// <summary>
/// Block type for notification_channel in .
/// Nesting mode: list
/// </summary>
public class AwsRekognitionStreamProcessorNotificationChannelBlock
{
    /// <summary>
    /// The Amazon Resource Number (ARN) of the Amazon Amazon Simple Notification Service topic to which Amazon Rekognition posts the completion status.
    /// </summary>
    [TerraformPropertyName("sns_topic_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SnsTopicArn { get; set; }

}

/// <summary>
/// Block type for output in .
/// Nesting mode: list
/// </summary>
public class AwsRekognitionStreamProcessorOutputBlock
{
}

/// <summary>
/// Block type for regions_of_interest in .
/// Nesting mode: list
/// </summary>
public class AwsRekognitionStreamProcessorRegionsOfInterestBlock
{
}

/// <summary>
/// Block type for settings in .
/// Nesting mode: list
/// </summary>
public class AwsRekognitionStreamProcessorSettingsBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRekognitionStreamProcessorTimeoutsBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_rekognition_stream_processor resource.
/// </summary>
public class AwsRekognitionStreamProcessor : TerraformResource
{
    public AwsRekognitionStreamProcessor(string name) : base("aws_rekognition_stream_processor", name)
    {
    }

    /// <summary>
    /// The identifier for your AWS Key Management Service key (AWS KMS key). You can supply the Amazon Resource Name (ARN) of your KMS key, the ID of your KMS key, an alias for your KMS key, or an alias ARN.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KmsKeyId { get; set; }

    /// <summary>
    /// An identifier you assign to the stream processor.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The Amazon Resource Number (ARN) of the IAM role that allows access to the stream processor.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for data_sharing_preference.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("data_sharing_preference")]
    public TerraformList<TerraformBlock<AwsRekognitionStreamProcessorDataSharingPreferenceBlock>>? DataSharingPreference { get; set; }

    /// <summary>
    /// Block for input.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("input")]
    public TerraformList<TerraformBlock<AwsRekognitionStreamProcessorInputBlock>>? Input { get; set; }

    /// <summary>
    /// Block for notification_channel.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("notification_channel")]
    public TerraformList<TerraformBlock<AwsRekognitionStreamProcessorNotificationChannelBlock>>? NotificationChannel { get; set; }

    /// <summary>
    /// Block for output.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("output")]
    public TerraformList<TerraformBlock<AwsRekognitionStreamProcessorOutputBlock>>? Output { get; set; }

    /// <summary>
    /// Block for regions_of_interest.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("regions_of_interest")]
    public TerraformList<TerraformBlock<AwsRekognitionStreamProcessorRegionsOfInterestBlock>>? RegionsOfInterest { get; set; }

    /// <summary>
    /// Block for settings.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("settings")]
    public TerraformList<TerraformBlock<AwsRekognitionStreamProcessorSettingsBlock>>? Settings { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsRekognitionStreamProcessorTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The stream_processor_arn attribute.
    /// </summary>
    [TerraformPropertyName("stream_processor_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StreamProcessorArn => new TerraformReference(this, "stream_processor_arn");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TagsAll => new TerraformReference(this, "tags_all");

}
