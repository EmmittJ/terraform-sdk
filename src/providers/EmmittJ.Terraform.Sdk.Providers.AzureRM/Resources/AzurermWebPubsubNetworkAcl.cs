using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for private_endpoint in .
/// Nesting mode: set
/// </summary>
public partial class AzurermWebPubsubNetworkAclPrivateEndpointBlock : TerraformBlockBase
{
    /// <summary>
    /// The allowed_request_types attribute.
    /// </summary>
    [TerraformProperty("allowed_request_types")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? AllowedRequestTypes { get; set; }

    /// <summary>
    /// The denied_request_types attribute.
    /// </summary>
    [TerraformProperty("denied_request_types")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? DeniedRequestTypes { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Id { get; set; }

}

/// <summary>
/// Block type for public_network in .
/// Nesting mode: list
/// </summary>
public partial class AzurermWebPubsubNetworkAclPublicNetworkBlock : TerraformBlockBase
{
    /// <summary>
    /// The allowed_request_types attribute.
    /// </summary>
    [TerraformProperty("allowed_request_types")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? AllowedRequestTypes { get; set; }

    /// <summary>
    /// The denied_request_types attribute.
    /// </summary>
    [TerraformProperty("denied_request_types")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? DeniedRequestTypes { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermWebPubsubNetworkAclTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_web_pubsub_network_acl resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermWebPubsubNetworkAcl : TerraformResource
{
    public AzurermWebPubsubNetworkAcl(string name) : base("azurerm_web_pubsub_network_acl", name)
    {
    }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    [TerraformProperty("default_action")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DefaultAction { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The web_pubsub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebPubsubId is required")]
    [TerraformProperty("web_pubsub_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> WebPubsubId { get; set; }

    /// <summary>
    /// Block for private_endpoint.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("private_endpoint")]
    public TerraformSet<TerraformBlock<AzurermWebPubsubNetworkAclPrivateEndpointBlock>>? PrivateEndpoint { get; set; }

    /// <summary>
    /// Block for public_network.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicNetwork is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PublicNetwork block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PublicNetwork block(s) allowed")]
    [TerraformProperty("public_network")]
    public TerraformList<TerraformBlock<AzurermWebPubsubNetworkAclPublicNetworkBlock>>? PublicNetwork { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermWebPubsubNetworkAclTimeoutsBlock>? Timeouts { get; set; }

}
