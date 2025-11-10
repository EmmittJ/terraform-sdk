using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for private_endpoint in .
/// Nesting mode: set
/// </summary>
public class AzurermSignalrServiceNetworkAclPrivateEndpointBlock : ITerraformBlock
{
    /// <summary>
    /// The allowed_request_types attribute.
    /// </summary>
    [TerraformPropertyName("allowed_request_types")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? AllowedRequestTypes { get; set; }

    /// <summary>
    /// The denied_request_types attribute.
    /// </summary>
    [TerraformPropertyName("denied_request_types")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? DeniedRequestTypes { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformPropertyName("id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Id { get; set; }

}

/// <summary>
/// Block type for public_network in .
/// Nesting mode: list
/// </summary>
public class AzurermSignalrServiceNetworkAclPublicNetworkBlock : ITerraformBlock
{
    /// <summary>
    /// The allowed_request_types attribute.
    /// </summary>
    [TerraformPropertyName("allowed_request_types")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? AllowedRequestTypes { get; set; }

    /// <summary>
    /// The denied_request_types attribute.
    /// </summary>
    [TerraformPropertyName("denied_request_types")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? DeniedRequestTypes { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSignalrServiceNetworkAclTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    [TerraformPropertyName("default_action")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DefaultAction { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The signalr_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SignalrServiceId is required")]
    [TerraformPropertyName("signalr_service_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SignalrServiceId { get; set; }

    /// <summary>
    /// Block for private_endpoint.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("private_endpoint")]
    public TerraformSet<TerraformBlock<AzurermSignalrServiceNetworkAclPrivateEndpointBlock>>? PrivateEndpoint { get; set; } = new();

    /// <summary>
    /// Block for public_network.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicNetwork is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PublicNetwork block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PublicNetwork block(s) allowed")]
    [TerraformPropertyName("public_network")]
    public TerraformList<TerraformBlock<AzurermSignalrServiceNetworkAclPublicNetworkBlock>>? PublicNetwork { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSignalrServiceNetworkAclTimeoutsBlock>? Timeouts { get; set; } = new();

}
