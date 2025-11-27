using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_network_acl_rule Terraform resource.
/// Manages a aws_network_acl_rule resource.
/// </summary>
public partial class AwsNetworkAclRule(string name) : TerraformResource("aws_network_acl_rule", name)
{
    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    public TerraformValue<string>? CidrBlock
    {
        get => new TerraformReference<string>(this, "cidr_block");
        set => SetArgument("cidr_block", value);
    }

    /// <summary>
    /// The egress attribute.
    /// </summary>
    public TerraformValue<bool>? Egress
    {
        get => new TerraformReference<bool>(this, "egress");
        set => SetArgument("egress", value);
    }

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    public TerraformValue<double>? FromPort
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The network_acl_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkAclId is required")]
    public required TerraformValue<string> NetworkAclId
    {
        get => new TerraformReference<string>(this, "network_acl_id");
        set => SetArgument("network_acl_id", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The rule_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleAction is required")]
    public required TerraformValue<string> RuleAction
    {
        get => new TerraformReference<string>(this, "rule_action");
        set => SetArgument("rule_action", value);
    }

    /// <summary>
    /// The rule_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleNumber is required")]
    public required TerraformValue<double> RuleNumber
    {
        get => new TerraformReference<double>(this, "rule_number");
        set => SetArgument("rule_number", value);
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    public TerraformValue<double>? ToPort
    {
        get => new TerraformReference<double>(this, "to_port");
        set => SetArgument("to_port", value);
    }

}
