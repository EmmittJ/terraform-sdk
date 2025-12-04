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
        get => GetArgument<TerraformValue<string>>("cidr_block");
        set => SetArgument("cidr_block", value);
    }

    /// <summary>
    /// The egress attribute.
    /// </summary>
    public TerraformValue<bool>? Egress
    {
        get => GetArgument<TerraformValue<bool>>("egress");
        set => SetArgument("egress", value);
    }

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    public TerraformValue<double>? FromPort
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
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
    /// The network_acl_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkAclId is required")]
    public required TerraformValue<string> NetworkAclId
    {
        get => GetRequiredArgument<TerraformValue<string>>("network_acl_id");
        set => SetArgument("network_acl_id", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => GetRequiredArgument<TerraformValue<string>>("protocol");
        set => SetArgument("protocol", value);
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
    /// The rule_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleAction is required")]
    public required TerraformValue<string> RuleAction
    {
        get => GetRequiredArgument<TerraformValue<string>>("rule_action");
        set => SetArgument("rule_action", value);
    }

    /// <summary>
    /// The rule_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleNumber is required")]
    public required TerraformValue<double> RuleNumber
    {
        get => GetRequiredArgument<TerraformValue<double>>("rule_number");
        set => SetArgument("rule_number", value);
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    public TerraformValue<double>? ToPort
    {
        get => GetArgument<TerraformValue<double>>("to_port");
        set => SetArgument("to_port", value);
    }

}
