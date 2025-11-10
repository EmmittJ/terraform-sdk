using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_route53_resolver_firewall_rule_group_association.
/// </summary>
public class AwsRoute53ResolverFirewallRuleGroupAssociationDataSource : TerraformDataSource
{
    public AwsRoute53ResolverFirewallRuleGroupAssociationDataSource(string name) : base("aws_route53_resolver_firewall_rule_group_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("creation_time");
        SetOutput("creator_request_id");
        SetOutput("firewall_rule_group_id");
        SetOutput("managed_owner_name");
        SetOutput("modification_time");
        SetOutput("mutation_protection");
        SetOutput("name");
        SetOutput("priority");
        SetOutput("status");
        SetOutput("status_message");
        SetOutput("vpc_id");
        SetOutput("firewall_rule_group_association_id");
        SetOutput("id");
        SetOutput("region");
    }

    /// <summary>
    /// The firewall_rule_group_association_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallRuleGroupAssociationId is required")]
    public required TerraformProperty<string> FirewallRuleGroupAssociationId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("firewall_rule_group_association_id");
        set => SetProperty("firewall_rule_group_association_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    public TerraformExpression CreationTime => this["creation_time"];

    /// <summary>
    /// The creator_request_id attribute.
    /// </summary>
    public TerraformExpression CreatorRequestId => this["creator_request_id"];

    /// <summary>
    /// The firewall_rule_group_id attribute.
    /// </summary>
    public TerraformExpression FirewallRuleGroupId => this["firewall_rule_group_id"];

    /// <summary>
    /// The managed_owner_name attribute.
    /// </summary>
    public TerraformExpression ManagedOwnerName => this["managed_owner_name"];

    /// <summary>
    /// The modification_time attribute.
    /// </summary>
    public TerraformExpression ModificationTime => this["modification_time"];

    /// <summary>
    /// The mutation_protection attribute.
    /// </summary>
    public TerraformExpression MutationProtection => this["mutation_protection"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformExpression Priority => this["priority"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The status_message attribute.
    /// </summary>
    public TerraformExpression StatusMessage => this["status_message"];

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformExpression VpcId => this["vpc_id"];

}
