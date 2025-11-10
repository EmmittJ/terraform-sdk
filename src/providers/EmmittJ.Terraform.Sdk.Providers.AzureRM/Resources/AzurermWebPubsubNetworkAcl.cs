using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for private_endpoint in .
/// Nesting mode: set
/// </summary>
public class AzurermWebPubsubNetworkAclPrivateEndpointBlock : TerraformBlock
{
    /// <summary>
    /// The allowed_request_types attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AllowedRequestTypes
    {
        set => SetProperty("allowed_request_types", value);
    }

    /// <summary>
    /// The denied_request_types attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? DeniedRequestTypes
    {
        set => SetProperty("denied_request_types", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        set => SetProperty("id", value);
    }

}

/// <summary>
/// Block type for public_network in .
/// Nesting mode: list
/// </summary>
public class AzurermWebPubsubNetworkAclPublicNetworkBlock : TerraformBlock
{
    /// <summary>
    /// The allowed_request_types attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AllowedRequestTypes
    {
        set => SetProperty("allowed_request_types", value);
    }

    /// <summary>
    /// The denied_request_types attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? DeniedRequestTypes
    {
        set => SetProperty("denied_request_types", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermWebPubsubNetworkAclTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_web_pubsub_network_acl resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermWebPubsubNetworkAcl : TerraformResource
{
    public AzurermWebPubsubNetworkAcl(string name) : base("azurerm_web_pubsub_network_acl", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("default_action");
        SetOutput("id");
        SetOutput("web_pubsub_id");
    }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    public TerraformProperty<string> DefaultAction
    {
        get => GetRequiredOutput<TerraformProperty<string>>("default_action");
        set => SetProperty("default_action", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The web_pubsub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebPubsubId is required")]
    public required TerraformProperty<string> WebPubsubId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("web_pubsub_id");
        set => SetProperty("web_pubsub_id", value);
    }

    /// <summary>
    /// Block for private_endpoint.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermWebPubsubNetworkAclPrivateEndpointBlock>? PrivateEndpoint
    {
        set => SetProperty("private_endpoint", value);
    }

    /// <summary>
    /// Block for public_network.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicNetwork is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PublicNetwork block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PublicNetwork block(s) allowed")]
    public List<AzurermWebPubsubNetworkAclPublicNetworkBlock>? PublicNetwork
    {
        set => SetProperty("public_network", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermWebPubsubNetworkAclTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
