using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_route53_resolver_rules.
/// </summary>
public class AwsRoute53ResolverRulesDataSource : TerraformDataSource
{
    public AwsRoute53ResolverRulesDataSource(string name) : base("aws_route53_resolver_rules", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("resolver_rule_ids");
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
    /// The name_regex attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NameRegex
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name_regex");
        set => this.WithProperty("name_regex", value);
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? OwnerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("owner_id");
        set => this.WithProperty("owner_id", value);
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
    /// The resolver_endpoint_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResolverEndpointId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resolver_endpoint_id");
        set => this.WithProperty("resolver_endpoint_id", value);
    }

    /// <summary>
    /// The rule_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RuleType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("rule_type");
        set => this.WithProperty("rule_type", value);
    }

    /// <summary>
    /// The share_status attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ShareStatus
    {
        get => GetProperty<TerraformLiteralProperty<string>>("share_status");
        set => this.WithProperty("share_status", value);
    }

    /// <summary>
    /// The resolver_rule_ids attribute.
    /// </summary>
    public TerraformExpression ResolverRuleIds => this["resolver_rule_ids"];

}
