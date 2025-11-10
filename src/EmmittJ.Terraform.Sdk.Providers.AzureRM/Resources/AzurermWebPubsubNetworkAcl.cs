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
        get => GetProperty<HashSet<TerraformProperty<string>>>("allowed_request_types");
        set => WithProperty("allowed_request_types", value);
    }

    /// <summary>
    /// The denied_request_types attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? DeniedRequestTypes
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("denied_request_types");
        set => WithProperty("denied_request_types", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
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
        get => GetProperty<HashSet<TerraformProperty<string>>>("allowed_request_types");
        set => WithProperty("allowed_request_types", value);
    }

    /// <summary>
    /// The denied_request_types attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? DeniedRequestTypes
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("denied_request_types");
        set => WithProperty("denied_request_types", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
    }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultAction
    {
        get => GetProperty<TerraformProperty<string>>("default_action");
        set => this.WithProperty("default_action", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The web_pubsub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebPubsubId is required")]
    public required TerraformProperty<string> WebPubsubId
    {
        get => GetProperty<TerraformProperty<string>>("web_pubsub_id");
        set => this.WithProperty("web_pubsub_id", value);
    }

    /// <summary>
    /// Block for private_endpoint.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermWebPubsubNetworkAclPrivateEndpointBlock>? PrivateEndpoint
    {
        get => GetProperty<HashSet<AzurermWebPubsubNetworkAclPrivateEndpointBlock>>("private_endpoint");
        set => this.WithProperty("private_endpoint", value);
    }

    /// <summary>
    /// Block for public_network.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PublicNetwork block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PublicNetwork block(s) allowed")]
    public List<AzurermWebPubsubNetworkAclPublicNetworkBlock>? PublicNetwork
    {
        get => GetProperty<List<AzurermWebPubsubNetworkAclPublicNetworkBlock>>("public_network");
        set => this.WithProperty("public_network", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermWebPubsubNetworkAclTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermWebPubsubNetworkAclTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
