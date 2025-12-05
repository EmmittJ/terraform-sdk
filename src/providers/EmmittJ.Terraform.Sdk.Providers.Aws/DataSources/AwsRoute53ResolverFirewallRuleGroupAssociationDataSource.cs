using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_route53_resolver_firewall_rule_group_association Terraform data source.
/// Retrieves information about a aws_route53_resolver_firewall_rule_group_association.
/// </summary>
public partial class AwsRoute53ResolverFirewallRuleGroupAssociationDataSource(string name) : TerraformDataSource("aws_route53_resolver_firewall_rule_group_association", name)
{
    /// <summary>
    /// The firewall_rule_group_association_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallRuleGroupAssociationId is required")]
    public required TerraformValue<string> FirewallRuleGroupAssociationId
    {
        get => GetRequiredArgument<TerraformValue<string>>("firewall_rule_group_association_id");
        set => SetArgument("firewall_rule_group_association_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    public TerraformValue<string> CreationTime
        => CreateReference("creation_time");

    /// <summary>
    /// The creator_request_id attribute.
    /// </summary>
    public TerraformValue<string> CreatorRequestId
        => CreateReference("creator_request_id");

    /// <summary>
    /// The firewall_rule_group_id attribute.
    /// </summary>
    public TerraformValue<string> FirewallRuleGroupId
        => CreateReference("firewall_rule_group_id");

    /// <summary>
    /// The managed_owner_name attribute.
    /// </summary>
    public TerraformValue<string> ManagedOwnerName
        => CreateReference("managed_owner_name");

    /// <summary>
    /// The modification_time attribute.
    /// </summary>
    public TerraformValue<string> ModificationTime
        => CreateReference("modification_time");

    /// <summary>
    /// The mutation_protection attribute.
    /// </summary>
    public TerraformValue<string> MutationProtection
        => CreateReference("mutation_protection");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformValue<double> Priority
        => CreateReference("priority");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => CreateReference("status");

    /// <summary>
    /// The status_message attribute.
    /// </summary>
    public TerraformValue<string> StatusMessage
        => CreateReference("status_message");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
        => CreateReference("vpc_id");

}
