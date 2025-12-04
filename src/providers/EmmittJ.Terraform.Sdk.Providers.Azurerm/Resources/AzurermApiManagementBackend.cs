using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for credentials in AzurermApiManagementBackend.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementBackendCredentialsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "credentials";

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public TerraformList<string>? Certificate
    {
        get => GetArgument<TerraformList<string>>("certificate");
        set => SetArgument("certificate", value);
    }

    /// <summary>
    /// The header attribute.
    /// </summary>
    public TerraformMap<string>? Header
    {
        get => GetArgument<TerraformMap<string>>("header");
        set => SetArgument("header", value);
    }

    /// <summary>
    /// The query attribute.
    /// </summary>
    public TerraformMap<string>? Query
    {
        get => GetArgument<TerraformMap<string>>("query");
        set => SetArgument("query", value);
    }

    /// <summary>
    /// Authorization block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Authorization block(s) allowed")]
    public TerraformList<AzurermApiManagementBackendCredentialsBlockAuthorizationBlock>? Authorization
    {
        get => GetArgument<TerraformList<AzurermApiManagementBackendCredentialsBlockAuthorizationBlock>>("authorization");
        set => SetArgument("authorization", value);
    }

}

/// <summary>
/// Block type for authorization in AzurermApiManagementBackendCredentialsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementBackendCredentialsBlockAuthorizationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authorization";

    /// <summary>
    /// The parameter attribute.
    /// </summary>
    public TerraformValue<string>? Parameter
    {
        get => GetArgument<TerraformValue<string>>("parameter");
        set => SetArgument("parameter", value);
    }

    /// <summary>
    /// The scheme attribute.
    /// </summary>
    public TerraformValue<string>? Scheme
    {
        get => GetArgument<TerraformValue<string>>("scheme");
        set => SetArgument("scheme", value);
    }

}


/// <summary>
/// Block type for proxy in AzurermApiManagementBackend.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementBackendProxyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "proxy";

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => GetArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformValue<string> Url
    {
        get => GetArgument<TerraformValue<string>>("url");
        set => SetArgument("url", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => GetArgument<TerraformValue<string>>("username");
        set => SetArgument("username", value);
    }

}


/// <summary>
/// Block type for service_fabric_cluster in AzurermApiManagementBackend.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementBackendServiceFabricClusterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_fabric_cluster";

    /// <summary>
    /// The client_certificate_id attribute.
    /// </summary>
    public TerraformValue<string>? ClientCertificateId
    {
        get => GetArgument<TerraformValue<string>>("client_certificate_id");
        set => SetArgument("client_certificate_id", value);
    }

    /// <summary>
    /// The client_certificate_thumbprint attribute.
    /// </summary>
    public TerraformValue<string>? ClientCertificateThumbprint
    {
        get => GetArgument<TerraformValue<string>>("client_certificate_thumbprint");
        set => SetArgument("client_certificate_thumbprint", value);
    }

    /// <summary>
    /// The management_endpoints attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagementEndpoints is required")]
    public required TerraformSet<string> ManagementEndpoints
    {
        get => GetArgument<TerraformSet<string>>("management_endpoints");
        set => SetArgument("management_endpoints", value);
    }

    /// <summary>
    /// The max_partition_resolution_retries attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxPartitionResolutionRetries is required")]
    public required TerraformValue<double> MaxPartitionResolutionRetries
    {
        get => GetArgument<TerraformValue<double>>("max_partition_resolution_retries");
        set => SetArgument("max_partition_resolution_retries", value);
    }

    /// <summary>
    /// The server_certificate_thumbprints attribute.
    /// </summary>
    public TerraformSet<string>? ServerCertificateThumbprints
    {
        get => GetArgument<TerraformSet<string>>("server_certificate_thumbprints");
        set => SetArgument("server_certificate_thumbprints", value);
    }

    /// <summary>
    /// ServerX509Name block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermApiManagementBackendServiceFabricClusterBlockServerX509NameBlock>? ServerX509Name
    {
        get => GetArgument<TerraformSet<AzurermApiManagementBackendServiceFabricClusterBlockServerX509NameBlock>>("server_x509_name");
        set => SetArgument("server_x509_name", value);
    }

}

