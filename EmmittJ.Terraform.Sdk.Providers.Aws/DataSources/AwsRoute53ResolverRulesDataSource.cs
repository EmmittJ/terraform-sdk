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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name_regex attribute.
    /// </summary>
    public string? NameRegex
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name_regex")?.Value;
        set => this.WithProperty("name_regex", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public string? OwnerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("owner_id")?.Value;
        set => this.WithProperty("owner_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resolver_endpoint_id attribute.
    /// </summary>
    public string? ResolverEndpointId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resolver_endpoint_id")?.Value;
        set => this.WithProperty("resolver_endpoint_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The rule_type attribute.
    /// </summary>
    public string? RuleType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("rule_type")?.Value;
        set => this.WithProperty("rule_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The share_status attribute.
    /// </summary>
    public string? ShareStatus
    {
        get => GetProperty<TerraformLiteralProperty<string>>("share_status")?.Value;
        set => this.WithProperty("share_status", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resolver_rule_ids attribute.
    /// </summary>
    public TerraformExpression ResolverRuleIds => this["resolver_rule_ids"];

}
