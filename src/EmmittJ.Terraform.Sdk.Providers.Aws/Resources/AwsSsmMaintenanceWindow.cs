using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ssm_maintenance_window resource.
/// </summary>
public class AwsSsmMaintenanceWindow : TerraformResource
{
    public AwsSsmMaintenanceWindow(string name) : base("aws_ssm_maintenance_window", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The allow_unassociated_targets attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? AllowUnassociatedTargets
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_unassociated_targets");
        set => this.WithProperty("allow_unassociated_targets", value);
    }

    /// <summary>
    /// The cutoff attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Cutoff
    {
        get => GetProperty<TerraformLiteralProperty<double>>("cutoff");
        set => this.WithProperty("cutoff", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Duration
    {
        get => GetProperty<TerraformLiteralProperty<double>>("duration");
        set => this.WithProperty("duration", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The end_date attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EndDate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("end_date");
        set => this.WithProperty("end_date", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The schedule attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Schedule
    {
        get => GetProperty<TerraformLiteralProperty<string>>("schedule");
        set => this.WithProperty("schedule", value);
    }

    /// <summary>
    /// The schedule_offset attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? ScheduleOffset
    {
        get => GetProperty<TerraformLiteralProperty<double>>("schedule_offset");
        set => this.WithProperty("schedule_offset", value);
    }

    /// <summary>
    /// The schedule_timezone attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ScheduleTimezone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("schedule_timezone");
        set => this.WithProperty("schedule_timezone", value);
    }

    /// <summary>
    /// The start_date attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StartDate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("start_date");
        set => this.WithProperty("start_date", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

}
