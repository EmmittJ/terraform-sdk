using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for flexible_time_window in .
/// Nesting mode: list
/// </summary>
public class AwsSchedulerScheduleFlexibleTimeWindowBlock : TerraformBlock
{
    /// <summary>
    /// The maximum_window_in_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? MaximumWindowInMinutes
    {
        set => SetProperty("maximum_window_in_minutes", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformProperty<string> Mode
    {
        set => SetProperty("mode", value);
    }

}

/// <summary>
/// Block type for target in .
/// Nesting mode: list
/// </summary>
public class AwsSchedulerScheduleTargetBlock : TerraformBlock
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformProperty<string> Arn
    {
        set => SetProperty("arn", value);
    }

    /// <summary>
    /// The input attribute.
    /// </summary>
    public TerraformProperty<string>? Input
    {
        set => SetProperty("input", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        set => SetProperty("role_arn", value);
    }

}

/// <summary>
/// Manages a aws_scheduler_schedule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSchedulerSchedule : TerraformResource
{
    public AwsSchedulerSchedule(string name) : base("aws_scheduler_schedule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("action_after_completion");
        SetOutput("description");
        SetOutput("end_date");
        SetOutput("group_name");
        SetOutput("id");
        SetOutput("kms_key_arn");
        SetOutput("name");
        SetOutput("name_prefix");
        SetOutput("region");
        SetOutput("schedule_expression");
        SetOutput("schedule_expression_timezone");
        SetOutput("start_date");
        SetOutput("state");
    }

    /// <summary>
    /// The action_after_completion attribute.
    /// </summary>
    public TerraformProperty<string> ActionAfterCompletion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("action_after_completion");
        set => SetProperty("action_after_completion", value);
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
    /// The end_date attribute.
    /// </summary>
    public TerraformProperty<string> EndDate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("end_date");
        set => SetProperty("end_date", value);
    }

    /// <summary>
    /// The group_name attribute.
    /// </summary>
    public TerraformProperty<string> GroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("group_name");
        set => SetProperty("group_name", value);
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
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string> KmsKeyArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_arn");
        set => SetProperty("kms_key_arn", value);
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
    /// The schedule_expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScheduleExpression is required")]
    public required TerraformProperty<string> ScheduleExpression
    {
        get => GetRequiredOutput<TerraformProperty<string>>("schedule_expression");
        set => SetProperty("schedule_expression", value);
    }

    /// <summary>
    /// The schedule_expression_timezone attribute.
    /// </summary>
    public TerraformProperty<string> ScheduleExpressionTimezone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("schedule_expression_timezone");
        set => SetProperty("schedule_expression_timezone", value);
    }

    /// <summary>
    /// The start_date attribute.
    /// </summary>
    public TerraformProperty<string> StartDate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("start_date");
        set => SetProperty("start_date", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformProperty<string> State
    {
        get => GetRequiredOutput<TerraformProperty<string>>("state");
        set => SetProperty("state", value);
    }

    /// <summary>
    /// Block for flexible_time_window.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FlexibleTimeWindow is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FlexibleTimeWindow block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FlexibleTimeWindow block(s) allowed")]
    public List<AwsSchedulerScheduleFlexibleTimeWindowBlock>? FlexibleTimeWindow
    {
        set => SetProperty("flexible_time_window", value);
    }

    /// <summary>
    /// Block for target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Target block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Target block(s) allowed")]
    public List<AwsSchedulerScheduleTargetBlock>? Target
    {
        set => SetProperty("target", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
