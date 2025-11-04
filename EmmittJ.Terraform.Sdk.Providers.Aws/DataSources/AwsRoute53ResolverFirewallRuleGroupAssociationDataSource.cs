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
    public string? FirewallRuleGroupAssociationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("firewall_rule_group_association_id")?.Value;
        set => this.WithProperty("firewall_rule_group_association_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
