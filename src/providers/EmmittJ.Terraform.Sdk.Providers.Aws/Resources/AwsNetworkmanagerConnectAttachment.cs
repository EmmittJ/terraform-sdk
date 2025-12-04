using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for options in AwsNetworkmanagerConnectAttachment.
/// Nesting mode: list
/// </summary>
public class AwsNetworkmanagerConnectAttachmentOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "options";

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformValue<string>? Protocol
    {
        get => GetArgument<TerraformValue<string>>("protocol");
        set => SetArgument("protocol", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsNetworkmanagerConnectAttachment.
/// Nesting mode: single
/// </summary>
public class AwsNetworkmanagerConnectAttachmentTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a aws_networkmanager_connect_attachment Terraform resource.
/// Manages a aws_networkmanager_connect_attachment resource.
/// </summary>
public partial class AwsNetworkmanagerConnectAttachment(string name) : TerraformResource("aws_networkmanager_connect_attachment", name)
{
    /// <summary>
    /// The core_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CoreNetworkId is required")]
    public required TerraformValue<string> CoreNetworkId
    {
        get => GetArgument<TerraformValue<string>>("core_network_id");
        set => SetArgument("core_network_id", value);
    }

    /// <summary>
    /// The edge_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EdgeLocation is required")]
    public required TerraformValue<string> EdgeLocation
    {
        get => GetArgument<TerraformValue<string>>("edge_location");
        set => SetArgument("edge_location", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The transport_attachment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransportAttachmentId is required")]
    public required TerraformValue<string> TransportAttachmentId
    {
        get => GetArgument<TerraformValue<string>>("transport_attachment_id");
        set => SetArgument("transport_attachment_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The attachment_id attribute.
    /// </summary>
    public TerraformValue<string> AttachmentId
        => AsReference("attachment_id");

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
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Options is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Options block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Options block(s) allowed")]
    public required TerraformList<AwsNetworkmanagerConnectAttachmentOptionsBlock> Options
    {
        get => GetRequiredArgument<TerraformList<AwsNetworkmanagerConnectAttachmentOptionsBlock>>("options");
        set => SetArgument("options", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsNetworkmanagerConnectAttachmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsNetworkmanagerConnectAttachmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
