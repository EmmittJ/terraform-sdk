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
        this.DeclareOutput("arn");
        this.DeclareOutput("creation_time");
        this.DeclareOutput("creator_request_id");
        this.DeclareOutput("firewall_rule_group_id");
        this.DeclareOutput("managed_owner_name");
        this.DeclareOutput("modification_time");
        this.DeclareOutput("mutation_protection");
        this.DeclareOutput("name");
        this.DeclareOutput("priority");
        this.DeclareOutput("status");
        this.DeclareOutput("status_message");
        this.DeclareOutput("vpc_id");
    }

    /// <summary>
    /// The firewall_rule_group_association_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FirewallRuleGroupAssociationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("firewall_rule_group_association_id");
        set => this.WithProperty("firewall_rule_group_association_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
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
