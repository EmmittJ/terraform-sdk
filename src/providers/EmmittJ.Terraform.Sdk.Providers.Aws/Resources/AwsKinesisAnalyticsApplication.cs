using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cloudwatch_logging_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsKinesisAnalyticsApplicationCloudwatchLoggingOptionsBlock : TerraformBlockBase
{

    /// <summary>
    /// The log_stream_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogStreamArn is required")]
    [TerraformProperty("log_stream_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LogStreamArn { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

}

/// <summary>
/// Block type for inputs in .
/// Nesting mode: list
/// </summary>
public partial class AwsKinesisAnalyticsApplicationInputsBlock : TerraformBlockBase
{

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamePrefix is required")]
    [TerraformProperty("name_prefix")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NamePrefix { get; set; }


}

/// <summary>
/// Block type for outputs in .
/// Nesting mode: set
/// </summary>
public partial class AwsKinesisAnalyticsApplicationOutputsBlock : TerraformBlockBase
{

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for reference_data_sources in .
/// Nesting mode: list
/// </summary>
public partial class AwsKinesisAnalyticsApplicationReferenceDataSourcesBlock : TerraformBlockBase
{

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    [TerraformProperty("table_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TableName { get; set; }

}

/// <summary>
/// Manages a aws_kinesis_analytics_application resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsKinesisAnalyticsApplication : TerraformResource
{
    public AwsKinesisAnalyticsApplication(string name) : base("aws_kinesis_analytics_application", name)
    {
    }

    /// <summary>
    /// The code attribute.
    /// </summary>
    [TerraformProperty("code")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Code { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

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
    /// Block for cloudwatch_logging_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudwatchLoggingOptions block(s) allowed")]
    [TerraformProperty("cloudwatch_logging_options")]
    public partial TerraformList<TerraformBlock<AwsKinesisAnalyticsApplicationCloudwatchLoggingOptionsBlock>>? CloudwatchLoggingOptions { get; set; }

    /// <summary>
    /// Block for inputs.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Inputs block(s) allowed")]
    [TerraformProperty("inputs")]
    public partial TerraformList<TerraformBlock<AwsKinesisAnalyticsApplicationInputsBlock>>? Inputs { get; set; }

    /// <summary>
    /// Block for outputs.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 Outputs block(s) allowed")]
    [TerraformProperty("outputs")]
    public partial TerraformSet<TerraformBlock<AwsKinesisAnalyticsApplicationOutputsBlock>>? Outputs { get; set; }

    /// <summary>
    /// Block for reference_data_sources.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReferenceDataSources block(s) allowed")]
    [TerraformProperty("reference_data_sources")]
    public partial TerraformList<TerraformBlock<AwsKinesisAnalyticsApplicationReferenceDataSourcesBlock>>? ReferenceDataSources { get; set; }

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
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Version { get; }

}
