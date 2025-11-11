using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for limits_per_label_set in .
/// Nesting mode: list
/// </summary>
public class AwsPrometheusWorkspaceConfigurationLimitsPerLabelSetBlock
{
    /// <summary>
    /// The label_set attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LabelSet is required")]
    [TerraformPropertyName("label_set")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformMap<string> LabelSet { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsPrometheusWorkspaceConfigurationTimeoutsBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_prometheus_workspace_configuration resource.
/// </summary>
public class AwsPrometheusWorkspaceConfiguration : TerraformResource
{
    public AwsPrometheusWorkspaceConfiguration(string name) : base("aws_prometheus_workspace_configuration", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The retention_period_in_days attribute.
    /// </summary>
    [TerraformPropertyName("retention_period_in_days")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> RetentionPeriodInDays { get; set; } = default!;

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    [TerraformPropertyName("workspace_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> WorkspaceId { get; set; }

    /// <summary>
    /// Block for limits_per_label_set.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("limits_per_label_set")]
    public TerraformList<TerraformBlock<AwsPrometheusWorkspaceConfigurationLimitsPerLabelSetBlock>>? LimitsPerLabelSet { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsPrometheusWorkspaceConfigurationTimeoutsBlock>? Timeouts { get; set; }

}
