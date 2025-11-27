using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for options in AwsNetworkmanagerVpcAttachment.
/// Nesting mode: list
/// </summary>
public class AwsNetworkmanagerVpcAttachmentOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "options";

    /// <summary>
    /// The appliance_mode_support attribute.
    /// </summary>
    public TerraformValue<bool> ApplianceModeSupport
    {
        get => new TerraformReference<bool>(this, "appliance_mode_support");
        set => SetArgument("appliance_mode_support", value);
    }

    /// <summary>
    /// The dns_support attribute.
    /// </summary>
    public TerraformValue<bool> DnsSupport
    {
        get => new TerraformReference<bool>(this, "dns_support");
        set => SetArgument("dns_support", value);
    }

    /// <summary>
    /// The ipv6_support attribute.
    /// </summary>
    public TerraformValue<bool> Ipv6Support
    {
        get => new TerraformReference<bool>(this, "ipv6_support");
        set => SetArgument("ipv6_support", value);
    }

    /// <summary>
    /// The security_group_referencing_support attribute.
    /// </summary>
    public TerraformValue<bool> SecurityGroupReferencingSupport
    {
        get => new TerraformReference<bool>(this, "security_group_referencing_support");
        set => SetArgument("security_group_referencing_support", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsNetworkmanagerVpcAttachment.
/// Nesting mode: single
/// </summary>
public class AwsNetworkmanagerVpcAttachmentTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_networkmanager_vpc_attachment Terraform resource.
/// Manages a aws_networkmanager_vpc_attachment resource.
/// </summary>
public partial class AwsNetworkmanagerVpcAttachment(string name) : TerraformResource("aws_networkmanager_vpc_attachment", name)
{
    /// <summary>
    /// The core_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CoreNetworkId is required")]
    public required TerraformValue<string> CoreNetworkId
    {
        get => new TerraformReference<string>(this, "core_network_id");
        set => SetArgument("core_network_id", value);
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
    /// The subnet_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetArns is required")]
    public required TerraformSet<string> SubnetArns
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "subnet_arns").ResolveNodes(ctx));
        set => SetArgument("subnet_arns", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The vpc_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcArn is required")]
    public required TerraformValue<string> VpcArn
    {
        get => new TerraformReference<string>(this, "vpc_arn");
        set => SetArgument("vpc_arn", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The attachment_policy_rule_number attribute.
    /// </summary>
    public TerraformValue<double> AttachmentPolicyRuleNumber
    {
        get => new TerraformReference<double>(this, "attachment_policy_rule_number");
    }

    /// <summary>
    /// The attachment_type attribute.
    /// </summary>
    public TerraformValue<string> AttachmentType
    {
        get => new TerraformReference<string>(this, "attachment_type");
    }

    /// <summary>
    /// The core_network_arn attribute.
    /// </summary>
    public TerraformValue<string> CoreNetworkArn
    {
        get => new TerraformReference<string>(this, "core_network_arn");
    }

    /// <summary>
    /// The edge_location attribute.
    /// </summary>
    public TerraformValue<string> EdgeLocation
    {
        get => new TerraformReference<string>(this, "edge_location");
    }

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerAccountId
    {
        get => new TerraformReference<string>(this, "owner_account_id");
    }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    public TerraformValue<string> ResourceArn
    {
        get => new TerraformReference<string>(this, "resource_arn");
    }

    /// <summary>
    /// The segment_name attribute.
    /// </summary>
    public TerraformValue<string> SegmentName
    {
        get => new TerraformReference<string>(this, "segment_name");
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// Options block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Options block(s) allowed")]
    public TerraformList<AwsNetworkmanagerVpcAttachmentOptionsBlock>? Options
    {
        get => GetArgument<TerraformList<AwsNetworkmanagerVpcAttachmentOptionsBlock>>("options");
        set => SetArgument("options", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsNetworkmanagerVpcAttachmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsNetworkmanagerVpcAttachmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
