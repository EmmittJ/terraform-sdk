using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_route53_resolver_rules.
/// </summary>
public partial class AwsRoute53ResolverRulesDataSource : TerraformDataSource
{
    public AwsRoute53ResolverRulesDataSource(string name) : base("aws_route53_resolver_rules", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name_regex attribute.
    /// </summary>
    [TerraformProperty("name_regex")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NameRegex { get; set; }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformProperty("owner_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OwnerId { get; set; }

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
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ResolverEndpointId { get; set; }

    /// <summary>
    /// The rule_type attribute.
    /// </summary>
    [TerraformProperty("rule_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RuleType { get; set; }

    /// <summary>
    /// The share_status attribute.
    /// </summary>
    [TerraformProperty("share_status")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ShareStatus { get; set; }

    /// <summary>
    /// The resolver_rule_ids attribute.
    /// </summary>
    [TerraformProperty("resolver_rule_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> ResolverRuleIds { get; }

}