/// <summary>
/// Block type for server_x509_name in AzurermApiManagementBackendServiceFabricClusterBlock.
/// Nesting mode: set
/// </summary>
public class AzurermApiManagementBackendServiceFabricClusterBlockServerX509NameBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "server_x509_name";

    /// <summary>
    /// The issuer_certificate_thumbprint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IssuerCertificateThumbprint is required")]
    public required TerraformValue<string> IssuerCertificateThumbprint
    {
        get => GetArgument<TerraformValue<string>>("issuer_certificate_thumbprint");
        set => SetArgument("issuer_certificate_thumbprint", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermApiManagementBackend.
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementBackendTimeoutsBlock : TerraformBlock
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
/// Block type for tls in AzurermApiManagementBackend.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementBackendTlsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tls";

    /// <summary>
    /// The validate_certificate_chain attribute.
    /// </summary>
    public TerraformValue<bool>? ValidateCertificateChain
    {
        get => GetArgument<TerraformValue<bool>>("validate_certificate_chain");
        set => SetArgument("validate_certificate_chain", value);
    }

    /// <summary>
    /// The validate_certificate_name attribute.
    /// </summary>
    public TerraformValue<bool>? ValidateCertificateName
    {
        get => GetArgument<TerraformValue<bool>>("validate_certificate_name");
        set => SetArgument("validate_certificate_name", value);
    }

}


/// <summary>
/// Represents a azurerm_api_management_backend Terraform resource.
/// Manages a azurerm_api_management_backend resource.
/// </summary>
public partial class AzurermApiManagementBackend(string name) : TerraformResource("azurerm_api_management_backend", name)
{
    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementName is required")]
    public required TerraformValue<string> ApiManagementName
    {
        get => GetArgument<TerraformValue<string>>("api_management_name");
        set => SetArgument("api_management_name", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => GetArgument<TerraformValue<string>>("protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public TerraformValue<string>? ResourceId
    {
        get => GetArgument<TerraformValue<string>>("resource_id");
        set => SetArgument("resource_id", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    public TerraformValue<string>? Title
    {
        get => GetArgument<TerraformValue<string>>("title");
        set => SetArgument("title", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformValue<string> Url
    {
        get => GetArgument<TerraformValue<string>>("url");
        set => SetArgument("url", value);
    }

    /// <summary>
    /// Credentials block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Credentials block(s) allowed")]
    public TerraformList<AzurermApiManagementBackendCredentialsBlock>? Credentials
    {
        get => GetArgument<TerraformList<AzurermApiManagementBackendCredentialsBlock>>("credentials");
        set => SetArgument("credentials", value);
    }

    /// <summary>
    /// Proxy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Proxy block(s) allowed")]
    public TerraformList<AzurermApiManagementBackendProxyBlock>? Proxy
    {
        get => GetArgument<TerraformList<AzurermApiManagementBackendProxyBlock>>("proxy");
        set => SetArgument("proxy", value);
    }

    /// <summary>
    /// ServiceFabricCluster block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceFabricCluster block(s) allowed")]
    public TerraformList<AzurermApiManagementBackendServiceFabricClusterBlock>? ServiceFabricCluster
    {
        get => GetArgument<TerraformList<AzurermApiManagementBackendServiceFabricClusterBlock>>("service_fabric_cluster");
        set => SetArgument("service_fabric_cluster", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermApiManagementBackendTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermApiManagementBackendTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// Tls block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tls block(s) allowed")]
    public TerraformList<AzurermApiManagementBackendTlsBlock>? Tls
    {
        get => GetArgument<TerraformList<AzurermApiManagementBackendTlsBlock>>("tls");
        set => SetArgument("tls", value);
    }

}
