using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for limits_per_label_set in .
/// Nesting mode: list
/// </summary>
public class AwsPrometheusWorkspaceConfigurationLimitsPerLabelSetBlock : TerraformBlock
{
    /// <summary>
    /// The label_set attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LabelSet is required")]
    public Dictionary<string, TerraformProperty<string>>? LabelSet
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("label_set");
        set => WithProperty("label_set", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsPrometheusWorkspaceConfigurationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_prometheus_workspace_configuration resource.
/// </summary>
public class AwsPrometheusWorkspaceConfiguration : TerraformResource
{
    public AwsPrometheusWorkspaceConfiguration(string name) : base("aws_prometheus_workspace_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The retention_period_in_days attribute.
    /// </summary>
    public TerraformProperty<double>? RetentionPeriodInDays
    {
        get => GetProperty<TerraformProperty<double>>("retention_period_in_days");
        set => this.WithProperty("retention_period_in_days", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformProperty<string> WorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("workspace_id");
        set => this.WithProperty("workspace_id", value);
    }

    /// <summary>
    /// Block for limits_per_label_set.
    /// Nesting mode: list
    /// </summary>
    public List<AwsPrometheusWorkspaceConfigurationLimitsPerLabelSetBlock>? LimitsPerLabelSet
    {
        get => GetProperty<List<AwsPrometheusWorkspaceConfigurationLimitsPerLabelSetBlock>>("limits_per_label_set");
        set => this.WithProperty("limits_per_label_set", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsPrometheusWorkspaceConfigurationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsPrometheusWorkspaceConfigurationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
