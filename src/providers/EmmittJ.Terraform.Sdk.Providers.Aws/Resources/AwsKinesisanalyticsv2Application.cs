using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for application_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlock() : TerraformBlock("application_configuration")
{
}

/// <summary>
/// Block type for cloudwatch_logging_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsKinesisanalyticsv2ApplicationCloudwatchLoggingOptionsBlock() : TerraformBlock("cloudwatch_logging_options")
{

    /// <summary>
    /// The log_stream_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogStreamArn is required")]
    [TerraformProperty("log_stream_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LogStreamArn { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsKinesisanalyticsv2ApplicationTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_kinesisanalyticsv2_application resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsKinesisanalyticsv2Application : TerraformResource
{
    public AwsKinesisanalyticsv2Application(string name) : base("aws_kinesisanalyticsv2_application", name)
    {
    }

    /// <summary>
    /// The application_mode attribute.
    /// </summary>
    [TerraformProperty("application_mode")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ApplicationMode { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The force_stop attribute.
    /// </summary>
    [TerraformProperty("force_stop")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ForceStop { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
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
    /// The runtime_environment attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuntimeEnvironment is required")]
    [TerraformProperty("runtime_environment")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RuntimeEnvironment { get; set; }

    /// <summary>
    /// The service_execution_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceExecutionRole is required")]
    [TerraformProperty("service_execution_role")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServiceExecutionRole { get; set; }

    /// <summary>
    /// The start_application attribute.
    /// </summary>
    [TerraformProperty("start_application")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? StartApplication { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for application_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApplicationConfiguration block(s) allowed")]
    [TerraformProperty("application_configuration")]
    public TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlock> ApplicationConfiguration { get; set; } = new();

    /// <summary>
    /// Block for cloudwatch_logging_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudwatchLoggingOptions block(s) allowed")]
    [TerraformProperty("cloudwatch_logging_options")]
    public TerraformList<AwsKinesisanalyticsv2ApplicationCloudwatchLoggingOptionsBlock> CloudwatchLoggingOptions { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsKinesisanalyticsv2ApplicationTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The create_timestamp attribute.
    /// </summary>
    [TerraformProperty("create_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTimestamp { get; }

    /// <summary>
    /// The last_update_timestamp attribute.
    /// </summary>
    [TerraformProperty("last_update_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastUpdateTimestamp { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    [TerraformProperty("version_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> VersionId { get; }

}
