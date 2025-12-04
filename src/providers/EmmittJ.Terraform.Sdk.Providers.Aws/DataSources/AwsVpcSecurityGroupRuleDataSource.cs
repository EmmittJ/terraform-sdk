using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsVpcSecurityGroupRuleDataSource.
/// Nesting mode: set
/// </summary>
public class AwsVpcSecurityGroupRuleDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => GetRequiredArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Represents a aws_vpc_security_group_rule Terraform data source.
/// Retrieves information about a aws_vpc_security_group_rule.
/// </summary>
public partial class AwsVpcSecurityGroupRuleDataSource(string name) : TerraformDataSource("aws_vpc_security_group_rule", name)
{
    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The security_group_rule_id attribute.
    /// </summary>
    public TerraformValue<string> SecurityGroupRuleId
    {
        get => GetArgument<TerraformValue<string>>("security_group_rule_id") ?? AsReference("security_group_rule_id");
        set => SetArgument("security_group_rule_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The cidr_ipv4 attribute.
    /// </summary>
    public TerraformValue<string> CidrIpv4
        => AsReference("cidr_ipv4");

    /// <summary>
    /// The cidr_ipv6 attribute.
    /// </summary>
    public TerraformValue<string> CidrIpv6
        => AsReference("cidr_ipv6");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    public TerraformValue<double> FromPort
        => AsReference("from_port");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The ip_protocol attribute.
    /// </summary>
    public TerraformValue<string> IpProtocol
        => AsReference("ip_protocol");

    /// <summary>
    /// The is_egress attribute.
    /// </summary>
    public TerraformValue<bool> IsEgress
        => AsReference("is_egress");

    /// <summary>
    /// The prefix_list_id attribute.
    /// </summary>
    public TerraformValue<string> PrefixListId
        => AsReference("prefix_list_id");

    /// <summary>
    /// The referenced_security_group_id attribute.
    /// </summary>
    public TerraformValue<string> ReferencedSecurityGroupId
        => AsReference("referenced_security_group_id");

    /// <summary>
    /// The security_group_id attribute.
    /// </summary>
    public TerraformValue<string> SecurityGroupId
        => AsReference("security_group_id");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    public TerraformValue<double> ToPort
        => AsReference("to_port");

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsVpcSecurityGroupRuleDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsVpcSecurityGroupRuleDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

}
