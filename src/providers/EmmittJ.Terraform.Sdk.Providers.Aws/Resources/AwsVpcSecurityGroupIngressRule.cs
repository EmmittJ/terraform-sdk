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
        get => new TerraformReference<string>(this, "cidr_ipv4");
        set => SetArgument("cidr_ipv4", value);
    }

    /// <summary>
    /// The cidr_ipv6 attribute.
    /// </summary>
    public TerraformValue<string>? CidrIpv6
    {
        get => new TerraformReference<string>(this, "cidr_ipv6");
        set => SetArgument("cidr_ipv6", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    public TerraformValue<double>? FromPort
    {
        get => new TerraformReference<double>(this, "from_port");
        set => SetArgument("from_port", value);
    }

    /// <summary>
    /// The ip_protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpProtocol is required")]
    public required TerraformValue<string> IpProtocol
    {
        get => new TerraformReference<string>(this, "ip_protocol");
        set => SetArgument("ip_protocol", value);
    }

    /// <summary>
    /// The prefix_list_id attribute.
    /// </summary>
    public TerraformValue<string>? PrefixListId
    {
        get => new TerraformReference<string>(this, "prefix_list_id");
        set => SetArgument("prefix_list_id", value);
    }

    /// <summary>
    /// The referenced_security_group_id attribute.
    /// </summary>
    public TerraformValue<string>? ReferencedSecurityGroupId
    {
        get => new TerraformReference<string>(this, "referenced_security_group_id");
        set => SetArgument("referenced_security_group_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The security_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupId is required")]
    public required TerraformValue<string> SecurityGroupId
    {
        get => new TerraformReference<string>(this, "security_group_id");
        set => SetArgument("security_group_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    public TerraformValue<double>? ToPort
    {
        get => new TerraformReference<double>(this, "to_port");
        set => SetArgument("to_port", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The security_group_rule_id attribute.
    /// </summary>
    public TerraformValue<string> SecurityGroupRuleId
    {
        get => new TerraformReference<string>(this, "security_group_rule_id");
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

}
