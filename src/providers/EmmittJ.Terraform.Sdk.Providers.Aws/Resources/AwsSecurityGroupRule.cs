using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsSecurityGroupRule.
/// Nesting mode: single
/// </summary>
public class AwsSecurityGroupRuleTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

}


/// <summary>
/// Represents a aws_security_group_rule Terraform resource.
/// Manages a aws_security_group_rule resource.
/// </summary>
public partial class AwsSecurityGroupRule(string name) : TerraformResource("aws_security_group_rule", name)
{
    /// <summary>
    /// The cidr_blocks attribute.
    /// </summary>
    public TerraformList<string>? CidrBlocks
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "cidr_blocks").ResolveNodes(ctx));
        set => SetArgument("cidr_blocks", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FromPort is required")]
    public required TerraformValue<double> FromPort
    {
        get => new TerraformReference<double>(this, "from_port");
        set => SetArgument("from_port", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ipv6_cidr_blocks attribute.
    /// </summary>
    public TerraformList<string>? Ipv6CidrBlocks
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "ipv6_cidr_blocks").ResolveNodes(ctx));
        set => SetArgument("ipv6_cidr_blocks", value);
    }

    /// <summary>
    /// The prefix_list_ids attribute.
    /// </summary>
    public TerraformList<string>? PrefixListIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "prefix_list_ids").ResolveNodes(ctx));
        set => SetArgument("prefix_list_ids", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
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
    /// The self attribute.
    /// </summary>
    public TerraformValue<bool>? Self
    {
        get => new TerraformReference<bool>(this, "self");
        set => SetArgument("self", value);
    }

    /// <summary>
    /// The source_security_group_id attribute.
    /// </summary>
    public TerraformValue<string> SourceSecurityGroupId
    {
        get => new TerraformReference<string>(this, "source_security_group_id");
        set => SetArgument("source_security_group_id", value);
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ToPort is required")]
    public required TerraformValue<double> ToPort
    {
        get => new TerraformReference<double>(this, "to_port");
        set => SetArgument("to_port", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The security_group_rule_id attribute.
    /// </summary>
    public TerraformValue<string> SecurityGroupRuleId
    {
        get => new TerraformReference<string>(this, "security_group_rule_id");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsSecurityGroupRuleTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsSecurityGroupRuleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
