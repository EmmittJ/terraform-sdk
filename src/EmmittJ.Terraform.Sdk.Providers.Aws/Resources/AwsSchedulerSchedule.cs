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
        get => GetProperty<TerraformProperty<double>>("maximum_window_in_minutes");
        set => WithProperty("maximum_window_in_minutes", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformProperty<string> Mode
    {
        get => GetProperty<TerraformProperty<string>>("mode");
        set => WithProperty("mode", value);
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
        get => GetProperty<TerraformProperty<string>>("arn");
        set => WithProperty("arn", value);
    }

    /// <summary>
    /// The input attribute.
    /// </summary>
    public TerraformProperty<string>? Input
    {
        get => GetProperty<TerraformProperty<string>>("input");
        set => WithProperty("input", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => WithProperty("role_arn", value);
    }

}

/// <summary>
/// Manages a aws_scheduler_schedule resource.
/// </summary>
public class AwsSchedulerSchedule : TerraformResource
{
    public AwsSchedulerSchedule(string name) : base("aws_scheduler_schedule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The action_after_completion attribute.
    /// </summary>
    public TerraformProperty<string>? ActionAfterCompletion
    {
        get => GetProperty<TerraformProperty<string>>("action_after_completion");
        set => this.WithProperty("action_after_completion", value);
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
    /// The end_date attribute.
    /// </summary>
    public TerraformProperty<string>? EndDate
    {
        get => GetProperty<TerraformProperty<string>>("end_date");
        set => this.WithProperty("end_date", value);
    }

    /// <summary>
    /// The group_name attribute.
    /// </summary>
    public TerraformProperty<string>? GroupName
    {
        get => GetProperty<TerraformProperty<string>>("group_name");
        set => this.WithProperty("group_name", value);
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
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyArn
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_arn");
        set => this.WithProperty("kms_key_arn", value);
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
    /// The schedule_expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScheduleExpression is required")]
    public required TerraformProperty<string> ScheduleExpression
    {
        get => GetProperty<TerraformProperty<string>>("schedule_expression");
        set => this.WithProperty("schedule_expression", value);
    }

    /// <summary>
    /// The schedule_expression_timezone attribute.
    /// </summary>
    public TerraformProperty<string>? ScheduleExpressionTimezone
    {
        get => GetProperty<TerraformProperty<string>>("schedule_expression_timezone");
        set => this.WithProperty("schedule_expression_timezone", value);
    }

    /// <summary>
    /// The start_date attribute.
    /// </summary>
    public TerraformProperty<string>? StartDate
    {
        get => GetProperty<TerraformProperty<string>>("start_date");
        set => this.WithProperty("start_date", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformProperty<string>? State
    {
        get => GetProperty<TerraformProperty<string>>("state");
        set => this.WithProperty("state", value);
    }

    /// <summary>
    /// Block for flexible_time_window.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FlexibleTimeWindow block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FlexibleTimeWindow block(s) allowed")]
    public List<AwsSchedulerScheduleFlexibleTimeWindowBlock>? FlexibleTimeWindow
    {
        get => GetProperty<List<AwsSchedulerScheduleFlexibleTimeWindowBlock>>("flexible_time_window");
        set => this.WithProperty("flexible_time_window", value);
    }

    /// <summary>
    /// Block for target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Target block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Target block(s) allowed")]
    public List<AwsSchedulerScheduleTargetBlock>? Target
    {
        get => GetProperty<List<AwsSchedulerScheduleTargetBlock>>("target");
        set => this.WithProperty("target", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
