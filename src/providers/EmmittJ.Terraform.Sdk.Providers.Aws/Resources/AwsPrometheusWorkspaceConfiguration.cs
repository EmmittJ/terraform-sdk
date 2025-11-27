using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for limits_per_label_set in AwsPrometheusWorkspaceConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsPrometheusWorkspaceConfigurationLimitsPerLabelSetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "limits_per_label_set";

    /// <summary>
    /// The label_set attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LabelSet is required")]
    public required TerraformMap<string> LabelSet
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "label_set").ResolveNodes(ctx));
        set => SetArgument("label_set", value);
    }

    /// <summary>
    /// Limits block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsPrometheusWorkspaceConfigurationLimitsPerLabelSetBlockLimitsBlock>? Limits
    {
        get => GetArgument<TerraformList<AwsPrometheusWorkspaceConfigurationLimitsPerLabelSetBlockLimitsBlock>>("limits");
        set => SetArgument("limits", value);
    }

}

/// <summary>
/// Block type for limits in AwsPrometheusWorkspaceConfigurationLimitsPerLabelSetBlock.
/// Nesting mode: list
/// </summary>
public class AwsPrometheusWorkspaceConfigurationLimitsPerLabelSetBlockLimitsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "limits";

    /// <summary>
    /// The max_series attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxSeries is required")]
    public required TerraformValue<double> MaxSeries
    {
        get => new TerraformReference<double>(this, "max_series");
        set => SetArgument("max_series", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsPrometheusWorkspaceConfiguration.
/// Nesting mode: single
/// </summary>
public class AwsPrometheusWorkspaceConfigurationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_prometheus_workspace_configuration Terraform resource.
/// Manages a aws_prometheus_workspace_configuration resource.
/// </summary>
public partial class AwsPrometheusWorkspaceConfiguration(string name) : TerraformResource("aws_prometheus_workspace_configuration", name)
{
    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The retention_period_in_days attribute.
    /// </summary>
    public TerraformValue<double> RetentionPeriodInDays
    {
        get => new TerraformReference<double>(this, "retention_period_in_days");
        set => SetArgument("retention_period_in_days", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformValue<string> WorkspaceId
    {
        get => new TerraformReference<string>(this, "workspace_id");
        set => SetArgument("workspace_id", value);
    }

    /// <summary>
    /// LimitsPerLabelSet block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsPrometheusWorkspaceConfigurationLimitsPerLabelSetBlock>? LimitsPerLabelSet
    {
        get => GetArgument<TerraformList<AwsPrometheusWorkspaceConfigurationLimitsPerLabelSetBlock>>("limits_per_label_set");
        set => SetArgument("limits_per_label_set", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsPrometheusWorkspaceConfigurationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsPrometheusWorkspaceConfigurationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
