using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for target_ip in AwsRoute53ResolverRule.
/// Nesting mode: set
/// </summary>
public class AwsRoute53ResolverRuleTargetIpBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target_ip";

    /// <summary>
    /// The ip attribute.
    /// </summary>
    public TerraformValue<string>? Ip
    {
        get => new TerraformReference<string>(this, "ip");
        set => SetArgument("ip", value);
    }

    /// <summary>
    /// The ipv6 attribute.
    /// </summary>
    public TerraformValue<string>? Ipv6
    {
        get => new TerraformReference<string>(this, "ipv6");
        set => SetArgument("ipv6", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformValue<string>? Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsRoute53ResolverRule.
/// Nesting mode: single
/// </summary>
public class AwsRoute53ResolverRuleTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_route53_resolver_rule Terraform resource.
/// Manages a aws_route53_resolver_rule resource.
/// </summary>
public partial class AwsRoute53ResolverRule(string name) : TerraformResource("aws_route53_resolver_rule", name)
{
    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformValue<string> DomainName
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
    public TerraformValue<string>? Name
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
    public TerraformValue<string>? ResolverEndpointId
    {
        get => new TerraformReference<string>(this, "resolver_endpoint_id");
        set => SetArgument("resolver_endpoint_id", value);
    }

    /// <summary>
    /// The rule_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleType is required")]
    public required TerraformValue<string> RuleType
    {
        get => new TerraformReference<string>(this, "rule_type");
        set => SetArgument("rule_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
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

    /// <summary>
    /// TargetIp block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsRoute53ResolverRuleTargetIpBlock>? TargetIp
    {
        get => GetArgument<TerraformSet<AwsRoute53ResolverRuleTargetIpBlock>>("target_ip");
        set => SetArgument("target_ip", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsRoute53ResolverRuleTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsRoute53ResolverRuleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
