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
    public bool? AllowUnassociatedTargets
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_unassociated_targets")?.Value;
        set => this.WithProperty("allow_unassociated_targets", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The cutoff attribute.
    /// </summary>
    public double? Cutoff
    {
        get => GetProperty<TerraformLiteralProperty<double>>("cutoff")?.Value;
        set => this.WithProperty("cutoff", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The duration attribute.
    /// </summary>
    public double? Duration
    {
        get => GetProperty<TerraformLiteralProperty<double>>("duration")?.Value;
        set => this.WithProperty("duration", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public bool? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled")?.Value;
        set => this.WithProperty("enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The schedule attribute.
    /// </summary>
    public string? Schedule
    {
        get => GetProperty<TerraformLiteralProperty<string>>("schedule")?.Value;
        set => this.WithProperty("schedule", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The schedule_offset attribute.
    /// </summary>
    public double? ScheduleOffset
    {
        get => GetProperty<TerraformLiteralProperty<double>>("schedule_offset")?.Value;
        set => this.WithProperty("schedule_offset", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The schedule_timezone attribute.
    /// </summary>
    public string? ScheduleTimezone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("schedule_timezone")?.Value;
        set => this.WithProperty("schedule_timezone", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

}
