using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_vpc_security_group_rule.
/// </summary>
public class AwsVpcSecurityGroupRuleDataSource : TerraformDataSource
{
    public AwsVpcSecurityGroupRuleDataSource(string name) : base("aws_vpc_security_group_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("cidr_ipv4");
        this.DeclareOutput("cidr_ipv6");
        this.DeclareOutput("description");
        this.DeclareOutput("from_port");
        this.DeclareOutput("id");
        this.DeclareOutput("ip_protocol");
        this.DeclareOutput("is_egress");
        this.DeclareOutput("prefix_list_id");
        this.DeclareOutput("referenced_security_group_id");
        this.DeclareOutput("security_group_id");
        this.DeclareOutput("tags");
        this.DeclareOutput("to_port");
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The security_group_rule_id attribute.
    /// </summary>
    public string? SecurityGroupRuleId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("security_group_rule_id")?.Value;
        set => this.WithProperty("security_group_rule_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The cidr_ipv4 attribute.
    /// </summary>
    public TerraformExpression CidrIpv4 => this["cidr_ipv4"];

    /// <summary>
    /// The cidr_ipv6 attribute.
    /// </summary>
    public TerraformExpression CidrIpv6 => this["cidr_ipv6"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    public TerraformExpression FromPort => this["from_port"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The ip_protocol attribute.
    /// </summary>
    public TerraformExpression IpProtocol => this["ip_protocol"];

    /// <summary>
    /// The is_egress attribute.
    /// </summary>
    public TerraformExpression IsEgress => this["is_egress"];

    /// <summary>
    /// The prefix_list_id attribute.
    /// </summary>
    public TerraformExpression PrefixListId => this["prefix_list_id"];

    /// <summary>
    /// The referenced_security_group_id attribute.
    /// </summary>
    public TerraformExpression ReferencedSecurityGroupId => this["referenced_security_group_id"];

    /// <summary>
    /// The security_group_id attribute.
    /// </summary>
    public TerraformExpression SecurityGroupId => this["security_group_id"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    public TerraformExpression ToPort => this["to_port"];

}
