using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsNetworkmanagerAttachmentAccepter.
/// Nesting mode: single
/// </summary>
public class AwsNetworkmanagerAttachmentAccepterTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a aws_networkmanager_attachment_accepter Terraform resource.
/// Manages a aws_networkmanager_attachment_accepter resource.
/// </summary>
public partial class AwsNetworkmanagerAttachmentAccepter(string name) : TerraformResource("aws_networkmanager_attachment_accepter", name)
{
    /// <summary>
    /// The attachment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttachmentId is required")]
    public required TerraformValue<string> AttachmentId
    {
        get => GetRequiredArgument<TerraformValue<string>>("attachment_id");
        set => SetArgument("attachment_id", value);
    }

    /// <summary>
    /// The attachment_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttachmentType is required")]
    public required TerraformValue<string> AttachmentType
    {
        get => GetRequiredArgument<TerraformValue<string>>("attachment_type");
        set => SetArgument("attachment_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The attachment_policy_rule_number attribute.
    /// </summary>
    public TerraformValue<double> AttachmentPolicyRuleNumber
        => CreateReference("attachment_policy_rule_number");

    /// <summary>
    /// The core_network_arn attribute.
    /// </summary>
    public TerraformValue<string> CoreNetworkArn
        => CreateReference("core_network_arn");

    /// <summary>
    /// The core_network_id attribute.
    /// </summary>
    public TerraformValue<string> CoreNetworkId
        => CreateReference("core_network_id");

    /// <summary>
    /// The edge_location attribute.
    /// </summary>
    public TerraformValue<string> EdgeLocation
        => CreateReference("edge_location");

    /// <summary>
    /// The edge_locations attribute.
    /// </summary>
    public TerraformList<string> EdgeLocations
        => CreateReference("edge_locations");

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerAccountId
        => CreateReference("owner_account_id");

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    public TerraformValue<string> ResourceArn
        => CreateReference("resource_arn");

    /// <summary>
    /// The segment_name attribute.
    /// </summary>
    public TerraformValue<string> SegmentName
        => CreateReference("segment_name");

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
        => CreateReference("state");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsNetworkmanagerAttachmentAccepterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsNetworkmanagerAttachmentAccepterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
