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
        get => new TerraformReference<string>(this, "firewall_rule_group_association_id");
        set => SetArgument("firewall_rule_group_association_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    public TerraformValue<string> CreationTime
    {
        get => new TerraformReference<string>(this, "creation_time");
    }

    /// <summary>
    /// The creator_request_id attribute.
    /// </summary>
    public TerraformValue<string> CreatorRequestId
    {
        get => new TerraformReference<string>(this, "creator_request_id");
    }

    /// <summary>
    /// The firewall_rule_group_id attribute.
    /// </summary>
    public TerraformValue<string> FirewallRuleGroupId
    {
        get => new TerraformReference<string>(this, "firewall_rule_group_id");
    }

    /// <summary>
    /// The managed_owner_name attribute.
    /// </summary>
    public TerraformValue<string> ManagedOwnerName
    {
        get => new TerraformReference<string>(this, "managed_owner_name");
    }

    /// <summary>
    /// The modification_time attribute.
    /// </summary>
    public TerraformValue<string> ModificationTime
    {
        get => new TerraformReference<string>(this, "modification_time");
    }

    /// <summary>
    /// The mutation_protection attribute.
    /// </summary>
    public TerraformValue<string> MutationProtection
    {
        get => new TerraformReference<string>(this, "mutation_protection");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformValue<double> Priority
    {
        get => new TerraformReference<double>(this, "priority");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// The status_message attribute.
    /// </summary>
    public TerraformValue<string> StatusMessage
    {
        get => new TerraformReference<string>(this, "status_message");
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
    {
        get => new TerraformReference<string>(this, "vpc_id");
    }

}
