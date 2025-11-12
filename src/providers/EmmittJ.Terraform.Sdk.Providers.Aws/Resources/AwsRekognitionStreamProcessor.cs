using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for data_sharing_preference in .
/// Nesting mode: list
/// </summary>
public partial class AwsRekognitionStreamProcessorDataSharingPreferenceBlock() : TerraformBlock("data_sharing_preference")
{
    /// <summary>
    /// Do you want to share data with Rekognition to improve model performance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OptIn is required")]
    [TerraformProperty("opt_in")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> OptIn { get; set; }

}

/// <summary>
/// Block type for input in .
/// Nesting mode: list
/// </summary>
public partial class AwsRekognitionStreamProcessorInputBlock() : TerraformBlock("input")
{
}

/// <summary>
/// Block type for notification_channel in .
/// Nesting mode: list
/// </summary>
public partial class AwsRekognitionStreamProcessorNotificationChannelBlock() : TerraformBlock("notification_channel")
{
    /// <summary>
    /// The Amazon Resource Number (ARN) of the Amazon Amazon Simple Notification Service topic to which Amazon Rekognition posts the completion status.
    /// </summary>
    [TerraformProperty("sns_topic_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SnsTopicArn { get; set; }

}

/// <summary>
/// Block type for output in .
/// Nesting mode: list
/// </summary>
public partial class AwsRekognitionStreamProcessorOutputBlock() : TerraformBlock("output")
{
}

/// <summary>
/// Block type for regions_of_interest in .
/// Nesting mode: list
/// </summary>
public partial class AwsRekognitionStreamProcessorRegionsOfInterestBlock() : TerraformBlock("regions_of_interest")
{
}

/// <summary>
/// Block type for settings in .
/// Nesting mode: list
/// </summary>
public partial class AwsRekognitionStreamProcessorSettingsBlock() : TerraformBlock("settings")
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsRekognitionStreamProcessorTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_rekognition_stream_processor resource.
/// </summary>
public partial class AwsRekognitionStreamProcessor : TerraformResource
{
    public AwsRekognitionStreamProcessor(string name) : base("aws_rekognition_stream_processor", name)
    {
    }

    /// <summary>
    /// The identifier for your AWS Key Management Service key (AWS KMS key). You can supply the Amazon Resource Name (ARN) of your KMS key, the ID of your KMS key, an alias for your KMS key, or an alias ARN.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeyId { get; set; }

    /// <summary>
    /// An identifier you assign to the stream processor.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The Amazon Resource Number (ARN) of the IAM role that allows access to the stream processor.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for data_sharing_preference.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("data_sharing_preference")]
    public TerraformList<AwsRekognitionStreamProcessorDataSharingPreferenceBlock> DataSharingPreference { get; set; } = new();

    /// <summary>
    /// Block for input.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("input")]
    public TerraformList<AwsRekognitionStreamProcessorInputBlock> Input { get; set; } = new();

    /// <summary>
    /// Block for notification_channel.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("notification_channel")]
    public TerraformList<AwsRekognitionStreamProcessorNotificationChannelBlock> NotificationChannel { get; set; } = new();

    /// <summary>
    /// Block for output.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("output")]
    public TerraformList<AwsRekognitionStreamProcessorOutputBlock> Output { get; set; } = new();

    /// <summary>
    /// Block for regions_of_interest.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("regions_of_interest")]
    public TerraformList<AwsRekognitionStreamProcessorRegionsOfInterestBlock> RegionsOfInterest { get; set; } = new();

    /// <summary>
    /// Block for settings.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("settings")]
    public TerraformList<AwsRekognitionStreamProcessorSettingsBlock> Settings { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsRekognitionStreamProcessorTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The stream_processor_arn attribute.
    /// </summary>
    [TerraformProperty("stream_processor_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StreamProcessorArn { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TagsAll { get; }

}
