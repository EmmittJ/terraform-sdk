using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for private_endpoint in AzurermSignalrServiceNetworkAcl.
/// Nesting mode: set
/// </summary>
public class AzurermSignalrServiceNetworkAclPrivateEndpointBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "private_endpoint";

    /// <summary>
    /// The allowed_request_types attribute.
    /// </summary>
    public TerraformSet<string>? AllowedRequestTypes
    {
        get => GetArgument<TerraformSet<string>>("allowed_request_types");
        set => SetArgument("allowed_request_types", value);
    }

    /// <summary>
    /// The denied_request_types attribute.
    /// </summary>
    public TerraformSet<string>? DeniedRequestTypes
    {
        get => GetArgument<TerraformSet<string>>("denied_request_types");
        set => SetArgument("denied_request_types", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetRequiredArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

}


/// <summary>
/// Block type for public_network in AzurermSignalrServiceNetworkAcl.
/// Nesting mode: list
/// </summary>
public class AzurermSignalrServiceNetworkAclPublicNetworkBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "public_network";

    /// <summary>
    /// The allowed_request_types attribute.
    /// </summary>
    public TerraformSet<string>? AllowedRequestTypes
    {
        get => GetArgument<TerraformSet<string>>("allowed_request_types");
        set => SetArgument("allowed_request_types", value);
    }

    /// <summary>
    /// The denied_request_types attribute.
    /// </summary>
    public TerraformSet<string>? DeniedRequestTypes
    {
        get => GetArgument<TerraformSet<string>>("denied_request_types");
        set => SetArgument("denied_request_types", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermSignalrServiceNetworkAcl.
/// Nesting mode: single
/// </summary>
public class AzurermSignalrServiceNetworkAclTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
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
/// Represents a azurerm_signalr_service_network_acl Terraform resource.
/// Manages a azurerm_signalr_service_network_acl resource.
/// </summary>
public partial class AzurermSignalrServiceNetworkAcl(string name) : TerraformResource("azurerm_signalr_service_network_acl", name)
{
    /// <summary>
    /// The default_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAction is required")]
    public required TerraformValue<string> DefaultAction
    {
        get => GetRequiredArgument<TerraformValue<string>>("default_action");
        set => SetArgument("default_action", value);
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
    /// The signalr_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SignalrServiceId is required")]
    public required TerraformValue<string> SignalrServiceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("signalr_service_id");
        set => SetArgument("signalr_service_id", value);
    }

    /// <summary>
    /// PrivateEndpoint block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermSignalrServiceNetworkAclPrivateEndpointBlock>? PrivateEndpoint
    {
        get => GetArgument<TerraformSet<AzurermSignalrServiceNetworkAclPrivateEndpointBlock>>("private_endpoint");
        set => SetArgument("private_endpoint", value);
    }

    /// <summary>
    /// PublicNetwork block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicNetwork is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PublicNetwork block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PublicNetwork block(s) allowed")]
    public required TerraformList<AzurermSignalrServiceNetworkAclPublicNetworkBlock> PublicNetwork
    {
        get => GetRequiredArgument<TerraformList<AzurermSignalrServiceNetworkAclPublicNetworkBlock>>("public_network");
        set => SetArgument("public_network", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSignalrServiceNetworkAclTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSignalrServiceNetworkAclTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
