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
    public TerraformProperty<bool>? AllowUnassociatedTargets
    {
        get => GetProperty<TerraformProperty<bool>>("allow_unassociated_targets");
        set => this.WithProperty("allow_unassociated_targets", value);
    }

    /// <summary>
    /// The cutoff attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cutoff is required")]
    public required TerraformProperty<double> Cutoff
    {
        get => GetProperty<TerraformProperty<double>>("cutoff");
        set => this.WithProperty("cutoff", value);
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
    /// The duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    public required TerraformProperty<double> Duration
    {
        get => GetProperty<TerraformProperty<double>>("duration");
        set => this.WithProperty("duration", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
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
    /// The schedule attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    public required TerraformProperty<string> Schedule
    {
        get => GetProperty<TerraformProperty<string>>("schedule");
        set => this.WithProperty("schedule", value);
    }

    /// <summary>
    /// The schedule_offset attribute.
    /// </summary>
    public TerraformProperty<double>? ScheduleOffset
    {
        get => GetProperty<TerraformProperty<double>>("schedule_offset");
        set => this.WithProperty("schedule_offset", value);
    }

    /// <summary>
    /// The schedule_timezone attribute.
    /// </summary>
    public TerraformProperty<string>? ScheduleTimezone
    {
        get => GetProperty<TerraformProperty<string>>("schedule_timezone");
        set => this.WithProperty("schedule_timezone", value);
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

}
