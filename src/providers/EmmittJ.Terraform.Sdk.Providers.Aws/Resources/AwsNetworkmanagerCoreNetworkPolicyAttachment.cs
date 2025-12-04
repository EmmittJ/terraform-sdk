using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsNetworkmanagerCoreNetworkPolicyAttachment.
/// Nesting mode: single
/// </summary>
public class AwsNetworkmanagerCoreNetworkPolicyAttachmentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

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
/// Represents a aws_networkmanager_core_network_policy_attachment Terraform resource.
/// Manages a aws_networkmanager_core_network_policy_attachment resource.
/// </summary>
public partial class AwsNetworkmanagerCoreNetworkPolicyAttachment(string name) : TerraformResource("aws_networkmanager_core_network_policy_attachment", name)
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The policy_document attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyDocument is required")]
    public required TerraformValue<string> PolicyDocument
    {
        get => GetArgument<TerraformValue<string>>("policy_document");
        set => SetArgument("policy_document", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsNetworkmanagerCoreNetworkPolicyAttachmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsNetworkmanagerCoreNetworkPolicyAttachmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
