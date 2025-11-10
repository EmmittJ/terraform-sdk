using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for credentials in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementBackendCredentialsBlock : ITerraformBlock
{
    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [TerraformPropertyName("certificate")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Certificate { get; set; }

    /// <summary>
    /// The header attribute.
    /// </summary>
    [TerraformPropertyName("header")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Header { get; set; }

    /// <summary>
    /// The query attribute.
    /// </summary>
    [TerraformPropertyName("query")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Query { get; set; }

}

/// <summary>
/// Block type for proxy in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementBackendProxyBlock : ITerraformBlock
{
    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformPropertyName("password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Password { get; set; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    [TerraformPropertyName("url")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Url { get; set; }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformPropertyName("username")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Username { get; set; }

}

/// <summary>
/// Block type for service_fabric_cluster in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementBackendServiceFabricClusterBlock : ITerraformBlock
{
    /// <summary>
    /// The client_certificate_id attribute.
    /// </summary>
    [TerraformPropertyName("client_certificate_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ClientCertificateId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "client_certificate_id");

    /// <summary>
    /// The client_certificate_thumbprint attribute.
    /// </summary>
    [TerraformPropertyName("client_certificate_thumbprint")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ClientCertificateThumbprint { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "client_certificate_thumbprint");

    /// <summary>
    /// The management_endpoints attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagementEndpoints is required")]
    [TerraformPropertyName("management_endpoints")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? ManagementEndpoints { get; set; }

    /// <summary>
    /// The max_partition_resolution_retries attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxPartitionResolutionRetries is required")]
    [TerraformPropertyName("max_partition_resolution_retries")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MaxPartitionResolutionRetries { get; set; }

    /// <summary>
    /// The server_certificate_thumbprints attribute.
    /// </summary>
    [TerraformPropertyName("server_certificate_thumbprints")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? ServerCertificateThumbprints { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementBackendTimeoutsBlock : ITerraformBlock
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
/// Block type for tls in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementBackendTlsBlock : ITerraformBlock
{
    /// <summary>
    /// The validate_certificate_chain attribute.
    /// </summary>
    [TerraformPropertyName("validate_certificate_chain")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ValidateCertificateChain { get; set; }

    /// <summary>
    /// The validate_certificate_name attribute.
    /// </summary>
    [TerraformPropertyName("validate_certificate_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ValidateCertificateName { get; set; }

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
    [TerraformPropertyName("api_management_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ApiManagementName { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformPropertyName("protocol")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Protocol { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [TerraformPropertyName("resource_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ResourceId { get; set; }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [TerraformPropertyName("title")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Title { get; set; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    [TerraformPropertyName("url")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Url { get; set; }

    /// <summary>
    /// Block for credentials.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Credentials block(s) allowed")]
    [TerraformPropertyName("credentials")]
    public TerraformList<TerraformBlock<AzurermApiManagementBackendCredentialsBlock>>? Credentials { get; set; } = new();

    /// <summary>
    /// Block for proxy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Proxy block(s) allowed")]
    [TerraformPropertyName("proxy")]
    public TerraformList<TerraformBlock<AzurermApiManagementBackendProxyBlock>>? Proxy { get; set; } = new();

    /// <summary>
    /// Block for service_fabric_cluster.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceFabricCluster block(s) allowed")]
    [TerraformPropertyName("service_fabric_cluster")]
    public TerraformList<TerraformBlock<AzurermApiManagementBackendServiceFabricClusterBlock>>? ServiceFabricCluster { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermApiManagementBackendTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for tls.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tls block(s) allowed")]
    [TerraformPropertyName("tls")]
    public TerraformList<TerraformBlock<AzurermApiManagementBackendTlsBlock>>? Tls { get; set; } = new();

}
