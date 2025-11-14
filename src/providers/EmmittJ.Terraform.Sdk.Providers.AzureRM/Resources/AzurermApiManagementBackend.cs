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
/// Block type for credentials in .
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
    [TerraformArgument("certificate")]
    public TerraformList<string>? Certificate
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "certificate").ResolveNodes(ctx));
        set => SetArgument("certificate", value);
    }

    /// <summary>
    /// The header attribute.
    /// </summary>
    [TerraformArgument("header")]
    public TerraformMap<string>? Header
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "header").ResolveNodes(ctx));
        set => SetArgument("header", value);
    }

    /// <summary>
    /// The query attribute.
    /// </summary>
    [TerraformArgument("query")]
    public TerraformMap<string>? Query
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "query").ResolveNodes(ctx));
        set => SetArgument("query", value);
    }

}

/// <summary>
/// Block type for proxy in .
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
    [TerraformArgument("password")]
    public TerraformValue<string>? Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    [TerraformArgument("url")]
    public required TerraformValue<string> Url
    {
        get => new TerraformReference<string>(this, "url");
        set => SetArgument("url", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformArgument("username")]
    public required TerraformValue<string> Username
    {
        get => new TerraformReference<string>(this, "username");
        set => SetArgument("username", value);
    }

}

/// <summary>
/// Block type for service_fabric_cluster in .
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
    [TerraformArgument("client_certificate_id")]
    public TerraformValue<string> ClientCertificateId
    {
        get => new TerraformReference<string>(this, "client_certificate_id");
        set => SetArgument("client_certificate_id", value);
    }

    /// <summary>
    /// The client_certificate_thumbprint attribute.
    /// </summary>
    [TerraformArgument("client_certificate_thumbprint")]
    public TerraformValue<string> ClientCertificateThumbprint
    {
        get => new TerraformReference<string>(this, "client_certificate_thumbprint");
        set => SetArgument("client_certificate_thumbprint", value);
    }

    /// <summary>
    /// The management_endpoints attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagementEndpoints is required")]
    [TerraformArgument("management_endpoints")]
    public required TerraformSet<string> ManagementEndpoints
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "management_endpoints").ResolveNodes(ctx));
        set => SetArgument("management_endpoints", value);
    }

    /// <summary>
    /// The max_partition_resolution_retries attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxPartitionResolutionRetries is required")]
    [TerraformArgument("max_partition_resolution_retries")]
    public required TerraformValue<double> MaxPartitionResolutionRetries
    {
        get => new TerraformReference<double>(this, "max_partition_resolution_retries");
        set => SetArgument("max_partition_resolution_retries", value);
    }

    /// <summary>
    /// The server_certificate_thumbprints attribute.
    /// </summary>
    [TerraformArgument("server_certificate_thumbprints")]
    public TerraformSet<string>? ServerCertificateThumbprints
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "server_certificate_thumbprints").ResolveNodes(ctx));
        set => SetArgument("server_certificate_thumbprints", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
/// Block type for tls in .
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
    [TerraformArgument("validate_certificate_chain")]
    public TerraformValue<bool>? ValidateCertificateChain
    {
        get => new TerraformReference<bool>(this, "validate_certificate_chain");
        set => SetArgument("validate_certificate_chain", value);
    }

    /// <summary>
    /// The validate_certificate_name attribute.
    /// </summary>
    [TerraformArgument("validate_certificate_name")]
    public TerraformValue<bool>? ValidateCertificateName
    {
        get => new TerraformReference<bool>(this, "validate_certificate_name");
        set => SetArgument("validate_certificate_name", value);
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
    }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementName is required")]
    [TerraformArgument("api_management_name")]
    public required TerraformValue<string> ApiManagementName
    {
        get => new TerraformReference<string>(this, "api_management_name");
        set => SetArgument("api_management_name", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformArgument("protocol")]
    public required TerraformValue<string> Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [TerraformArgument("resource_id")]
    public TerraformValue<string>? ResourceId
    {
        get => new TerraformReference<string>(this, "resource_id");
        set => SetArgument("resource_id", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [TerraformArgument("title")]
    public TerraformValue<string>? Title
    {
        get => new TerraformReference<string>(this, "title");
        set => SetArgument("title", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    [TerraformArgument("url")]
    public required TerraformValue<string> Url
    {
        get => new TerraformReference<string>(this, "url");
        set => SetArgument("url", value);
    }

    /// <summary>
    /// Block for credentials.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Credentials block(s) allowed")]
    [TerraformArgument("credentials")]
    public TerraformList<AzurermApiManagementBackendCredentialsBlock> Credentials { get; set; } = new();

    /// <summary>
    /// Block for proxy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Proxy block(s) allowed")]
    [TerraformArgument("proxy")]
    public TerraformList<AzurermApiManagementBackendProxyBlock> Proxy { get; set; } = new();

    /// <summary>
    /// Block for service_fabric_cluster.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceFabricCluster block(s) allowed")]
    [TerraformArgument("service_fabric_cluster")]
    public TerraformList<AzurermApiManagementBackendServiceFabricClusterBlock> ServiceFabricCluster { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermApiManagementBackendTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for tls.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tls block(s) allowed")]
    [TerraformArgument("tls")]
    public TerraformList<AzurermApiManagementBackendTlsBlock> Tls { get; set; } = new();

}
