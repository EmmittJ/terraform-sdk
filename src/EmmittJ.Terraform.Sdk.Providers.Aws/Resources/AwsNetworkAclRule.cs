using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_network_acl_rule resource.
/// </summary>
public class AwsNetworkAclRule : TerraformResource
{
    public AwsNetworkAclRule(string name) : base("aws_network_acl_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    public TerraformProperty<string>? CidrBlock
    {
        get => GetProperty<TerraformProperty<string>>("cidr_block");
        set => this.WithProperty("cidr_block", value);
    }

    /// <summary>
    /// The egress attribute.
    /// </summary>
    public TerraformProperty<bool>? Egress
    {
        get => GetProperty<TerraformProperty<bool>>("egress");
        set => this.WithProperty("egress", value);
    }

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    public TerraformProperty<double>? FromPort
    {
        get => GetProperty<TerraformProperty<double>>("from_port");
        set => this.WithProperty("from_port", value);
    }

    /// <summary>
    /// The icmp_code attribute.
    /// </summary>
    public TerraformProperty<double>? IcmpCode
    {
        get => GetProperty<TerraformProperty<double>>("icmp_code");
        set => this.WithProperty("icmp_code", value);
    }

    /// <summary>
    /// The icmp_type attribute.
    /// </summary>
    public TerraformProperty<double>? IcmpType
    {
        get => GetProperty<TerraformProperty<double>>("icmp_type");
        set => this.WithProperty("icmp_type", value);
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
    /// The ipv6_cidr_block attribute.
    /// </summary>
    public TerraformProperty<string>? Ipv6CidrBlock
    {
        get => GetProperty<TerraformProperty<string>>("ipv6_cidr_block");
        set => this.WithProperty("ipv6_cidr_block", value);
    }

    /// <summary>
    /// The network_acl_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkAclId is required")]
    public required TerraformProperty<string> NetworkAclId
    {
        get => GetProperty<TerraformProperty<string>>("network_acl_id");
        set => this.WithProperty("network_acl_id", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
    {
        get => GetProperty<TerraformProperty<string>>("protocol");
        set => this.WithProperty("protocol", value);
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
    /// The rule_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleAction is required")]
    public required TerraformProperty<string> RuleAction
    {
        get => GetProperty<TerraformProperty<string>>("rule_action");
        set => this.WithProperty("rule_action", value);
    }

    /// <summary>
    /// The rule_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleNumber is required")]
    public required TerraformProperty<double> RuleNumber
    {
        get => GetProperty<TerraformProperty<double>>("rule_number");
        set => this.WithProperty("rule_number", value);
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    public TerraformProperty<double>? ToPort
    {
        get => GetProperty<TerraformProperty<double>>("to_port");
        set => this.WithProperty("to_port", value);
    }

}
