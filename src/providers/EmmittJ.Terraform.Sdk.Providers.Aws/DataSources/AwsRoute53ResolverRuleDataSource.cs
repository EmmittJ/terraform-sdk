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
        get => GetArgument<TerraformValue<string>>("domain_name") ?? AsReference("domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name") ?? AsReference("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The resolver_endpoint_id attribute.
    /// </summary>
    public TerraformValue<string> ResolverEndpointId
    {
        get => GetArgument<TerraformValue<string>>("resolver_endpoint_id") ?? AsReference("resolver_endpoint_id");
        set => SetArgument("resolver_endpoint_id", value);
    }

    /// <summary>
    /// The resolver_rule_id attribute.
    /// </summary>
    public TerraformValue<string> ResolverRuleId
    {
        get => GetArgument<TerraformValue<string>>("resolver_rule_id") ?? AsReference("resolver_rule_id");
        set => SetArgument("resolver_rule_id", value);
    }

    /// <summary>
    /// The rule_type attribute.
    /// </summary>
    public TerraformValue<string> RuleType
    {
        get => GetArgument<TerraformValue<string>>("rule_type") ?? AsReference("rule_type");
        set => SetArgument("rule_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? AsReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
        => AsReference("owner_id");

    /// <summary>
    /// The share_status attribute.
    /// </summary>
    public TerraformValue<string> ShareStatus
        => AsReference("share_status");

}
