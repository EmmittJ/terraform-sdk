using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermApiManagementGatewayHostNameConfigurationTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_api_management_gateway_host_name_configuration resource.
/// </summary>
public partial class AzurermApiManagementGatewayHostNameConfiguration : TerraformResource
{
    public AzurermApiManagementGatewayHostNameConfiguration(string name) : base("azurerm_api_management_gateway_host_name_configuration", name)
    {
    }

    /// <summary>
    /// The api_management_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementId is required")]
    [TerraformProperty("api_management_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ApiManagementId { get; set; }

    /// <summary>
    /// The certificate_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateId is required")]
    [TerraformProperty("certificate_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CertificateId { get; set; }

    /// <summary>
    /// The gateway_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayName is required")]
    [TerraformProperty("gateway_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> GatewayName { get; set; }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    [TerraformProperty("host_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> HostName { get; set; }

    /// <summary>
    /// The http2_enabled attribute.
    /// </summary>
    [TerraformProperty("http2_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Http2Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The request_client_certificate_enabled attribute.
    /// </summary>
    [TerraformProperty("request_client_certificate_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? RequestClientCertificateEnabled { get; set; }

    /// <summary>
    /// The tls10_enabled attribute.
    /// </summary>
    [TerraformProperty("tls10_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Tls10Enabled { get; set; }

    /// <summary>
    /// The tls11_enabled attribute.
    /// </summary>
    [TerraformProperty("tls11_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Tls11Enabled { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermApiManagementGatewayHostNameConfigurationTimeoutsBlock>? Timeouts { get; set; }

}
