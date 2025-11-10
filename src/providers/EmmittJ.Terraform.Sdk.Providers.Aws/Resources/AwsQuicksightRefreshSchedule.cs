using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for schedule in .
/// Nesting mode: list
/// </summary>
public class AwsQuicksightRefreshScheduleScheduleBlock : TerraformBlock
{
    /// <summary>
    /// The refresh_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RefreshType is required")]
    public required TerraformProperty<string> RefreshType
    {
        set => SetProperty("refresh_type", value);
    }

    /// <summary>
    /// The start_after_date_time attribute.
    /// </summary>
    public TerraformProperty<string>? StartAfterDateTime
    {
        set => SetProperty("start_after_date_time", value);
    }

}

/// <summary>
/// Manages a aws_quicksight_refresh_schedule resource.
/// </summary>
public class AwsQuicksightRefreshSchedule : TerraformResource
{
    public AwsQuicksightRefreshSchedule(string name) : base("aws_quicksight_refresh_schedule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("id");
        SetOutput("aws_account_id");
        SetOutput("data_set_id");
        SetOutput("region");
        SetOutput("schedule_id");
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformProperty<string> AwsAccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("aws_account_id");
        set => SetProperty("aws_account_id", value);
    }

    /// <summary>
    /// The data_set_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSetId is required")]
    public required TerraformProperty<string> DataSetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("data_set_id");
        set => SetProperty("data_set_id", value);
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
    /// The schedule_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScheduleId is required")]
    public required TerraformProperty<string> ScheduleId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("schedule_id");
        set => SetProperty("schedule_id", value);
    }

    /// <summary>
    /// Block for schedule.
    /// Nesting mode: list
    /// </summary>
    public List<AwsQuicksightRefreshScheduleScheduleBlock>? Schedule
    {
        set => SetProperty("schedule", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
