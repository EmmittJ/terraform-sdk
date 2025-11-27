using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_waf_subscribed_rule_group Terraform data source.
/// Retrieves information about a aws_waf_subscribed_rule_group.
/// </summary>
public partial class AwsWafSubscribedRuleGroupDataSource(string name) : TerraformDataSource("aws_waf_subscribed_rule_group", name)
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
    /// The metric_name attribute.
    /// </summary>
    public TerraformValue<string>? MetricName
    {
        get => new TerraformReference<string>(this, "metric_name");
        set => SetArgument("metric_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}
