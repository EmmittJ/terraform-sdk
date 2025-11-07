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
    public TerraformLiteralProperty<string>? CidrBlock
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cidr_block");
        set => this.WithProperty("cidr_block", value);
    }

    /// <summary>
    /// The egress attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Egress
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("egress");
        set => this.WithProperty("egress", value);
    }

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? FromPort
    {
        get => GetProperty<TerraformLiteralProperty<double>>("from_port");
        set => this.WithProperty("from_port", value);
    }

    /// <summary>
    /// The icmp_code attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? IcmpCode
    {
        get => GetProperty<TerraformLiteralProperty<double>>("icmp_code");
        set => this.WithProperty("icmp_code", value);
    }

    /// <summary>
    /// The icmp_type attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? IcmpType
    {
        get => GetProperty<TerraformLiteralProperty<double>>("icmp_type");
        set => this.WithProperty("icmp_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The ipv6_cidr_block attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Ipv6CidrBlock
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ipv6_cidr_block");
        set => this.WithProperty("ipv6_cidr_block", value);
    }

    /// <summary>
    /// The network_acl_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NetworkAclId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_acl_id");
        set => this.WithProperty("network_acl_id", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Protocol
    {
        get => GetProperty<TerraformLiteralProperty<string>>("protocol");
        set => this.WithProperty("protocol", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The rule_action attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RuleAction
    {
        get => GetProperty<TerraformLiteralProperty<string>>("rule_action");
        set => this.WithProperty("rule_action", value);
    }

    /// <summary>
    /// The rule_number attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? RuleNumber
    {
        get => GetProperty<TerraformLiteralProperty<double>>("rule_number");
        set => this.WithProperty("rule_number", value);
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? ToPort
    {
        get => GetProperty<TerraformLiteralProperty<double>>("to_port");
        set => this.WithProperty("to_port", value);
    }

}
