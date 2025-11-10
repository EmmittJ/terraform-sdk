using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_security_group_egress_rule resource.
/// </summary>
public class AwsVpcSecurityGroupEgressRule : TerraformResource
{
    public AwsVpcSecurityGroupEgressRule(string name) : base("aws_vpc_security_group_egress_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("id");
        SetOutput("security_group_rule_id");
        SetOutput("tags_all");
        SetOutput("cidr_ipv4");
        SetOutput("cidr_ipv6");
        SetOutput("description");
        SetOutput("from_port");
        SetOutput("ip_protocol");
        SetOutput("prefix_list_id");
        SetOutput("referenced_security_group_id");
        SetOutput("region");
        SetOutput("security_group_id");
        SetOutput("tags");
        SetOutput("to_port");
    }

    /// <summary>
    /// The cidr_ipv4 attribute.
    /// </summary>
    public TerraformProperty<string> CidrIpv4
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cidr_ipv4");
        set => SetProperty("cidr_ipv4", value);
    }

    /// <summary>
    /// The cidr_ipv6 attribute.
    /// </summary>
    public TerraformProperty<string> CidrIpv6
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cidr_ipv6");
        set => SetProperty("cidr_ipv6", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    public TerraformProperty<double> FromPort
    {
        get => GetRequiredOutput<TerraformProperty<double>>("from_port");
        set => SetProperty("from_port", value);
    }

    /// <summary>
    /// The ip_protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpProtocol is required")]
    public required TerraformProperty<string> IpProtocol
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ip_protocol");
        set => SetProperty("ip_protocol", value);
    }

    /// <summary>
    /// The prefix_list_id attribute.
    /// </summary>
    public TerraformProperty<string> PrefixListId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("prefix_list_id");
        set => SetProperty("prefix_list_id", value);
    }

    /// <summary>
    /// The referenced_security_group_id attribute.
    /// </summary>
    public TerraformProperty<string> ReferencedSecurityGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("referenced_security_group_id");
        set => SetProperty("referenced_security_group_id", value);
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
    /// The security_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupId is required")]
    public required TerraformProperty<string> SecurityGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("security_group_id");
        set => SetProperty("security_group_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    public TerraformProperty<double> ToPort
    {
        get => GetRequiredOutput<TerraformProperty<double>>("to_port");
        set => SetProperty("to_port", value);
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
