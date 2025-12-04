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
        get => GetArgument<TerraformValue<bool>>("appliance_mode_support") ?? AsReference("appliance_mode_support");
        set => SetArgument("appliance_mode_support", value);
    }

    /// <summary>
    /// The dns_support attribute.
    /// </summary>
    public TerraformValue<bool> DnsSupport
    {
        get => GetArgument<TerraformValue<bool>>("dns_support") ?? AsReference("dns_support");
        set => SetArgument("dns_support", value);
    }

    /// <summary>
    /// The ipv6_support attribute.
    /// </summary>
    public TerraformValue<bool> Ipv6Support
    {
        get => GetArgument<TerraformValue<bool>>("ipv6_support") ?? AsReference("ipv6_support");
        set => SetArgument("ipv6_support", value);
    }

    /// <summary>
    /// The security_group_referencing_support attribute.
    /// </summary>
    public TerraformValue<bool> SecurityGroupReferencingSupport
    {
        get => GetArgument<TerraformValue<bool>>("security_group_referencing_support") ?? AsReference("security_group_referencing_support");
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
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
        get => GetRequiredArgument<TerraformValue<string>>("core_network_id");
        set => SetArgument("core_network_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The subnet_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetArns is required")]
    public required TerraformSet<string> SubnetArns
    {
        get => GetRequiredArgument<TerraformSet<string>>("subnet_arns");
        set => SetArgument("subnet_arns", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The vpc_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcArn is required")]
    public required TerraformValue<string> VpcArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("vpc_arn");
        set => SetArgument("vpc_arn", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The attachment_policy_rule_number attribute.
    /// </summary>
    public TerraformValue<double> AttachmentPolicyRuleNumber
        => AsReference("attachment_policy_rule_number");

    /// <summary>
    /// The attachment_type attribute.
    /// </summary>
    public TerraformValue<string> AttachmentType
        => AsReference("attachment_type");

    /// <summary>
    /// The core_network_arn attribute.
    /// </summary>
    public TerraformValue<string> CoreNetworkArn
        => AsReference("core_network_arn");

    /// <summary>
    /// The edge_location attribute.
    /// </summary>
    public TerraformValue<string> EdgeLocation
        => AsReference("edge_location");

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerAccountId
        => AsReference("owner_account_id");

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    public TerraformValue<string> ResourceArn
        => AsReference("resource_arn");

    /// <summary>
    /// The segment_name attribute.
    /// </summary>
    public TerraformValue<string> SegmentName
        => AsReference("segment_name");

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

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
