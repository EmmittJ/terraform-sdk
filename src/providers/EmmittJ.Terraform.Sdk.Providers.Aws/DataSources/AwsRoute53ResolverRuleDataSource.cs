using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_route53_resolver_rule.
/// </summary>
public partial class AwsRoute53ResolverRuleDataSource : TerraformDataSource
{
    public AwsRoute53ResolverRuleDataSource(string name) : base("aws_route53_resolver_rule", name)
    {
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [TerraformProperty("domain_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The resolver_endpoint_id attribute.
    /// </summary>
    [TerraformProperty("resolver_endpoint_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ResolverEndpointId { get; set; }

    /// <summary>
    /// The resolver_rule_id attribute.
    /// </summary>
    [TerraformProperty("resolver_rule_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ResolverRuleId { get; set; }

    /// <summary>
    /// The rule_type attribute.
    /// </summary>
    [TerraformProperty("rule_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> RuleType { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformProperty("owner_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OwnerId { get; }

    /// <summary>
    /// The share_status attribute.
    /// </summary>
    [TerraformProperty("share_status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ShareStatus { get; }

}
