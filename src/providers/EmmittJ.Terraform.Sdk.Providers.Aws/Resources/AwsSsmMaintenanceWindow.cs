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
        SetOutput("allow_unassociated_targets");
        SetOutput("cutoff");
        SetOutput("description");
        SetOutput("duration");
        SetOutput("enabled");
        SetOutput("end_date");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("schedule");
        SetOutput("schedule_offset");
        SetOutput("schedule_timezone");
        SetOutput("start_date");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The allow_unassociated_targets attribute.
    /// </summary>
    public TerraformProperty<bool> AllowUnassociatedTargets
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("allow_unassociated_targets");
        set => SetProperty("allow_unassociated_targets", value);
    }

    /// <summary>
    /// The cutoff attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cutoff is required")]
    public required TerraformProperty<double> Cutoff
    {
        get => GetRequiredOutput<TerraformProperty<double>>("cutoff");
        set => SetProperty("cutoff", value);
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
    /// The duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    public required TerraformProperty<double> Duration
    {
        get => GetRequiredOutput<TerraformProperty<double>>("duration");
        set => SetProperty("duration", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool> Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled");
        set => SetProperty("enabled", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// The schedule attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    public required TerraformProperty<string> Schedule
    {
        get => GetRequiredOutput<TerraformProperty<string>>("schedule");
        set => SetProperty("schedule", value);
    }

    /// <summary>
    /// The schedule_offset attribute.
    /// </summary>
    public TerraformProperty<double> ScheduleOffset
    {
        get => GetRequiredOutput<TerraformProperty<double>>("schedule_offset");
        set => SetProperty("schedule_offset", value);
    }

    /// <summary>
    /// The schedule_timezone attribute.
    /// </summary>
    public TerraformProperty<string> ScheduleTimezone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("schedule_timezone");
        set => SetProperty("schedule_timezone", value);
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

}
