using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for application_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for cloudwatch_logging_options in .
/// Nesting mode: list
/// </summary>
public class AwsKinesisanalyticsv2ApplicationCloudwatchLoggingOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The cloudwatch_logging_option_id attribute.
    /// </summary>
    [TerraformPropertyName("cloudwatch_logging_option_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CloudwatchLoggingOptionId => new TerraformReferenceProperty<TerraformProperty<string>>("", "cloudwatch_logging_option_id");

    /// <summary>
    /// The log_stream_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogStreamArn is required")]
    [TerraformPropertyName("log_stream_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> LogStreamArn { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsKinesisanalyticsv2ApplicationTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a aws_kinesisanalyticsv2_application resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsKinesisanalyticsv2Application : TerraformResource
{
    public AwsKinesisanalyticsv2Application(string name) : base("aws_kinesisanalyticsv2_application", name)
    {
    }

    /// <summary>
    /// The application_mode attribute.
    /// </summary>
    [TerraformPropertyName("application_mode")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ApplicationMode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "application_mode");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The force_stop attribute.
    /// </summary>
    [TerraformPropertyName("force_stop")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ForceStop { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
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
    /// The runtime_environment attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuntimeEnvironment is required")]
    [TerraformPropertyName("runtime_environment")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RuntimeEnvironment { get; set; }

    /// <summary>
    /// The service_execution_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceExecutionRole is required")]
    [TerraformPropertyName("service_execution_role")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ServiceExecutionRole { get; set; }

    /// <summary>
    /// The start_application attribute.
    /// </summary>
    [TerraformPropertyName("start_application")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? StartApplication { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for application_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApplicationConfiguration block(s) allowed")]
    [TerraformPropertyName("application_configuration")]
    public TerraformList<TerraformBlock<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlock>>? ApplicationConfiguration { get; set; } = new();

    /// <summary>
    /// Block for cloudwatch_logging_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudwatchLoggingOptions block(s) allowed")]
    [TerraformPropertyName("cloudwatch_logging_options")]
    public TerraformList<TerraformBlock<AwsKinesisanalyticsv2ApplicationCloudwatchLoggingOptionsBlock>>? CloudwatchLoggingOptions { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsKinesisanalyticsv2ApplicationTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The create_timestamp attribute.
    /// </summary>
    [TerraformPropertyName("create_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTimestamp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_timestamp");

    /// <summary>
    /// The last_update_timestamp attribute.
    /// </summary>
    [TerraformPropertyName("last_update_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastUpdateTimestamp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_update_timestamp");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    [TerraformPropertyName("version_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> VersionId => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "version_id");

}
