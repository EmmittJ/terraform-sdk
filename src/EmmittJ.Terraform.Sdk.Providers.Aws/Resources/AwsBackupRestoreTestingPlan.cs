using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_backup_restore_testing_plan resource.
/// </summary>
public class AwsBackupRestoreTestingPlan : TerraformResource
{
    public AwsBackupRestoreTestingPlan(string name) : base("aws_backup_restore_testing_plan", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("tags_all");
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
    public TerraformProperty<string>? ScheduleExpression
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
    /// The start_window_hours attribute.
    /// </summary>
    public TerraformProperty<double>? StartWindowHours
    {
        get => GetProperty<TerraformProperty<double>>("start_window_hours");
        set => this.WithProperty("start_window_hours", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
