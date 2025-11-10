using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for data_sharing_preference in .
/// Nesting mode: list
/// </summary>
public class AwsRekognitionStreamProcessorDataSharingPreferenceBlock : ITerraformBlock
{
    /// <summary>
    /// Do you want to share data with Rekognition to improve model performance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OptIn is required")]
    [TerraformPropertyName("opt_in")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> OptIn { get; set; }

}

/// <summary>
/// Block type for input in .
/// Nesting mode: list
/// </summary>
public class AwsRekognitionStreamProcessorInputBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for notification_channel in .
/// Nesting mode: list
/// </summary>
public class AwsRekognitionStreamProcessorNotificationChannelBlock : ITerraformBlock
{
    /// <summary>
    /// The Amazon Resource Number (ARN) of the Amazon Amazon Simple Notification Service topic to which Amazon Rekognition posts the completion status.
    /// </summary>
    [TerraformPropertyName("sns_topic_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SnsTopicArn { get; set; }

}

/// <summary>
/// Block type for output in .
/// Nesting mode: list
/// </summary>
public class AwsRekognitionStreamProcessorOutputBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for regions_of_interest in .
/// Nesting mode: list
/// </summary>
public class AwsRekognitionStreamProcessorRegionsOfInterestBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for settings in .
/// Nesting mode: list
/// </summary>
public class AwsRekognitionStreamProcessorSettingsBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRekognitionStreamProcessorTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    public TerraformProperty<TerraformProperty<string>>? KmsKeyId { get; set; }

    /// <summary>
    /// An identifier you assign to the stream processor.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The Amazon Resource Number (ARN) of the IAM role that allows access to the stream processor.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleArn { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for data_sharing_preference.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("data_sharing_preference")]
    public TerraformList<TerraformBlock<AwsRekognitionStreamProcessorDataSharingPreferenceBlock>>? DataSharingPreference { get; set; } = new();

    /// <summary>
    /// Block for input.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("input")]
    public TerraformList<TerraformBlock<AwsRekognitionStreamProcessorInputBlock>>? Input { get; set; } = new();

    /// <summary>
    /// Block for notification_channel.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("notification_channel")]
    public TerraformList<TerraformBlock<AwsRekognitionStreamProcessorNotificationChannelBlock>>? NotificationChannel { get; set; } = new();

    /// <summary>
    /// Block for output.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("output")]
    public TerraformList<TerraformBlock<AwsRekognitionStreamProcessorOutputBlock>>? Output { get; set; } = new();

    /// <summary>
    /// Block for regions_of_interest.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("regions_of_interest")]
    public TerraformList<TerraformBlock<AwsRekognitionStreamProcessorRegionsOfInterestBlock>>? RegionsOfInterest { get; set; } = new();

    /// <summary>
    /// Block for settings.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("settings")]
    public TerraformList<TerraformBlock<AwsRekognitionStreamProcessorSettingsBlock>>? Settings { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsRekognitionStreamProcessorTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The stream_processor_arn attribute.
    /// </summary>
    [TerraformPropertyName("stream_processor_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StreamProcessorArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "stream_processor_arn");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

}
