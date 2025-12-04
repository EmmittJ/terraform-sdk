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
        get => GetArgument<TerraformValue<string>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    public TerraformValue<string>? CidrBlock
    {
        get => GetArgument<TerraformValue<string>>("cidr_block");
        set => SetArgument("cidr_block", value);
    }

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FromPort is required")]
    public required TerraformValue<double> FromPort
    {
        get => GetArgument<TerraformValue<double>>("from_port");
        set => SetArgument("from_port", value);
    }

    /// <summary>
    /// The icmp_code attribute.
    /// </summary>
    public TerraformValue<double>? IcmpCode
    {
        get => GetArgument<TerraformValue<double>>("icmp_code");
        set => SetArgument("icmp_code", value);
    }

    /// <summary>
    /// The icmp_type attribute.
    /// </summary>
    public TerraformValue<double>? IcmpType
    {
        get => GetArgument<TerraformValue<double>>("icmp_type");
        set => SetArgument("icmp_type", value);
    }

    /// <summary>
    /// The ipv6_cidr_block attribute.
    /// </summary>
    public TerraformValue<string>? Ipv6CidrBlock
    {
        get => GetArgument<TerraformValue<string>>("ipv6_cidr_block");
        set => SetArgument("ipv6_cidr_block", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => GetArgument<TerraformValue<string>>("protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The rule_no attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleNo is required")]
    public required TerraformValue<double> RuleNo
    {
        get => GetArgument<TerraformValue<double>>("rule_no");
        set => SetArgument("rule_no", value);
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ToPort is required")]
    public required TerraformValue<double> ToPort
    {
        get => GetArgument<TerraformValue<double>>("to_port");
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
        get => GetArgument<TerraformValue<string>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    public TerraformValue<string>? CidrBlock
    {
        get => GetArgument<TerraformValue<string>>("cidr_block");
        set => SetArgument("cidr_block", value);
    }

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FromPort is required")]
    public required TerraformValue<double> FromPort
    {
        get => GetArgument<TerraformValue<double>>("from_port");
        set => SetArgument("from_port", value);
    }

    /// <summary>
    /// The icmp_code attribute.
    /// </summary>
    public TerraformValue<double>? IcmpCode
    {
        get => GetArgument<TerraformValue<double>>("icmp_code");
        set => SetArgument("icmp_code", value);
    }

    /// <summary>
    /// The icmp_type attribute.
    /// </summary>
    public TerraformValue<double>? IcmpType
    {
        get => GetArgument<TerraformValue<double>>("icmp_type");
        set => SetArgument("icmp_type", value);
    }

    /// <summary>
    /// The ipv6_cidr_block attribute.
    /// </summary>
    public TerraformValue<string>? Ipv6CidrBlock
    {
        get => GetArgument<TerraformValue<string>>("ipv6_cidr_block");
        set => SetArgument("ipv6_cidr_block", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => GetArgument<TerraformValue<string>>("protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The rule_no attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleNo is required")]
    public required TerraformValue<double> RuleNo
    {
        get => GetArgument<TerraformValue<double>>("rule_no");
        set => SetArgument("rule_no", value);
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ToPort is required")]
    public required TerraformValue<double> ToPort
    {
        get => GetArgument<TerraformValue<double>>("to_port");
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
        get => GetArgument<TerraformValue<string>>("default_network_acl_id");
        set => SetArgument("default_network_acl_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformSet<string>? SubnetIds
    {
        get => GetArgument<TerraformSet<string>>("subnet_ids");
        set => SetArgument("subnet_ids", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
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
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
        => AsReference("vpc_id");

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
