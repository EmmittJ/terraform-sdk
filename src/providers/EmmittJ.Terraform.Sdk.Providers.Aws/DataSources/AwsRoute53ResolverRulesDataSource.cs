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
        SetOutput("resolver_rule_ids");
        SetOutput("id");
        SetOutput("name_regex");
        SetOutput("owner_id");
        SetOutput("region");
        SetOutput("resolver_endpoint_id");
        SetOutput("rule_type");
        SetOutput("share_status");
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
    /// The name_regex attribute.
    /// </summary>
    public TerraformProperty<string> NameRegex
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name_regex");
        set => SetProperty("name_regex", value);
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformProperty<string> OwnerId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("owner_id");
        set => SetProperty("owner_id", value);
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
    /// The rule_type attribute.
    /// </summary>
    public TerraformProperty<string> RuleType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("rule_type");
        set => SetProperty("rule_type", value);
    }

    /// <summary>
    /// The share_status attribute.
    /// </summary>
    public TerraformProperty<string> ShareStatus
    {
        get => GetRequiredOutput<TerraformProperty<string>>("share_status");
        set => SetProperty("share_status", value);
    }

    /// <summary>
    /// The resolver_rule_ids attribute.
    /// </summary>
    public TerraformExpression ResolverRuleIds => this["resolver_rule_ids"];

}
