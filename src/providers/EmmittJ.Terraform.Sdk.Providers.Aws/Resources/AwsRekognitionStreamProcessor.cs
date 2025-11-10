using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for data_sharing_preference in .
/// Nesting mode: list
/// </summary>
public class AwsRekognitionStreamProcessorDataSharingPreferenceBlock : TerraformBlock
{
    /// <summary>
    /// Do you want to share data with Rekognition to improve model performance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OptIn is required")]
    public required TerraformProperty<bool> OptIn
    {
        set => SetProperty("opt_in", value);
    }

}

/// <summary>
/// Block type for input in .
/// Nesting mode: list
/// </summary>
public class AwsRekognitionStreamProcessorInputBlock : TerraformBlock
{
}

/// <summary>
/// Block type for notification_channel in .
/// Nesting mode: list
/// </summary>
public class AwsRekognitionStreamProcessorNotificationChannelBlock : TerraformBlock
{
    /// <summary>
    /// The Amazon Resource Number (ARN) of the Amazon Amazon Simple Notification Service topic to which Amazon Rekognition posts the completion status.
    /// </summary>
    public TerraformProperty<string>? SnsTopicArn
    {
        set => SetProperty("sns_topic_arn", value);
    }

}

/// <summary>
/// Block type for output in .
/// Nesting mode: list
/// </summary>
public class AwsRekognitionStreamProcessorOutputBlock : TerraformBlock
{
}

/// <summary>
/// Block type for regions_of_interest in .
/// Nesting mode: list
/// </summary>
public class AwsRekognitionStreamProcessorRegionsOfInterestBlock : TerraformBlock
{
}

/// <summary>
/// Block type for settings in .
/// Nesting mode: list
/// </summary>
public class AwsRekognitionStreamProcessorSettingsBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRekognitionStreamProcessorTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_rekognition_stream_processor resource.
/// </summary>
public class AwsRekognitionStreamProcessor : TerraformResource
{
    public AwsRekognitionStreamProcessor(string name) : base("aws_rekognition_stream_processor", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("stream_processor_arn");
        SetOutput("tags_all");
        SetOutput("kms_key_id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("role_arn");
        SetOutput("tags");
    }

    /// <summary>
    /// The identifier for your AWS Key Management Service key (AWS KMS key). You can supply the Amazon Resource Name (ARN) of your KMS key, the ID of your KMS key, an alias for your KMS key, or an alias ARN.
    /// </summary>
    public TerraformProperty<string> KmsKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_id");
        set => SetProperty("kms_key_id", value);
    }

    /// <summary>
    /// An identifier you assign to the stream processor.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// The Amazon Resource Number (ARN) of the IAM role that allows access to the stream processor.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_arn");
        set => SetProperty("role_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for data_sharing_preference.
    /// Nesting mode: list
    /// </summary>
    public List<AwsRekognitionStreamProcessorDataSharingPreferenceBlock>? DataSharingPreference
    {
        set => SetProperty("data_sharing_preference", value);
    }

    /// <summary>
    /// Block for input.
    /// Nesting mode: list
    /// </summary>
    public List<AwsRekognitionStreamProcessorInputBlock>? Input
    {
        set => SetProperty("input", value);
    }

    /// <summary>
    /// Block for notification_channel.
    /// Nesting mode: list
    /// </summary>
    public List<AwsRekognitionStreamProcessorNotificationChannelBlock>? NotificationChannel
    {
        set => SetProperty("notification_channel", value);
    }

    /// <summary>
    /// Block for output.
    /// Nesting mode: list
    /// </summary>
    public List<AwsRekognitionStreamProcessorOutputBlock>? Output
    {
        set => SetProperty("output", value);
    }

    /// <summary>
    /// Block for regions_of_interest.
    /// Nesting mode: list
    /// </summary>
    public List<AwsRekognitionStreamProcessorRegionsOfInterestBlock>? RegionsOfInterest
    {
        set => SetProperty("regions_of_interest", value);
    }

    /// <summary>
    /// Block for settings.
    /// Nesting mode: list
    /// </summary>
    public List<AwsRekognitionStreamProcessorSettingsBlock>? Settings
    {
        set => SetProperty("settings", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsRekognitionStreamProcessorTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The stream_processor_arn attribute.
    /// </summary>
    public TerraformExpression StreamProcessorArn => this["stream_processor_arn"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
