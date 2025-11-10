using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for egress in .
/// Nesting mode: set
/// </summary>
public class AwsDefaultNetworkAclEgressBlock : TerraformBlock
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformProperty<string> Action
    {
        get => GetProperty<TerraformProperty<string>>("action");
        set => WithProperty("action", value);
    }

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    public TerraformProperty<string>? CidrBlock
    {
        get => GetProperty<TerraformProperty<string>>("cidr_block");
        set => WithProperty("cidr_block", value);
    }

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FromPort is required")]
    public required TerraformProperty<double> FromPort
    {
        get => GetProperty<TerraformProperty<double>>("from_port");
        set => WithProperty("from_port", value);
    }

    /// <summary>
    /// The icmp_code attribute.
    /// </summary>
    public TerraformProperty<double>? IcmpCode
    {
        get => GetProperty<TerraformProperty<double>>("icmp_code");
        set => WithProperty("icmp_code", value);
    }

    /// <summary>
    /// The icmp_type attribute.
    /// </summary>
    public TerraformProperty<double>? IcmpType
    {
        get => GetProperty<TerraformProperty<double>>("icmp_type");
        set => WithProperty("icmp_type", value);
    }

    /// <summary>
    /// The ipv6_cidr_block attribute.
    /// </summary>
    public TerraformProperty<string>? Ipv6CidrBlock
    {
        get => GetProperty<TerraformProperty<string>>("ipv6_cidr_block");
        set => WithProperty("ipv6_cidr_block", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
    {
        get => GetProperty<TerraformProperty<string>>("protocol");
        set => WithProperty("protocol", value);
    }

    /// <summary>
    /// The rule_no attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleNo is required")]
    public required TerraformProperty<double> RuleNo
    {
        get => GetProperty<TerraformProperty<double>>("rule_no");
        set => WithProperty("rule_no", value);
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ToPort is required")]
    public required TerraformProperty<double> ToPort
    {
        get => GetProperty<TerraformProperty<double>>("to_port");
        set => WithProperty("to_port", value);
    }

}

/// <summary>
/// Block type for ingress in .
/// Nesting mode: set
/// </summary>
public class AwsDefaultNetworkAclIngressBlock : TerraformBlock
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformProperty<string> Action
    {
        get => GetProperty<TerraformProperty<string>>("action");
        set => WithProperty("action", value);
    }

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    public TerraformProperty<string>? CidrBlock
    {
        get => GetProperty<TerraformProperty<string>>("cidr_block");
        set => WithProperty("cidr_block", value);
    }

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FromPort is required")]
    public required TerraformProperty<double> FromPort
    {
        get => GetProperty<TerraformProperty<double>>("from_port");
        set => WithProperty("from_port", value);
    }

    /// <summary>
    /// The icmp_code attribute.
    /// </summary>
    public TerraformProperty<double>? IcmpCode
    {
        get => GetProperty<TerraformProperty<double>>("icmp_code");
        set => WithProperty("icmp_code", value);
    }

    /// <summary>
    /// The icmp_type attribute.
    /// </summary>
    public TerraformProperty<double>? IcmpType
    {
        get => GetProperty<TerraformProperty<double>>("icmp_type");
        set => WithProperty("icmp_type", value);
    }

    /// <summary>
    /// The ipv6_cidr_block attribute.
    /// </summary>
    public TerraformProperty<string>? Ipv6CidrBlock
    {
        get => GetProperty<TerraformProperty<string>>("ipv6_cidr_block");
        set => WithProperty("ipv6_cidr_block", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
    {
        get => GetProperty<TerraformProperty<string>>("protocol");
        set => WithProperty("protocol", value);
    }

    /// <summary>
    /// The rule_no attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleNo is required")]
    public required TerraformProperty<double> RuleNo
    {
        get => GetProperty<TerraformProperty<double>>("rule_no");
        set => WithProperty("rule_no", value);
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ToPort is required")]
    public required TerraformProperty<double> ToPort
    {
        get => GetProperty<TerraformProperty<double>>("to_port");
        set => WithProperty("to_port", value);
    }

}

/// <summary>
/// Manages a aws_default_network_acl resource.
/// </summary>
public class AwsDefaultNetworkAcl : TerraformResource
{
    public AwsDefaultNetworkAcl(string name) : base("aws_default_network_acl", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("owner_id");
        this.DeclareOutput("vpc_id");
    }

    /// <summary>
    /// The default_network_acl_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultNetworkAclId is required")]
    public required TerraformProperty<string> DefaultNetworkAclId
    {
        get => GetProperty<TerraformProperty<string>>("default_network_acl_id");
        set => this.WithProperty("default_network_acl_id", value);
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
    /// The subnet_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SubnetIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("subnet_ids");
        set => this.WithProperty("subnet_ids", value);
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
    /// Block for egress.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsDefaultNetworkAclEgressBlock>? Egress
    {
        get => GetProperty<HashSet<AwsDefaultNetworkAclEgressBlock>>("egress");
        set => this.WithProperty("egress", value);
    }

    /// <summary>
    /// Block for ingress.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsDefaultNetworkAclIngressBlock>? Ingress
    {
        get => GetProperty<HashSet<AwsDefaultNetworkAclIngressBlock>>("ingress");
        set => this.WithProperty("ingress", value);
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
    /// The vpc_id attribute.
    /// </summary>
    public TerraformExpression VpcId => this["vpc_id"];

}
