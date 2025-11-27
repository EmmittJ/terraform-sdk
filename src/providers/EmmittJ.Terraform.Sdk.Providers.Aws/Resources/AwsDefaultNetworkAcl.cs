using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for egress in AwsDefaultNetworkAcl.
/// Nesting mode: set
/// </summary>
public class AwsDefaultNetworkAclEgressBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "egress";

    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformValue<string> Action
    {
        get => new TerraformReference<string>(this, "action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    public TerraformValue<string>? CidrBlock
    {
        get => new TerraformReference<string>(this, "cidr_block");
        set => SetArgument("cidr_block", value);
    }

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FromPort is required")]
    public required TerraformValue<double> FromPort
    {
        get => new TerraformReference<double>(this, "from_port");
        set => SetArgument("from_port", value);
    }

    /// <summary>
    /// The icmp_code attribute.
    /// </summary>
    public TerraformValue<double>? IcmpCode
    {
        get => new TerraformReference<double>(this, "icmp_code");
        set => SetArgument("icmp_code", value);
    }

    /// <summary>
    /// The icmp_type attribute.
    /// </summary>
    public TerraformValue<double>? IcmpType
    {
        get => new TerraformReference<double>(this, "icmp_type");
        set => SetArgument("icmp_type", value);
    }

    /// <summary>
    /// The ipv6_cidr_block attribute.
    /// </summary>
    public TerraformValue<string>? Ipv6CidrBlock
    {
        get => new TerraformReference<string>(this, "ipv6_cidr_block");
        set => SetArgument("ipv6_cidr_block", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The rule_no attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleNo is required")]
    public required TerraformValue<double> RuleNo
    {
        get => new TerraformReference<double>(this, "rule_no");
        set => SetArgument("rule_no", value);
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ToPort is required")]
    public required TerraformValue<double> ToPort
    {
        get => new TerraformReference<double>(this, "to_port");
        set => SetArgument("to_port", value);
    }

}


/// <summary>
/// Block type for ingress in AwsDefaultNetworkAcl.
/// Nesting mode: set
/// </summary>
public class AwsDefaultNetworkAclIngressBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ingress";

    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformValue<string> Action
    {
        get => new TerraformReference<string>(this, "action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    public TerraformValue<string>? CidrBlock
    {
        get => new TerraformReference<string>(this, "cidr_block");
        set => SetArgument("cidr_block", value);
    }

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FromPort is required")]
    public required TerraformValue<double> FromPort
    {
        get => new TerraformReference<double>(this, "from_port");
        set => SetArgument("from_port", value);
    }

    /// <summary>
    /// The icmp_code attribute.
    /// </summary>
    public TerraformValue<double>? IcmpCode
    {
        get => new TerraformReference<double>(this, "icmp_code");
        set => SetArgument("icmp_code", value);
    }

    /// <summary>
    /// The icmp_type attribute.
    /// </summary>
    public TerraformValue<double>? IcmpType
    {
        get => new TerraformReference<double>(this, "icmp_type");
        set => SetArgument("icmp_type", value);
    }

    /// <summary>
    /// The ipv6_cidr_block attribute.
    /// </summary>
    public TerraformValue<string>? Ipv6CidrBlock
    {
        get => new TerraformReference<string>(this, "ipv6_cidr_block");
        set => SetArgument("ipv6_cidr_block", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The rule_no attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleNo is required")]
    public required TerraformValue<double> RuleNo
    {
        get => new TerraformReference<double>(this, "rule_no");
        set => SetArgument("rule_no", value);
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ToPort is required")]
    public required TerraformValue<double> ToPort
    {
        get => new TerraformReference<double>(this, "to_port");
        set => SetArgument("to_port", value);
    }

}


/// <summary>
/// Represents a aws_default_network_acl Terraform resource.
/// Manages a aws_default_network_acl resource.
/// </summary>
public partial class AwsDefaultNetworkAcl(string name) : TerraformResource("aws_default_network_acl", name)
{
    /// <summary>
    /// The default_network_acl_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultNetworkAclId is required")]
    public required TerraformValue<string> DefaultNetworkAclId
    {
        get => new TerraformReference<string>(this, "default_network_acl_id");
        set => SetArgument("default_network_acl_id", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformSet<string>? SubnetIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "subnet_ids").ResolveNodes(ctx));
        set => SetArgument("subnet_ids", value);
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
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
    {
        get => new TerraformReference<string>(this, "vpc_id");
    }

    /// <summary>
    /// Egress block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsDefaultNetworkAclEgressBlock>? Egress
    {
        get => GetArgument<TerraformSet<AwsDefaultNetworkAclEgressBlock>>("egress");
        set => SetArgument("egress", value);
    }

    /// <summary>
    /// Ingress block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsDefaultNetworkAclIngressBlock>? Ingress
    {
        get => GetArgument<TerraformSet<AwsDefaultNetworkAclIngressBlock>>("ingress");
        set => SetArgument("ingress", value);
    }

}
