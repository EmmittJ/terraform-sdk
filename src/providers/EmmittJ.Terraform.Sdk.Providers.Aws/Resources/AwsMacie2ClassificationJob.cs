using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for s3_job_definition in .
/// Nesting mode: list
/// </summary>
public class AwsMacie2ClassificationJobS3JobDefinitionBlock
{
}

/// <summary>
/// Block type for schedule_frequency in .
/// Nesting mode: list
/// </summary>
public class AwsMacie2ClassificationJobScheduleFrequencyBlock
{
    /// <summary>
    /// The daily_schedule attribute.
    /// </summary>
    [TerraformPropertyName("daily_schedule")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DailySchedule { get; set; }

    /// <summary>
    /// The monthly_schedule attribute.
    /// </summary>
    [TerraformPropertyName("monthly_schedule")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> MonthlySchedule { get; set; } = default!;

    /// <summary>
    /// The weekly_schedule attribute.
    /// </summary>
    [TerraformPropertyName("weekly_schedule")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> WeeklySchedule { get; set; } = default!;

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsMacie2ClassificationJobTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_macie2_classification_job resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsMacie2ClassificationJob : TerraformResource
{
    public AwsMacie2ClassificationJob(string name) : base("aws_macie2_classification_job", name)
    {
    }

    /// <summary>
    /// The custom_data_identifier_ids attribute.
    /// </summary>
    [TerraformPropertyName("custom_data_identifier_ids")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> CustomDataIdentifierIds { get; set; } = default!;

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Description { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The initial_run attribute.
    /// </summary>
    [TerraformPropertyName("initial_run")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? InitialRun { get; set; }

    /// <summary>
    /// The job_status attribute.
    /// </summary>
    [TerraformPropertyName("job_status")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> JobStatus { get; set; } = default!;

    /// <summary>
    /// The job_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobType is required")]
    [TerraformPropertyName("job_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> JobType { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Name { get; set; } = default!;

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformPropertyName("name_prefix")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NamePrefix { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The sampling_percentage attribute.
    /// </summary>
    [TerraformPropertyName("sampling_percentage")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> SamplingPercentage { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// Block for s3_job_definition.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3JobDefinition is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 S3JobDefinition block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3JobDefinition block(s) allowed")]
    [TerraformPropertyName("s3_job_definition")]
    public TerraformList<TerraformBlock<AwsMacie2ClassificationJobS3JobDefinitionBlock>>? S3JobDefinition { get; set; }

    /// <summary>
    /// Block for schedule_frequency.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScheduleFrequency block(s) allowed")]
    [TerraformPropertyName("schedule_frequency")]
    public TerraformList<TerraformBlock<AwsMacie2ClassificationJobScheduleFrequencyBlock>>? ScheduleFrequency { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsMacie2ClassificationJobTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreatedAt => new TerraformReference(this, "created_at");

    /// <summary>
    /// The job_arn attribute.
    /// </summary>
    [TerraformPropertyName("job_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> JobArn => new TerraformReference(this, "job_arn");

    /// <summary>
    /// The job_id attribute.
    /// </summary>
    [TerraformPropertyName("job_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> JobId => new TerraformReference(this, "job_id");

    /// <summary>
    /// The user_paused_details attribute.
    /// </summary>
    [TerraformPropertyName("user_paused_details")]
    // Output-only attribute - read-only reference
    public TerraformList<object> UserPausedDetails => new TerraformReference(this, "user_paused_details");

}
