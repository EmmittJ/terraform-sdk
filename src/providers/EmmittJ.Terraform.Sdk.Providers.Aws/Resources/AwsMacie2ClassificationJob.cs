using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for s3_job_definition in .
/// Nesting mode: list
/// </summary>
public class AwsMacie2ClassificationJobS3JobDefinitionBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for schedule_frequency in .
/// Nesting mode: list
/// </summary>
public class AwsMacie2ClassificationJobScheduleFrequencyBlock : ITerraformBlock
{
    /// <summary>
    /// The daily_schedule attribute.
    /// </summary>
    [TerraformPropertyName("daily_schedule")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DailySchedule { get; set; }

    /// <summary>
    /// The monthly_schedule attribute.
    /// </summary>
    [TerraformPropertyName("monthly_schedule")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MonthlySchedule { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "monthly_schedule");

    /// <summary>
    /// The weekly_schedule attribute.
    /// </summary>
    [TerraformPropertyName("weekly_schedule")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> WeeklySchedule { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "weekly_schedule");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsMacie2ClassificationJobTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> CustomDataIdentifierIds { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "custom_data_identifier_ids");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Description { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The initial_run attribute.
    /// </summary>
    [TerraformPropertyName("initial_run")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? InitialRun { get; set; }

    /// <summary>
    /// The job_status attribute.
    /// </summary>
    [TerraformPropertyName("job_status")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> JobStatus { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "job_status");

    /// <summary>
    /// The job_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobType is required")]
    [TerraformPropertyName("job_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> JobType { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Name { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformPropertyName("name_prefix")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NamePrefix { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name_prefix");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The sampling_percentage attribute.
    /// </summary>
    [TerraformPropertyName("sampling_percentage")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> SamplingPercentage { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "sampling_percentage");

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
    /// Block for s3_job_definition.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3JobDefinition is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 S3JobDefinition block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3JobDefinition block(s) allowed")]
    [TerraformPropertyName("s3_job_definition")]
    public TerraformList<TerraformBlock<AwsMacie2ClassificationJobS3JobDefinitionBlock>>? S3JobDefinition { get; set; } = new();

    /// <summary>
    /// Block for schedule_frequency.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScheduleFrequency block(s) allowed")]
    [TerraformPropertyName("schedule_frequency")]
    public TerraformList<TerraformBlock<AwsMacie2ClassificationJobScheduleFrequencyBlock>>? ScheduleFrequency { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsMacie2ClassificationJobTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedAt => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_at");

    /// <summary>
    /// The job_arn attribute.
    /// </summary>
    [TerraformPropertyName("job_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> JobArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "job_arn");

    /// <summary>
    /// The job_id attribute.
    /// </summary>
    [TerraformPropertyName("job_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> JobId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "job_id");

    /// <summary>
    /// The user_paused_details attribute.
    /// </summary>
    [TerraformPropertyName("user_paused_details")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> UserPausedDetails => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "user_paused_details");

}
