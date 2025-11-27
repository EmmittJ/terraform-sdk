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
        get => new TerraformReference<bool>(this, "allow_unassociated_targets");
        set => SetArgument("allow_unassociated_targets", value);
    }

    /// <summary>
    /// The cutoff attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cutoff is required")]
    public required TerraformValue<double> Cutoff
    {
        get => new TerraformReference<double>(this, "cutoff");
        set => SetArgument("cutoff", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    public required TerraformValue<double> Duration
    {
        get => new TerraformReference<double>(this, "duration");
        set => SetArgument("duration", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The end_date attribute.
    /// </summary>
    public TerraformValue<string>? EndDate
    {
        get => new TerraformReference<string>(this, "end_date");
        set => SetArgument("end_date", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The schedule attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    public required TerraformValue<string> Schedule
    {
        get => new TerraformReference<string>(this, "schedule");
        set => SetArgument("schedule", value);
    }

    /// <summary>
    /// The schedule_offset attribute.
    /// </summary>
    public TerraformValue<double>? ScheduleOffset
    {
        get => new TerraformReference<double>(this, "schedule_offset");
        set => SetArgument("schedule_offset", value);
    }

    /// <summary>
    /// The schedule_timezone attribute.
    /// </summary>
    public TerraformValue<string>? ScheduleTimezone
    {
        get => new TerraformReference<string>(this, "schedule_timezone");
        set => SetArgument("schedule_timezone", value);
    }

    /// <summary>
    /// The start_date attribute.
    /// </summary>
    public TerraformValue<string>? StartDate
    {
        get => new TerraformReference<string>(this, "start_date");
        set => SetArgument("start_date", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

}
