using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for credentials in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApiManagementBackendCredentialsBlock : TerraformBlockBase
{
    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [TerraformProperty("certificate")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Certificate { get; set; }

    /// <summary>
    /// The header attribute.
    /// </summary>
    [TerraformProperty("header")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Header { get; set; }

    /// <summary>
    /// The query attribute.
    /// </summary>
    [TerraformProperty("query")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Query { get; set; }

}

/// <summary>
/// Block type for proxy in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApiManagementBackendProxyBlock : TerraformBlockBase
{
    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformProperty("password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Password { get; set; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    [TerraformProperty("url")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Url { get; set; }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformProperty("username")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Username { get; set; }

}

/// <summary>
/// Block type for service_fabric_cluster in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApiManagementBackendServiceFabricClusterBlock : TerraformBlockBase
{
    /// <summary>
    /// The client_certificate_id attribute.
    /// </summary>
    [TerraformProperty("client_certificate_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ClientCertificateId { get; set; }

    /// <summary>
    /// The client_certificate_thumbprint attribute.
    /// </summary>
    [TerraformProperty("client_certificate_thumbprint")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ClientCertificateThumbprint { get; set; }

    /// <summary>
    /// The management_endpoints attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagementEndpoints is required")]
    [TerraformProperty("management_endpoints")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> ManagementEndpoints { get; set; }

    /// <summary>
    /// The max_partition_resolution_retries attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxPartitionResolutionRetries is required")]
    [TerraformProperty("max_partition_resolution_retries")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> MaxPartitionResolutionRetries { get; set; }

    /// <summary>
    /// The server_certificate_thumbprints attribute.
    /// </summary>
    [TerraformProperty("server_certificate_thumbprints")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? ServerCertificateThumbprints { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermApiManagementBackendTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for tls in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApiManagementBackendTlsBlock : TerraformBlockBase
{
    /// <summary>
    /// The validate_certificate_chain attribute.
    /// </summary>
    [TerraformProperty("validate_certificate_chain")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ValidateCertificateChain { get; set; }

    /// <summary>
    /// The validate_certificate_name attribute.
    /// </summary>
    [TerraformProperty("validate_certificate_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ValidateCertificateName { get; set; }

}

/// <summary>
/// Manages a azurerm_api_management_backend resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermApiManagementBackend : TerraformResource
{
    public AzurermApiManagementBackend(string name) : base("azurerm_api_management_backend", name)
    {
    }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementName is required")]
    [TerraformProperty("api_management_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ApiManagementName { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformProperty("protocol")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Protocol { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [TerraformProperty("resource_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ResourceId { get; set; }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [TerraformProperty("title")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Title { get; set; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    [TerraformProperty("url")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Url { get; set; }

    /// <summary>
    /// Block for credentials.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Credentials block(s) allowed")]
    [TerraformProperty("credentials")]
    public partial TerraformList<TerraformBlock<AzurermApiManagementBackendCredentialsBlock>>? Credentials { get; set; }

    /// <summary>
    /// Block for proxy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Proxy block(s) allowed")]
    [TerraformProperty("proxy")]
    public partial TerraformList<TerraformBlock<AzurermApiManagementBackendProxyBlock>>? Proxy { get; set; }

    /// <summary>
    /// Block for service_fabric_cluster.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceFabricCluster block(s) allowed")]
    [TerraformProperty("service_fabric_cluster")]
    public partial TerraformList<TerraformBlock<AzurermApiManagementBackendServiceFabricClusterBlock>>? ServiceFabricCluster { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermApiManagementBackendTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for tls.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tls block(s) allowed")]
    [TerraformProperty("tls")]
    public partial TerraformList<TerraformBlock<AzurermApiManagementBackendTlsBlock>>? Tls { get; set; }

}
