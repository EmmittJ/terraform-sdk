using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_route53_resolver_rules.
/// </summary>
public class AwsRoute53ResolverRulesDataSource : TerraformDataSource
{
    public AwsRoute53ResolverRulesDataSource(string name) : base("aws_route53_resolver_rules", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name_regex attribute.
    /// </summary>
    [TerraformPropertyName("name_regex")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NameRegex { get; set; }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OwnerId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The resolver_endpoint_id attribute.
    /// </summary>
    [TerraformPropertyName("resolver_endpoint_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ResolverEndpointId { get; set; }

    /// <summary>
    /// The rule_type attribute.
    /// </summary>
    [TerraformPropertyName("rule_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RuleType { get; set; }

    /// <summary>
    /// The share_status attribute.
    /// </summary>
    [TerraformPropertyName("share_status")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ShareStatus { get; set; }

    /// <summary>
    /// The resolver_rule_ids attribute.
    /// </summary>
    [TerraformPropertyName("resolver_rule_ids")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> ResolverRuleIds => new TerraformReference(this, "resolver_rule_ids");

}
