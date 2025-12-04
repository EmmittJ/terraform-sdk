using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ssm_maintenance_window Terraform resource.
/// Manages a aws_ssm_maintenance_window resource.
/// </summary>
public partial class AwsSsmMaintenanceWindow(string name) : TerraformResource("aws_ssm_maintenance_window", name)
{
    /// <summary>
    /// The allow_unassociated_targets attribute.
    /// </summary>
    public TerraformValue<bool>? AllowUnassociatedTargets
    {
        get => GetArgument<TerraformValue<bool>>("allow_unassociated_targets");
        set => SetArgument("allow_unassociated_targets", value);
    }

    /// <summary>
    /// The cutoff attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cutoff is required")]
    public required TerraformValue<double> Cutoff
    {
        get => GetRequiredArgument<TerraformValue<double>>("cutoff");
        set => SetArgument("cutoff", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    public required TerraformValue<double> Duration
    {
        get => GetRequiredArgument<TerraformValue<double>>("duration");
        set => SetArgument("duration", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The end_date attribute.
    /// </summary>
    public TerraformValue<string>? EndDate
    {
        get => GetArgument<TerraformValue<string>>("end_date");
        set => SetArgument("end_date", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The schedule attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    public required TerraformValue<string> Schedule
    {
        get => GetRequiredArgument<TerraformValue<string>>("schedule");
        set => SetArgument("schedule", value);
    }

    /// <summary>
    /// The schedule_offset attribute.
    /// </summary>
    public TerraformValue<double>? ScheduleOffset
    {
        get => GetArgument<TerraformValue<double>>("schedule_offset");
        set => SetArgument("schedule_offset", value);
    }

    /// <summary>
    /// The schedule_timezone attribute.
    /// </summary>
    public TerraformValue<string>? ScheduleTimezone
    {
        get => GetArgument<TerraformValue<string>>("schedule_timezone");
        set => SetArgument("schedule_timezone", value);
    }

    /// <summary>
    /// The start_date attribute.
    /// </summary>
    public TerraformValue<string>? StartDate
    {
        get => GetArgument<TerraformValue<string>>("start_date");
        set => SetArgument("start_date", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

}
