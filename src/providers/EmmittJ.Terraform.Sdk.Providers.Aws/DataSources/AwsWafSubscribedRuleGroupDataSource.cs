using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_waf_subscribed_rule_group.
/// </summary>
public class AwsWafSubscribedRuleGroupDataSource : TerraformDataSource
{
    public AwsWafSubscribedRuleGroupDataSource(string name) : base("aws_waf_subscribed_rule_group", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    [TerraformPropertyName("metric_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MetricName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Name { get; set; }

}
