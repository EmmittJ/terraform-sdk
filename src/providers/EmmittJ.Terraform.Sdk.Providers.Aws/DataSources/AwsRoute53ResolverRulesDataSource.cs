using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_route53_resolver_rules Terraform data source.
/// Retrieves information about a aws_route53_resolver_rules.
/// </summary>
public partial class AwsRoute53ResolverRulesDataSource(string name) : TerraformDataSource("aws_route53_resolver_rules", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name_regex attribute.
    /// </summary>
    public TerraformValue<string>? NameRegex
    {
        get => new TerraformReference<string>(this, "name_regex");
        set => SetArgument("name_regex", value);
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string>? OwnerId
    {
        get => new TerraformReference<string>(this, "owner_id");
        set => SetArgument("owner_id", value);
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
    public TerraformValue<string>? ResolverEndpointId
    {
        get => new TerraformReference<string>(this, "resolver_endpoint_id");
        set => SetArgument("resolver_endpoint_id", value);
    }

    /// <summary>
    /// The rule_type attribute.
    /// </summary>
    public TerraformValue<string>? RuleType
    {
        get => new TerraformReference<string>(this, "rule_type");
        set => SetArgument("rule_type", value);
    }

    /// <summary>
    /// The share_status attribute.
    /// </summary>
    public TerraformValue<string>? ShareStatus
    {
        get => new TerraformReference<string>(this, "share_status");
        set => SetArgument("share_status", value);
    }

    /// <summary>
    /// The resolver_rule_ids attribute.
    /// </summary>
    public TerraformSet<string> ResolverRuleIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "resolver_rule_ids").ResolveNodes(ctx));
    }

}
