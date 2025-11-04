using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_security_group_ingress_rule resource.
/// </summary>
public class AwsVpcSecurityGroupIngressRule : TerraformResource
{
    public AwsVpcSecurityGroupIngressRule(string name) : base("aws_vpc_security_group_ingress_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("id");
        this.DeclareOutput("security_group_rule_id");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The cidr_ipv4 attribute.
    /// </summary>
    public string? CidrIpv4
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cidr_ipv4")?.Value;
        set => this.WithProperty("cidr_ipv4", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cidr_ipv6 attribute.
    /// </summary>
    public string? CidrIpv6
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cidr_ipv6")?.Value;
        set => this.WithProperty("cidr_ipv6", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The ip_protocol attribute.
    /// </summary>
    public string? IpProtocol
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ip_protocol")?.Value;
        set => this.WithProperty("ip_protocol", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The prefix_list_id attribute.
    /// </summary>
    public string? PrefixListId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("prefix_list_id")?.Value;
        set => this.WithProperty("prefix_list_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The referenced_security_group_id attribute.
    /// </summary>
    public string? ReferencedSecurityGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("referenced_security_group_id")?.Value;
        set => this.WithProperty("referenced_security_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The security_group_id attribute.
    /// </summary>
    public string? SecurityGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("security_group_id")?.Value;
        set => this.WithProperty("security_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    public double? ToPort
    {
        get => GetProperty<TerraformLiteralProperty<double>>("to_port")?.Value;
        set => this.WithProperty("to_port", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The security_group_rule_id attribute.
    /// </summary>
    public TerraformExpression SecurityGroupRuleId => this["security_group_rule_id"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
