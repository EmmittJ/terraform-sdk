using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ce_anomaly_monitor Terraform resource.
/// Manages a aws_ce_anomaly_monitor resource.
/// </summary>
public partial class AwsCeAnomalyMonitor(string name) : TerraformResource("aws_ce_anomaly_monitor", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The monitor_dimension attribute.
    /// </summary>
    public TerraformValue<string>? MonitorDimension
    {
        get => GetArgument<TerraformValue<string>>("monitor_dimension");
        set => SetArgument("monitor_dimension", value);
    }

    /// <summary>
    /// The monitor_specification attribute.
    /// </summary>
    public TerraformValue<string>? MonitorSpecification
    {
        get => GetArgument<TerraformValue<string>>("monitor_specification");
        set => SetArgument("monitor_specification", value);
    }

    /// <summary>
    /// The monitor_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MonitorType is required")]
    public required TerraformValue<string> MonitorType
    {
        get => GetRequiredArgument<TerraformValue<string>>("monitor_type");
        set => SetArgument("monitor_type", value);
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

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

}
