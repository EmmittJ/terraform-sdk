using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
    public string? ActionAfterCompletion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("action_after_completion")?.Value;
        set => this.WithProperty("action_after_completion", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The end_date attribute.
    /// </summary>
    public string? EndDate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("end_date")?.Value;
        set => this.WithProperty("end_date", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The group_name attribute.
    /// </summary>
    public string? GroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("group_name")?.Value;
        set => this.WithProperty("group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public string? KmsKeyArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_arn")?.Value;
        set => this.WithProperty("kms_key_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public string? NamePrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name_prefix")?.Value;
        set => this.WithProperty("name_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The schedule_expression attribute.
    /// </summary>
    public string? ScheduleExpression
    {
        get => GetProperty<TerraformLiteralProperty<string>>("schedule_expression")?.Value;
        set => this.WithProperty("schedule_expression", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The schedule_expression_timezone attribute.
    /// </summary>
    public string? ScheduleExpressionTimezone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("schedule_expression_timezone")?.Value;
        set => this.WithProperty("schedule_expression_timezone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The start_date attribute.
    /// </summary>
    public string? StartDate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("start_date")?.Value;
        set => this.WithProperty("start_date", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public string? State
    {
        get => GetProperty<TerraformLiteralProperty<string>>("state")?.Value;
        set => this.WithProperty("state", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
