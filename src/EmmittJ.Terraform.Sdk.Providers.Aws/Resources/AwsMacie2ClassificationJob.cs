using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for s3_job_definition in .
/// Nesting mode: list
/// </summary>
public class AwsMacie2ClassificationJobS3JobDefinitionBlock : TerraformBlock
{
}

/// <summary>
/// Block type for schedule_frequency in .
/// Nesting mode: list
/// </summary>
public class AwsMacie2ClassificationJobScheduleFrequencyBlock : TerraformBlock
{
    /// <summary>
    /// The daily_schedule attribute.
    /// </summary>
    public TerraformProperty<bool>? DailySchedule
    {
        get => GetProperty<TerraformProperty<bool>>("daily_schedule");
        set => WithProperty("daily_schedule", value);
    }

    /// <summary>
    /// The monthly_schedule attribute.
    /// </summary>
    public TerraformProperty<double>? MonthlySchedule
    {
        get => GetProperty<TerraformProperty<double>>("monthly_schedule");
        set => WithProperty("monthly_schedule", value);
    }

    /// <summary>
    /// The weekly_schedule attribute.
    /// </summary>
    public TerraformProperty<string>? WeeklySchedule
    {
        get => GetProperty<TerraformProperty<string>>("weekly_schedule");
        set => WithProperty("weekly_schedule", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsMacie2ClassificationJobTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_macie2_classification_job resource.
/// </summary>
public class AwsMacie2ClassificationJob : TerraformResource
{
    public AwsMacie2ClassificationJob(string name) : base("aws_macie2_classification_job", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("created_at");
        this.DeclareOutput("job_arn");
        this.DeclareOutput("job_id");
        this.DeclareOutput("user_paused_details");
    }

    /// <summary>
    /// The custom_data_identifier_ids attribute.
    /// </summary>
    public List<TerraformProperty<string>>? CustomDataIdentifierIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("custom_data_identifier_ids");
        set => this.WithProperty("custom_data_identifier_ids", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The initial_run attribute.
    /// </summary>
    public TerraformProperty<bool>? InitialRun
    {
        get => GetProperty<TerraformProperty<bool>>("initial_run");
        set => this.WithProperty("initial_run", value);
    }

    /// <summary>
    /// The job_status attribute.
    /// </summary>
    public TerraformProperty<string>? JobStatus
    {
        get => GetProperty<TerraformProperty<string>>("job_status");
        set => this.WithProperty("job_status", value);
    }

    /// <summary>
    /// The job_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobType is required")]
    public required TerraformProperty<string> JobType
    {
        get => GetProperty<TerraformProperty<string>>("job_type");
        set => this.WithProperty("job_type", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? NamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("name_prefix");
        set => this.WithProperty("name_prefix", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The sampling_percentage attribute.
    /// </summary>
    public TerraformProperty<double>? SamplingPercentage
    {
        get => GetProperty<TerraformProperty<double>>("sampling_percentage");
        set => this.WithProperty("sampling_percentage", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for s3_job_definition.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 S3JobDefinition block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3JobDefinition block(s) allowed")]
    public List<AwsMacie2ClassificationJobS3JobDefinitionBlock>? S3JobDefinition
    {
        get => GetProperty<List<AwsMacie2ClassificationJobS3JobDefinitionBlock>>("s3_job_definition");
        set => this.WithProperty("s3_job_definition", value);
    }

    /// <summary>
    /// Block for schedule_frequency.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScheduleFrequency block(s) allowed")]
    public List<AwsMacie2ClassificationJobScheduleFrequencyBlock>? ScheduleFrequency
    {
        get => GetProperty<List<AwsMacie2ClassificationJobScheduleFrequencyBlock>>("schedule_frequency");
        set => this.WithProperty("schedule_frequency", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsMacie2ClassificationJobTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsMacie2ClassificationJobTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The job_arn attribute.
    /// </summary>
    public TerraformExpression JobArn => this["job_arn"];

    /// <summary>
    /// The job_id attribute.
    /// </summary>
    public TerraformExpression JobId => this["job_id"];

    /// <summary>
    /// The user_paused_details attribute.
    /// </summary>
    public TerraformExpression UserPausedDetails => this["user_paused_details"];

}
