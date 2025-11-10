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
        set => SetProperty("daily_schedule", value);
    }

    /// <summary>
    /// The monthly_schedule attribute.
    /// </summary>
    public TerraformProperty<double>? MonthlySchedule
    {
        set => SetProperty("monthly_schedule", value);
    }

    /// <summary>
    /// The weekly_schedule attribute.
    /// </summary>
    public TerraformProperty<string>? WeeklySchedule
    {
        set => SetProperty("weekly_schedule", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_macie2_classification_job resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsMacie2ClassificationJob : TerraformResource
{
    public AwsMacie2ClassificationJob(string name) : base("aws_macie2_classification_job", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("created_at");
        SetOutput("job_arn");
        SetOutput("job_id");
        SetOutput("user_paused_details");
        SetOutput("custom_data_identifier_ids");
        SetOutput("description");
        SetOutput("id");
        SetOutput("initial_run");
        SetOutput("job_status");
        SetOutput("job_type");
        SetOutput("name");
        SetOutput("name_prefix");
        SetOutput("region");
        SetOutput("sampling_percentage");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The custom_data_identifier_ids attribute.
    /// </summary>
    public List<TerraformProperty<string>> CustomDataIdentifierIds
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("custom_data_identifier_ids");
        set => SetProperty("custom_data_identifier_ids", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The initial_run attribute.
    /// </summary>
    public TerraformProperty<bool> InitialRun
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("initial_run");
        set => SetProperty("initial_run", value);
    }

    /// <summary>
    /// The job_status attribute.
    /// </summary>
    public TerraformProperty<string> JobStatus
    {
        get => GetRequiredOutput<TerraformProperty<string>>("job_status");
        set => SetProperty("job_status", value);
    }

    /// <summary>
    /// The job_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobType is required")]
    public required TerraformProperty<string> JobType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("job_type");
        set => SetProperty("job_type", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string> NamePrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name_prefix");
        set => SetProperty("name_prefix", value);
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
    /// The sampling_percentage attribute.
    /// </summary>
    public TerraformProperty<double> SamplingPercentage
    {
        get => GetRequiredOutput<TerraformProperty<double>>("sampling_percentage");
        set => SetProperty("sampling_percentage", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for s3_job_definition.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3JobDefinition is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 S3JobDefinition block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3JobDefinition block(s) allowed")]
    public List<AwsMacie2ClassificationJobS3JobDefinitionBlock>? S3JobDefinition
    {
        set => SetProperty("s3_job_definition", value);
    }

    /// <summary>
    /// Block for schedule_frequency.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScheduleFrequency block(s) allowed")]
    public List<AwsMacie2ClassificationJobScheduleFrequencyBlock>? ScheduleFrequency
    {
        set => SetProperty("schedule_frequency", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsMacie2ClassificationJobTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
