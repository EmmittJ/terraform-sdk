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
        this.WithOutput("arn");
        this.WithOutput("id");
        this.WithOutput("security_group_rule_id");
        this.WithOutput("tags_all");
    }

    /// <summary>
    /// The cidr_ipv4 attribute.
    /// </summary>
    public TerraformProperty<string>? CidrIpv4
    {
        get => GetProperty<TerraformProperty<string>>("cidr_ipv4");
        set => this.WithProperty("cidr_ipv4", value);
    }

    /// <summary>
    /// The cidr_ipv6 attribute.
    /// </summary>
    public TerraformProperty<string>? CidrIpv6
    {
        get => GetProperty<TerraformProperty<string>>("cidr_ipv6");
        set => this.WithProperty("cidr_ipv6", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The ip_protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpProtocol is required")]
    public required TerraformProperty<string> IpProtocol
    {
        get => GetRequiredProperty<TerraformProperty<string>>("ip_protocol");
        set => this.WithProperty("ip_protocol", value);
    }

    /// <summary>
    /// The prefix_list_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrefixListId
    {
        get => GetProperty<TerraformProperty<string>>("prefix_list_id");
        set => this.WithProperty("prefix_list_id", value);
    }

    /// <summary>
    /// The referenced_security_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? ReferencedSecurityGroupId
    {
        get => GetProperty<TerraformProperty<string>>("referenced_security_group_id");
        set => this.WithProperty("referenced_security_group_id", value);
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
    /// The security_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupId is required")]
    public required TerraformProperty<string> SecurityGroupId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("security_group_id");
        set => this.WithProperty("security_group_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    public TerraformProperty<double>? ToPort
    {
        get => GetProperty<TerraformProperty<double>>("to_port");
        set => this.WithProperty("to_port", value);
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
