using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for private_endpoint in .
/// Nesting mode: set
/// </summary>
public class AzurermSignalrServiceNetworkAclPrivateEndpointBlock : TerraformBlock
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
public class AzurermSignalrServiceNetworkAclPublicNetworkBlock : TerraformBlock
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
public class AzurermSignalrServiceNetworkAclTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_signalr_service_network_acl resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermSignalrServiceNetworkAcl : TerraformResource
{
    public AzurermSignalrServiceNetworkAcl(string name) : base("azurerm_signalr_service_network_acl", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("default_action");
        SetOutput("id");
        SetOutput("signalr_service_id");
    }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAction is required")]
    public required TerraformProperty<string> DefaultAction
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
    /// The signalr_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SignalrServiceId is required")]
    public required TerraformProperty<string> SignalrServiceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("signalr_service_id");
        set => SetProperty("signalr_service_id", value);
    }

    /// <summary>
    /// Block for private_endpoint.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermSignalrServiceNetworkAclPrivateEndpointBlock>? PrivateEndpoint
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
    public List<AzurermSignalrServiceNetworkAclPublicNetworkBlock>? PublicNetwork
    {
        set => SetProperty("public_network", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSignalrServiceNetworkAclTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
