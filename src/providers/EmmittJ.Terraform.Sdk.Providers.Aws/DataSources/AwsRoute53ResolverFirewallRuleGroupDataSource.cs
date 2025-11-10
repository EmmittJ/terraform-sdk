using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_route53_resolver_firewall_rule_group.
/// </summary>
public class AwsRoute53ResolverFirewallRuleGroupDataSource : TerraformDataSource
{
    public AwsRoute53ResolverFirewallRuleGroupDataSource(string name) : base("aws_route53_resolver_firewall_rule_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutputrn");
        this.WithOutputreation_time");
        this.WithOutputreator_request_id");
        this.WithOutputodification_time");
        this.WithOutputame");
        this.WithOutputwner_id");
        this.WithOutputule_count");
        this.WithOutputhare_status");
        this.WithOutputtatus");
        this.WithOutputtatus_message");
    }

    /// <summary>
    /// The firewall_rule_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallRuleGroupId is required")]
    public required TerraformProperty<string> FirewallRuleGroupId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("firewall_rule_group_id");
        set => this.WithProperty("firewall_rule_group_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
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
    /// The modification_time attribute.
    /// </summary>
    public TerraformExpression ModificationTime => this["modification_time"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformExpression OwnerId => this["owner_id"];

    /// <summary>
    /// The rule_count attribute.
    /// </summary>
    public TerraformExpression RuleCount => this["rule_count"];

    /// <summary>
    /// The share_status attribute.
    /// </summary>
    public TerraformExpression ShareStatus => this["share_status"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The status_message attribute.
    /// </summary>
    public TerraformExpression StatusMessage => this["status_message"];

}
