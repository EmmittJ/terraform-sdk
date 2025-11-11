using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for limits_per_label_set in .
/// Nesting mode: list
/// </summary>
public partial class AwsPrometheusWorkspaceConfigurationLimitsPerLabelSetBlock : TerraformBlockBase
{
    /// <summary>
    /// The label_set attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LabelSet is required")]
    [TerraformProperty("label_set")]
    // Required argument - source generator will implement get/set
    public required partial TerraformMap<string> LabelSet { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsPrometheusWorkspaceConfigurationTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_prometheus_workspace_configuration resource.
/// </summary>
public partial class AwsPrometheusWorkspaceConfiguration : TerraformResource
{
    public AwsPrometheusWorkspaceConfiguration(string name) : base("aws_prometheus_workspace_configuration", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The retention_period_in_days attribute.
    /// </summary>
    [TerraformProperty("retention_period_in_days")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> RetentionPeriodInDays { get; set; }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    [TerraformProperty("workspace_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> WorkspaceId { get; set; }

    /// <summary>
    /// Block for limits_per_label_set.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("limits_per_label_set")]
    public partial TerraformList<TerraformBlock<AwsPrometheusWorkspaceConfigurationLimitsPerLabelSetBlock>>? LimitsPerLabelSet { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsPrometheusWorkspaceConfigurationTimeoutsBlock>? Timeouts { get; set; }

}
