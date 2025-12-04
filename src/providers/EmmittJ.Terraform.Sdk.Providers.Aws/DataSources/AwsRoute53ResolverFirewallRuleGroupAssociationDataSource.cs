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
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    public TerraformValue<string> CreationTime
        => AsReference("creation_time");

    /// <summary>
    /// The creator_request_id attribute.
    /// </summary>
    public TerraformValue<string> CreatorRequestId
        => AsReference("creator_request_id");

    /// <summary>
    /// The firewall_rule_group_id attribute.
    /// </summary>
    public TerraformValue<string> FirewallRuleGroupId
        => AsReference("firewall_rule_group_id");

    /// <summary>
    /// The managed_owner_name attribute.
    /// </summary>
    public TerraformValue<string> ManagedOwnerName
        => AsReference("managed_owner_name");

    /// <summary>
    /// The modification_time attribute.
    /// </summary>
    public TerraformValue<string> ModificationTime
        => AsReference("modification_time");

    /// <summary>
    /// The mutation_protection attribute.
    /// </summary>
    public TerraformValue<string> MutationProtection
        => AsReference("mutation_protection");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformValue<double> Priority
        => AsReference("priority");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// The status_message attribute.
    /// </summary>
    public TerraformValue<string> StatusMessage
        => AsReference("status_message");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
        => AsReference("vpc_id");

}
