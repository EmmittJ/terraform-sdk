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
        get => GetProperty<List<TerraformProperty<string>>>("certificate");
        set => WithProperty("certificate", value);
    }

    /// <summary>
    /// The header attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Header
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("header");
        set => WithProperty("header", value);
    }

    /// <summary>
    /// The query attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Query
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("query");
        set => WithProperty("query", value);
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
        get => GetProperty<TerraformProperty<string>>("password");
        set => WithProperty("password", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformProperty<string> Url
    {
        get => GetProperty<TerraformProperty<string>>("url");
        set => WithProperty("url", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformProperty<string> Username
    {
        get => GetProperty<TerraformProperty<string>>("username");
        set => WithProperty("username", value);
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
        get => GetProperty<TerraformProperty<string>>("client_certificate_id");
        set => WithProperty("client_certificate_id", value);
    }

    /// <summary>
    /// The client_certificate_thumbprint attribute.
    /// </summary>
    public TerraformProperty<string>? ClientCertificateThumbprint
    {
        get => GetProperty<TerraformProperty<string>>("client_certificate_thumbprint");
        set => WithProperty("client_certificate_thumbprint", value);
    }

    /// <summary>
    /// The management_endpoints attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagementEndpoints is required")]
    public HashSet<TerraformProperty<string>>? ManagementEndpoints
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("management_endpoints");
        set => WithProperty("management_endpoints", value);
    }

    /// <summary>
    /// The max_partition_resolution_retries attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxPartitionResolutionRetries is required")]
    public required TerraformProperty<double> MaxPartitionResolutionRetries
    {
        get => GetProperty<TerraformProperty<double>>("max_partition_resolution_retries");
        set => WithProperty("max_partition_resolution_retries", value);
    }

    /// <summary>
    /// The server_certificate_thumbprints attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ServerCertificateThumbprints
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("server_certificate_thumbprints");
        set => WithProperty("server_certificate_thumbprints", value);
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
        get => GetProperty<TerraformProperty<bool>>("validate_certificate_chain");
        set => WithProperty("validate_certificate_chain", value);
    }

    /// <summary>
    /// The validate_certificate_name attribute.
    /// </summary>
    public TerraformProperty<bool>? ValidateCertificateName
    {
        get => GetProperty<TerraformProperty<bool>>("validate_certificate_name");
        set => WithProperty("validate_certificate_name", value);
    }

}

/// <summary>
/// Manages a azurerm_api_management_backend resource.
/// </summary>
public class AzurermApiManagementBackend : TerraformResource
{
    public AzurermApiManagementBackend(string name) : base("azurerm_api_management_backend", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementName is required")]
    public required TerraformProperty<string> ApiManagementName
    {
        get => GetProperty<TerraformProperty<string>>("api_management_name");
        set => this.WithProperty("api_management_name", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
    {
        get => GetProperty<TerraformProperty<string>>("protocol");
        set => this.WithProperty("protocol", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceId
    {
        get => GetProperty<TerraformProperty<string>>("resource_id");
        set => this.WithProperty("resource_id", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    public TerraformProperty<string>? Title
    {
        get => GetProperty<TerraformProperty<string>>("title");
        set => this.WithProperty("title", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformProperty<string> Url
    {
        get => GetProperty<TerraformProperty<string>>("url");
        set => this.WithProperty("url", value);
    }

    /// <summary>
    /// Block for credentials.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Credentials block(s) allowed")]
    public List<AzurermApiManagementBackendCredentialsBlock>? Credentials
    {
        get => GetProperty<List<AzurermApiManagementBackendCredentialsBlock>>("credentials");
        set => this.WithProperty("credentials", value);
    }

    /// <summary>
    /// Block for proxy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Proxy block(s) allowed")]
    public List<AzurermApiManagementBackendProxyBlock>? Proxy
    {
        get => GetProperty<List<AzurermApiManagementBackendProxyBlock>>("proxy");
        set => this.WithProperty("proxy", value);
    }

    /// <summary>
    /// Block for service_fabric_cluster.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceFabricCluster block(s) allowed")]
    public List<AzurermApiManagementBackendServiceFabricClusterBlock>? ServiceFabricCluster
    {
        get => GetProperty<List<AzurermApiManagementBackendServiceFabricClusterBlock>>("service_fabric_cluster");
        set => this.WithProperty("service_fabric_cluster", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermApiManagementBackendTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermApiManagementBackendTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for tls.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tls block(s) allowed")]
    public List<AzurermApiManagementBackendTlsBlock>? Tls
    {
        get => GetProperty<List<AzurermApiManagementBackendTlsBlock>>("tls");
        set => this.WithProperty("tls", value);
    }

}
