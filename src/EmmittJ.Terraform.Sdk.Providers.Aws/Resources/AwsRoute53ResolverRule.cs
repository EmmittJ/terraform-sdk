using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for target_ip in .
/// Nesting mode: set
/// </summary>
public class AwsRoute53ResolverRuleTargetIpBlock : TerraformBlock
{
    /// <summary>
    /// The ip attribute.
    /// </summary>
    public TerraformProperty<string>? Ip
    {
        get => GetProperty<TerraformProperty<string>>("ip");
        set => WithProperty("ip", value);
    }

    /// <summary>
    /// The ipv6 attribute.
    /// </summary>
    public TerraformProperty<string>? Ipv6
    {
        get => GetProperty<TerraformProperty<string>>("ipv6");
        set => WithProperty("ipv6", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformProperty<double>? Port
    {
        get => GetProperty<TerraformProperty<double>>("port");
        set => WithProperty("port", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformProperty<string>? Protocol
    {
        get => GetProperty<TerraformProperty<string>>("protocol");
        set => WithProperty("protocol", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRoute53ResolverRuleTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_route53_resolver_rule resource.
/// </summary>
public class AwsRoute53ResolverRule : TerraformResource
{
    public AwsRoute53ResolverRule(string name) : base("aws_route53_resolver_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("owner_id");
        this.DeclareOutput("share_status");
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformProperty<string> DomainName
    {
        get => GetProperty<TerraformProperty<string>>("domain_name");
        set => this.WithProperty("domain_name", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The resolver_endpoint_id attribute.
    /// </summary>
    public TerraformProperty<string>? ResolverEndpointId
    {
        get => GetProperty<TerraformProperty<string>>("resolver_endpoint_id");
        set => this.WithProperty("resolver_endpoint_id", value);
    }

    /// <summary>
    /// The rule_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleType is required")]
    public required TerraformProperty<string> RuleType
    {
        get => GetProperty<TerraformProperty<string>>("rule_type");
        set => this.WithProperty("rule_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for target_ip.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsRoute53ResolverRuleTargetIpBlock>? TargetIp
    {
        get => GetProperty<HashSet<AwsRoute53ResolverRuleTargetIpBlock>>("target_ip");
        set => this.WithProperty("target_ip", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsRoute53ResolverRuleTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsRoute53ResolverRuleTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
