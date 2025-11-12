using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for s3_job_definition in .
/// Nesting mode: list
/// </summary>
public partial class AwsMacie2ClassificationJobS3JobDefinitionBlock() : TerraformBlock("s3_job_definition")
{
}

/// <summary>
/// Block type for schedule_frequency in .
/// Nesting mode: list
/// </summary>
public partial class AwsMacie2ClassificationJobScheduleFrequencyBlock() : TerraformBlock("schedule_frequency")
{
    /// <summary>
    /// The daily_schedule attribute.
    /// </summary>
    [TerraformProperty("daily_schedule")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DailySchedule { get; set; }

    /// <summary>
    /// The monthly_schedule attribute.
    /// </summary>
    [TerraformProperty("monthly_schedule")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MonthlySchedule { get; set; }

    /// <summary>
    /// The weekly_schedule attribute.
    /// </summary>
    [TerraformProperty("weekly_schedule")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> WeeklySchedule { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsMacie2ClassificationJobTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_macie2_classification_job resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsMacie2ClassificationJob : TerraformResource
{
    public AwsMacie2ClassificationJob(string name) : base("aws_macie2_classification_job", name)
    {
    }

    /// <summary>
    /// The custom_data_identifier_ids attribute.
    /// </summary>
    [TerraformProperty("custom_data_identifier_ids")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> CustomDataIdentifierIds { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The initial_run attribute.
    /// </summary>
    [TerraformProperty("initial_run")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? InitialRun { get; set; }

    /// <summary>
    /// The job_status attribute.
    /// </summary>
    [TerraformProperty("job_status")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> JobStatus { get; set; }

    /// <summary>
    /// The job_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobType is required")]
    [TerraformProperty("job_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> JobType { get; set; }

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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The sampling_percentage attribute.
    /// </summary>
    [TerraformProperty("sampling_percentage")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> SamplingPercentage { get; set; }

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
    /// Block for s3_job_definition.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3JobDefinition is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 S3JobDefinition block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3JobDefinition block(s) allowed")]
    [TerraformProperty("s3_job_definition")]
    public required TerraformList<AwsMacie2ClassificationJobS3JobDefinitionBlock> S3JobDefinition { get; set; } = new();

    /// <summary>
    /// Block for schedule_frequency.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScheduleFrequency block(s) allowed")]
    [TerraformProperty("schedule_frequency")]
    public TerraformList<AwsMacie2ClassificationJobScheduleFrequencyBlock> ScheduleFrequency { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsMacie2ClassificationJobTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// The job_arn attribute.
    /// </summary>
    [TerraformProperty("job_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> JobArn { get; }

    /// <summary>
    /// The job_id attribute.
    /// </summary>
    [TerraformProperty("job_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> JobId { get; }

    /// <summary>
    /// The user_paused_details attribute.
    /// </summary>
    [TerraformProperty("user_paused_details")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> UserPausedDetails { get; }

}
