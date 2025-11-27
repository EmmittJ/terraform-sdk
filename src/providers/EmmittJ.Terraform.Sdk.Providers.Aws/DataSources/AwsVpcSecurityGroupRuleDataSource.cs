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
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "values").ResolveNodes(ctx));
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
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The security_group_rule_id attribute.
    /// </summary>
    public TerraformValue<string> SecurityGroupRuleId
    {
        get => new TerraformReference<string>(this, "security_group_rule_id");
        set => SetArgument("security_group_rule_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The cidr_ipv4 attribute.
    /// </summary>
    public TerraformValue<string> CidrIpv4
    {
        get => new TerraformReference<string>(this, "cidr_ipv4");
    }

    /// <summary>
    /// The cidr_ipv6 attribute.
    /// </summary>
    public TerraformValue<string> CidrIpv6
    {
        get => new TerraformReference<string>(this, "cidr_ipv6");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    public TerraformValue<double> FromPort
    {
        get => new TerraformReference<double>(this, "from_port");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The ip_protocol attribute.
    /// </summary>
    public TerraformValue<string> IpProtocol
    {
        get => new TerraformReference<string>(this, "ip_protocol");
    }

    /// <summary>
    /// The is_egress attribute.
    /// </summary>
    public TerraformValue<bool> IsEgress
    {
        get => new TerraformReference<bool>(this, "is_egress");
    }

    /// <summary>
    /// The prefix_list_id attribute.
    /// </summary>
    public TerraformValue<string> PrefixListId
    {
        get => new TerraformReference<string>(this, "prefix_list_id");
    }

    /// <summary>
    /// The referenced_security_group_id attribute.
    /// </summary>
    public TerraformValue<string> ReferencedSecurityGroupId
    {
        get => new TerraformReference<string>(this, "referenced_security_group_id");
    }

    /// <summary>
    /// The security_group_id attribute.
    /// </summary>
    public TerraformValue<string> SecurityGroupId
    {
        get => new TerraformReference<string>(this, "security_group_id");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    public TerraformValue<double> ToPort
    {
        get => new TerraformReference<double>(this, "to_port");
    }

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsVpcSecurityGroupRuleDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsVpcSecurityGroupRuleDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

}
