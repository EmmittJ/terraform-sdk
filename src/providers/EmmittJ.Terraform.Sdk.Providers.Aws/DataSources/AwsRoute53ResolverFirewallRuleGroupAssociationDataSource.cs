using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_route53_resolver_firewall_rule_group_association.
/// </summary>
public class AwsRoute53ResolverFirewallRuleGroupAssociationDataSource : TerraformDataSource
{
    public AwsRoute53ResolverFirewallRuleGroupAssociationDataSource(string name) : base("aws_route53_resolver_firewall_rule_group_association", name)
    {
    }

    /// <summary>
    /// The firewall_rule_group_association_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallRuleGroupAssociationId is required")]
    [TerraformPropertyName("firewall_rule_group_association_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> FirewallRuleGroupAssociationId { get; set; }

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
    /// The firewall_rule_group_id attribute.
    /// </summary>
    [TerraformPropertyName("firewall_rule_group_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FirewallRuleGroupId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "firewall_rule_group_id");

    /// <summary>
    /// The managed_owner_name attribute.
    /// </summary>
    [TerraformPropertyName("managed_owner_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ManagedOwnerName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "managed_owner_name");

    /// <summary>
    /// The modification_time attribute.
    /// </summary>
    [TerraformPropertyName("modification_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ModificationTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "modification_time");

    /// <summary>
    /// The mutation_protection attribute.
    /// </summary>
    [TerraformPropertyName("mutation_protection")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MutationProtection => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "mutation_protection");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformPropertyName("priority")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Priority => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "priority");

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

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VpcId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vpc_id");

}
