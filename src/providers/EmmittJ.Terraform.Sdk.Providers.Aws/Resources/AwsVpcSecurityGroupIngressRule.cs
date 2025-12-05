using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_vpc_security_group_ingress_rule Terraform resource.
/// Manages a aws_vpc_security_group_ingress_rule resource.
/// </summary>
public partial class AwsVpcSecurityGroupIngressRule(string name) : TerraformResource("aws_vpc_security_group_ingress_rule", name)
{
    /// <summary>
    /// The cidr_ipv4 attribute.
    /// </summary>
    public TerraformValue<string>? CidrIpv4
    {
        get => GetArgument<TerraformValue<string>>("cidr_ipv4");
        set => SetArgument("cidr_ipv4", value);
    }

    /// <summary>
    /// The cidr_ipv6 attribute.
    /// </summary>
    public TerraformValue<string>? CidrIpv6
    {
        get => GetArgument<TerraformValue<string>>("cidr_ipv6");
        set => SetArgument("cidr_ipv6", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    public TerraformValue<double>? FromPort
    {
        get => GetArgument<TerraformValue<double>>("from_port");
        set => SetArgument("from_port", value);
    }

    /// <summary>
    /// The ip_protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpProtocol is required")]
    public required TerraformValue<string> IpProtocol
    {
        get => GetRequiredArgument<TerraformValue<string>>("ip_protocol");
        set => SetArgument("ip_protocol", value);
    }

    /// <summary>
    /// The prefix_list_id attribute.
    /// </summary>
    public TerraformValue<string>? PrefixListId
    {
        get => GetArgument<TerraformValue<string>>("prefix_list_id");
        set => SetArgument("prefix_list_id", value);
    }

    /// <summary>
    /// The referenced_security_group_id attribute.
    /// </summary>
    public TerraformValue<string>? ReferencedSecurityGroupId
    {
        get => GetArgument<TerraformValue<string>>("referenced_security_group_id");
        set => SetArgument("referenced_security_group_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The security_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupId is required")]
    public required TerraformValue<string> SecurityGroupId
    {
        get => GetRequiredArgument<TerraformValue<string>>("security_group_id");
        set => SetArgument("security_group_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    public TerraformValue<double>? ToPort
    {
        get => GetArgument<TerraformValue<double>>("to_port");
        set => SetArgument("to_port", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// The security_group_rule_id attribute.
    /// </summary>
    public TerraformValue<string> SecurityGroupRuleId
        => CreateReference("security_group_rule_id");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => CreateReference("tags_all");

}
