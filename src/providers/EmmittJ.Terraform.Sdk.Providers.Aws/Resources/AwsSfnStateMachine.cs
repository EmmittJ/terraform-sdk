using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for encryption_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsSfnStateMachineEncryptionConfigurationBlock() : TerraformBlock("encryption_configuration")
{
    /// <summary>
    /// The kms_data_key_reuse_period_seconds attribute.
    /// </summary>
    [TerraformProperty("kms_data_key_reuse_period_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? KmsDataKeyReusePeriodSeconds { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeyId { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Type { get; set; }

}

/// <summary>
/// Block type for logging_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsSfnStateMachineLoggingConfigurationBlock() : TerraformBlock("logging_configuration")
{
    /// <summary>
    /// The include_execution_data attribute.
    /// </summary>
    [TerraformProperty("include_execution_data")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IncludeExecutionData { get; set; }

    /// <summary>
    /// The level attribute.
    /// </summary>
    [TerraformProperty("level")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Level { get; set; }

    /// <summary>
    /// The log_destination attribute.
    /// </summary>
    [TerraformProperty("log_destination")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LogDestination { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsSfnStateMachineTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Block type for tracing_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsSfnStateMachineTracingConfigurationBlock() : TerraformBlock("tracing_configuration")
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

}

/// <summary>
/// Manages a aws_sfn_state_machine resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsSfnStateMachine : TerraformResource
{
    public AwsSfnStateMachine(string name) : base("aws_sfn_state_machine", name)
    {
    }

    /// <summary>
    /// The definition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Definition is required")]
    [TerraformProperty("definition")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Definition { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformProperty("name_prefix")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NamePrefix { get; set; }

    /// <summary>
    /// The publish attribute.
    /// </summary>
    [TerraformProperty("publish")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Publish { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The role_arn attribute.
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
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Type { get; set; }

    /// <summary>
    /// Block for encryption_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfiguration block(s) allowed")]
    [TerraformProperty("encryption_configuration")]
    public TerraformList<AwsSfnStateMachineEncryptionConfigurationBlock> EncryptionConfiguration { get; set; } = new();

    /// <summary>
    /// Block for logging_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfiguration block(s) allowed")]
    [TerraformProperty("logging_configuration")]
    public TerraformList<AwsSfnStateMachineLoggingConfigurationBlock> LoggingConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsSfnStateMachineTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for tracing_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TracingConfiguration block(s) allowed")]
    [TerraformProperty("tracing_configuration")]
    public TerraformList<AwsSfnStateMachineTracingConfigurationBlock> TracingConfiguration { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    [TerraformProperty("creation_date")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreationDate { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The revision_id attribute.
    /// </summary>
    [TerraformProperty("revision_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RevisionId { get; }

    /// <summary>
    /// The state_machine_version_arn attribute.
    /// </summary>
    [TerraformProperty("state_machine_version_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StateMachineVersionArn { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

    /// <summary>
    /// The version_description attribute.
    /// </summary>
    [TerraformProperty("version_description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VersionDescription { get; }

}
