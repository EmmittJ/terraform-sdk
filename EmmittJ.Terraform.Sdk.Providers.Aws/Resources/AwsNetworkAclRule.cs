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
    public string? CidrBlock
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cidr_block")?.Value;
        set => this.WithProperty("cidr_block", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The egress attribute.
    /// </summary>
    public bool? Egress
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("egress")?.Value;
        set => this.WithProperty("egress", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    public double? FromPort
    {
        get => GetProperty<TerraformLiteralProperty<double>>("from_port")?.Value;
        set => this.WithProperty("from_port", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The icmp_code attribute.
    /// </summary>
    public double? IcmpCode
    {
        get => GetProperty<TerraformLiteralProperty<double>>("icmp_code")?.Value;
        set => this.WithProperty("icmp_code", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The icmp_type attribute.
    /// </summary>
    public double? IcmpType
    {
        get => GetProperty<TerraformLiteralProperty<double>>("icmp_type")?.Value;
        set => this.WithProperty("icmp_type", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ipv6_cidr_block attribute.
    /// </summary>
    public string? Ipv6CidrBlock
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ipv6_cidr_block")?.Value;
        set => this.WithProperty("ipv6_cidr_block", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The network_acl_id attribute.
    /// </summary>
    public string? NetworkAclId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_acl_id")?.Value;
        set => this.WithProperty("network_acl_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public string? Protocol
    {
        get => GetProperty<TerraformLiteralProperty<string>>("protocol")?.Value;
        set => this.WithProperty("protocol", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The rule_action attribute.
    /// </summary>
    public string? RuleAction
    {
        get => GetProperty<TerraformLiteralProperty<string>>("rule_action")?.Value;
        set => this.WithProperty("rule_action", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The rule_number attribute.
    /// </summary>
    public double? RuleNumber
    {
        get => GetProperty<TerraformLiteralProperty<double>>("rule_number")?.Value;
        set => this.WithProperty("rule_number", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    public double? ToPort
    {
        get => GetProperty<TerraformLiteralProperty<double>>("to_port")?.Value;
        set => this.WithProperty("to_port", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

}
