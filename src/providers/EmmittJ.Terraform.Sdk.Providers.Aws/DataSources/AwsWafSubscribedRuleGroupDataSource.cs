using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_waf_subscribed_rule_group.
/// </summary>
public partial class AwsWafSubscribedRuleGroupDataSource : TerraformDataSource
{
    public AwsWafSubscribedRuleGroupDataSource(string name) : base("aws_waf_subscribed_rule_group", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    [TerraformProperty("metric_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MetricName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Name { get; set; }

}
