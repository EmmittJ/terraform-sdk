using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_route53_resolver_firewall_rule_group_association.
/// </summary>
public partial class AwsRoute53ResolverFirewallRuleGroupAssociationDataSource : TerraformDataSource
{
    public AwsRoute53ResolverFirewallRuleGroupAssociationDataSource(string name) : base("aws_route53_resolver_firewall_rule_group_association", name)
    {
    }

    /// <summary>
    /// The firewall_rule_group_association_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallRuleGroupAssociationId is required")]
    [TerraformProperty("firewall_rule_group_association_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> FirewallRuleGroupAssociationId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    [TerraformProperty("creation_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreationTime { get; }

    /// <summary>
    /// The creator_request_id attribute.
    /// </summary>
    [TerraformProperty("creator_request_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreatorRequestId { get; }

    /// <summary>
    /// The firewall_rule_group_id attribute.
    /// </summary>
    [TerraformProperty("firewall_rule_group_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> FirewallRuleGroupId { get; }

    /// <summary>
    /// The managed_owner_name attribute.
    /// </summary>
    [TerraformProperty("managed_owner_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ManagedOwnerName { get; }

    /// <summary>
    /// The modification_time attribute.
    /// </summary>
    [TerraformProperty("modification_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ModificationTime { get; }

    /// <summary>
    /// The mutation_protection attribute.
    /// </summary>
    [TerraformProperty("mutation_protection")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> MutationProtection { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformProperty("priority")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> Priority { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

    /// <summary>
    /// The status_message attribute.
    /// </summary>
    [TerraformProperty("status_message")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> StatusMessage { get; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformProperty("vpc_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> VpcId { get; }

}
