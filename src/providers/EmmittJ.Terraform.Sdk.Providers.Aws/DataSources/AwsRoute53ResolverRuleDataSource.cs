using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_route53_resolver_rule.
/// </summary>
public class AwsRoute53ResolverRuleDataSource : TerraformDataSource
{
    public AwsRoute53ResolverRuleDataSource(string name) : base("aws_route53_resolver_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("owner_id");
        SetOutput("share_status");
        SetOutput("domain_name");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("resolver_endpoint_id");
        SetOutput("resolver_rule_id");
        SetOutput("rule_type");
        SetOutput("tags");
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformProperty<string> DomainName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain_name");
        set => SetProperty("domain_name", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// The resolver_endpoint_id attribute.
    /// </summary>
    public TerraformProperty<string> ResolverEndpointId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resolver_endpoint_id");
        set => SetProperty("resolver_endpoint_id", value);
    }

    /// <summary>
    /// The resolver_rule_id attribute.
    /// </summary>
    public TerraformProperty<string> ResolverRuleId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resolver_rule_id");
        set => SetProperty("resolver_rule_id", value);
    }

    /// <summary>
    /// The rule_type attribute.
    /// </summary>
    public TerraformProperty<string> RuleType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("rule_type");
        set => SetProperty("rule_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformExpression OwnerId => this["owner_id"];

    /// <summary>
    /// The share_status attribute.
    /// </summary>
    public TerraformExpression ShareStatus => this["share_status"];

}
