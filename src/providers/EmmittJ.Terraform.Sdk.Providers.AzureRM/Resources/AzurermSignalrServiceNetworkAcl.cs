using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for private_endpoint in .
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
    [TerraformArgument("allowed_request_types")]
    public TerraformSet<string>? AllowedRequestTypes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allowed_request_types").ResolveNodes(ctx));
        set => SetArgument("allowed_request_types", value);
    }

    /// <summary>
    /// The denied_request_types attribute.
    /// </summary>
    [TerraformArgument("denied_request_types")]
    public TerraformSet<string>? DeniedRequestTypes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "denied_request_types").ResolveNodes(ctx));
        set => SetArgument("denied_request_types", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformArgument("id")]
    public required TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

}

/// <summary>
/// Block type for public_network in .
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
    [TerraformArgument("allowed_request_types")]
    public TerraformSet<string>? AllowedRequestTypes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allowed_request_types").ResolveNodes(ctx));
        set => SetArgument("allowed_request_types", value);
    }

    /// <summary>
    /// The denied_request_types attribute.
    /// </summary>
    [TerraformArgument("denied_request_types")]
    public TerraformSet<string>? DeniedRequestTypes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "denied_request_types").ResolveNodes(ctx));
        set => SetArgument("denied_request_types", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_signalr_service_network_acl resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermSignalrServiceNetworkAcl : TerraformResource
{
    public AzurermSignalrServiceNetworkAcl(string name) : base("azurerm_signalr_service_network_acl", name)
    {
    }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAction is required")]
    [TerraformArgument("default_action")]
    public required TerraformValue<string> DefaultAction
    {
        get => new TerraformReference<string>(this, "default_action");
        set => SetArgument("default_action", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The signalr_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SignalrServiceId is required")]
    [TerraformArgument("signalr_service_id")]
    public required TerraformValue<string> SignalrServiceId
    {
        get => new TerraformReference<string>(this, "signalr_service_id");
        set => SetArgument("signalr_service_id", value);
    }

    /// <summary>
    /// Block for private_endpoint.
    /// Nesting mode: set
    /// </summary>
    [TerraformArgument("private_endpoint")]
    public TerraformSet<AzurermSignalrServiceNetworkAclPrivateEndpointBlock> PrivateEndpoint { get; set; } = new();

    /// <summary>
    /// Block for public_network.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicNetwork is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PublicNetwork block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PublicNetwork block(s) allowed")]
    [TerraformArgument("public_network")]
    public required TerraformList<AzurermSignalrServiceNetworkAclPublicNetworkBlock> PublicNetwork { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermSignalrServiceNetworkAclTimeoutsBlock Timeouts { get; set; } = new();

}
