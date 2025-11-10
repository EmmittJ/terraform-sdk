using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for credentials in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementBackendCredentialsBlock : TerraformBlock
{
    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Certificate
    {
        set => SetProperty("certificate", value);
    }

    /// <summary>
    /// The header attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Header
    {
        set => SetProperty("header", value);
    }

    /// <summary>
    /// The query attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Query
    {
        set => SetProperty("query", value);
    }

}

/// <summary>
/// Block type for proxy in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementBackendProxyBlock : TerraformBlock
{
    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformProperty<string>? Password
    {
        set => SetProperty("password", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformProperty<string> Url
    {
        set => SetProperty("url", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformProperty<string> Username
    {
        set => SetProperty("username", value);
    }

}

/// <summary>
/// Block type for service_fabric_cluster in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementBackendServiceFabricClusterBlock : TerraformBlock
{
    /// <summary>
    /// The client_certificate_id attribute.
    /// </summary>
    public TerraformProperty<string>? ClientCertificateId
    {
        set => SetProperty("client_certificate_id", value);
    }

    /// <summary>
    /// The client_certificate_thumbprint attribute.
    /// </summary>
    public TerraformProperty<string>? ClientCertificateThumbprint
    {
        set => SetProperty("client_certificate_thumbprint", value);
    }

    /// <summary>
    /// The management_endpoints attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagementEndpoints is required")]
    public HashSet<TerraformProperty<string>>? ManagementEndpoints
    {
        set => SetProperty("management_endpoints", value);
    }

    /// <summary>
    /// The max_partition_resolution_retries attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxPartitionResolutionRetries is required")]
    public required TerraformProperty<double> MaxPartitionResolutionRetries
    {
        set => SetProperty("max_partition_resolution_retries", value);
    }

    /// <summary>
    /// The server_certificate_thumbprints attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ServerCertificateThumbprints
    {
        set => SetProperty("server_certificate_thumbprints", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementBackendTimeoutsBlock : TerraformBlock
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
/// Block type for tls in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementBackendTlsBlock : TerraformBlock
{
    /// <summary>
    /// The validate_certificate_chain attribute.
    /// </summary>
    public TerraformProperty<bool>? ValidateCertificateChain
    {
        set => SetProperty("validate_certificate_chain", value);
    }

    /// <summary>
    /// The validate_certificate_name attribute.
    /// </summary>
    public TerraformProperty<bool>? ValidateCertificateName
    {
        set => SetProperty("validate_certificate_name", value);
    }

}

/// <summary>
/// Manages a azurerm_api_management_backend resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermApiManagementBackend : TerraformResource
{
    public AzurermApiManagementBackend(string name) : base("azurerm_api_management_backend", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("api_management_name");
        SetOutput("description");
        SetOutput("id");
        SetOutput("name");
        SetOutput("protocol");
        SetOutput("resource_group_name");
        SetOutput("resource_id");
        SetOutput("title");
        SetOutput("url");
    }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementName is required")]
    public required TerraformProperty<string> ApiManagementName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("api_management_name");
        set => SetProperty("api_management_name", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
    {
        get => GetRequiredOutput<TerraformProperty<string>>("protocol");
        set => SetProperty("protocol", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public TerraformProperty<string> ResourceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_id");
        set => SetProperty("resource_id", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    public TerraformProperty<string> Title
    {
        get => GetRequiredOutput<TerraformProperty<string>>("title");
        set => SetProperty("title", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformProperty<string> Url
    {
        get => GetRequiredOutput<TerraformProperty<string>>("url");
        set => SetProperty("url", value);
    }

    /// <summary>
    /// Block for credentials.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Credentials block(s) allowed")]
    public List<AzurermApiManagementBackendCredentialsBlock>? Credentials
    {
        set => SetProperty("credentials", value);
    }

    /// <summary>
    /// Block for proxy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Proxy block(s) allowed")]
    public List<AzurermApiManagementBackendProxyBlock>? Proxy
    {
        set => SetProperty("proxy", value);
    }

    /// <summary>
    /// Block for service_fabric_cluster.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceFabricCluster block(s) allowed")]
    public List<AzurermApiManagementBackendServiceFabricClusterBlock>? ServiceFabricCluster
    {
        set => SetProperty("service_fabric_cluster", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermApiManagementBackendTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for tls.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tls block(s) allowed")]
    public List<AzurermApiManagementBackendTlsBlock>? Tls
    {
        set => SetProperty("tls", value);
    }

}
