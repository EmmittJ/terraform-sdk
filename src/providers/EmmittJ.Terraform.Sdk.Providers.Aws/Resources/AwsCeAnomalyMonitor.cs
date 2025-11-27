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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The monitor_dimension attribute.
    /// </summary>
    public TerraformValue<string>? MonitorDimension
    {
        get => new TerraformReference<string>(this, "monitor_dimension");
        set => SetArgument("monitor_dimension", value);
    }

    /// <summary>
    /// The monitor_specification attribute.
    /// </summary>
    public TerraformValue<string>? MonitorSpecification
    {
        get => new TerraformReference<string>(this, "monitor_specification");
        set => SetArgument("monitor_specification", value);
    }

    /// <summary>
    /// The monitor_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MonitorType is required")]
    public required TerraformValue<string> MonitorType
    {
        get => new TerraformReference<string>(this, "monitor_type");
        set => SetArgument("monitor_type", value);
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

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

}
