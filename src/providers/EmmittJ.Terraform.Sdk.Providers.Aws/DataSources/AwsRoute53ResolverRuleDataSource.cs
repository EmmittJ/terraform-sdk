using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_route53_resolver_rule Terraform data source.
/// Retrieves information about a aws_route53_resolver_rule.
/// </summary>
public partial class AwsRoute53ResolverRuleDataSource(string name) : TerraformDataSource("aws_route53_resolver_rule", name)
{
    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformValue<string> DomainName
    {
        get => new TerraformReference<string>(this, "domain_name");
        set => SetArgument("domain_name", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The resolver_endpoint_id attribute.
    /// </summary>
    public TerraformValue<string> ResolverEndpointId
    {
        get => new TerraformReference<string>(this, "resolver_endpoint_id");
        set => SetArgument("resolver_endpoint_id", value);
    }

    /// <summary>
    /// The resolver_rule_id attribute.
    /// </summary>
    public TerraformValue<string> ResolverRuleId
    {
        get => new TerraformReference<string>(this, "resolver_rule_id");
        set => SetArgument("resolver_rule_id", value);
    }

    /// <summary>
    /// The rule_type attribute.
    /// </summary>
    public TerraformValue<string> RuleType
    {
        get => new TerraformReference<string>(this, "rule_type");
        set => SetArgument("rule_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
    {
        get => new TerraformReference<string>(this, "owner_id");
    }

    /// <summary>
    /// The share_status attribute.
    /// </summary>
    public TerraformValue<string> ShareStatus
    {
        get => new TerraformReference<string>(this, "share_status");
    }

}
