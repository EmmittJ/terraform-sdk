using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_route53_resolver_firewall_rule_group.
/// </summary>
public class AwsRoute53ResolverFirewallRuleGroupDataSource : TerraformDataSource
{
    public AwsRoute53ResolverFirewallRuleGroupDataSource(string name) : base("aws_route53_resolver_firewall_rule_group", name)
    {
    }

    /// <summary>
    /// The firewall_rule_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallRuleGroupId is required")]
    [TerraformPropertyName("firewall_rule_group_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> FirewallRuleGroupId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    [TerraformPropertyName("creation_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_time");

    /// <summary>
    /// The creator_request_id attribute.
    /// </summary>
    [TerraformPropertyName("creator_request_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatorRequestId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creator_request_id");

    /// <summary>
    /// The modification_time attribute.
    /// </summary>
    [TerraformPropertyName("modification_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ModificationTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "modification_time");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OwnerId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "owner_id");

    /// <summary>
    /// The rule_count attribute.
    /// </summary>
    [TerraformPropertyName("rule_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> RuleCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "rule_count");

    /// <summary>
    /// The share_status attribute.
    /// </summary>
    [TerraformPropertyName("share_status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ShareStatus => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "share_status");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// The status_message attribute.
    /// </summary>
    [TerraformPropertyName("status_message")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StatusMessage => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status_message");

}
