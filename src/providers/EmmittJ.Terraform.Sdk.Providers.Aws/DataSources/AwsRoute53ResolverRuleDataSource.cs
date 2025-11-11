using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_route53_resolver_rule.
/// </summary>
public class AwsRoute53ResolverRuleDataSource : TerraformDataSource
{
    public AwsRoute53ResolverRuleDataSource(string name) : base("aws_route53_resolver_rule", name)
    {
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [TerraformPropertyName("domain_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DomainName { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Name { get; set; } = default!;

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ResolverEndpointId { get; set; } = default!;

    /// <summary>
    /// The resolver_rule_id attribute.
    /// </summary>
    [TerraformPropertyName("resolver_rule_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ResolverRuleId { get; set; } = default!;

    /// <summary>
    /// The rule_type attribute.
    /// </summary>
    [TerraformPropertyName("rule_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> RuleType { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OwnerId => new TerraformReference(this, "owner_id");

    /// <summary>
    /// The share_status attribute.
    /// </summary>
    [TerraformPropertyName("share_status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ShareStatus => new TerraformReference(this, "share_status");

}
