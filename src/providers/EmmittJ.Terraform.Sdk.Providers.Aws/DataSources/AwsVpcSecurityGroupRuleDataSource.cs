using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsVpcSecurityGroupRuleDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    public HashSet<TerraformProperty<string>>? Values
    {
        set => SetProperty("values", value);
    }

}

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
        SetOutput("arn");
        SetOutput("cidr_ipv4");
        SetOutput("cidr_ipv6");
        SetOutput("description");
        SetOutput("from_port");
        SetOutput("id");
        SetOutput("ip_protocol");
        SetOutput("is_egress");
        SetOutput("prefix_list_id");
        SetOutput("referenced_security_group_id");
        SetOutput("security_group_id");
        SetOutput("tags");
        SetOutput("to_port");
        SetOutput("region");
        SetOutput("security_group_rule_id");
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The security_group_rule_id attribute.
    /// </summary>
    public TerraformProperty<string> SecurityGroupRuleId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("security_group_rule_id");
        set => SetProperty("security_group_rule_id", value);
    }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsVpcSecurityGroupRuleDataSourceFilterBlock>? Filter
    {
        set => SetProperty("filter", value);
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
