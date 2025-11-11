using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermApiManagementGatewayHostNameConfigurationDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_api_management_gateway_host_name_configuration.
/// </summary>
public partial class AzurermApiManagementGatewayHostNameConfigurationDataSource : TerraformDataSource
{
    public AzurermApiManagementGatewayHostNameConfigurationDataSource(string name) : base("azurerm_api_management_gateway_host_name_configuration", name)
    {
    }

    /// <summary>
    /// The api_management_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementId is required")]
    [TerraformProperty("api_management_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ApiManagementId { get; set; }

    /// <summary>
    /// The gateway_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayName is required")]
    [TerraformProperty("gateway_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> GatewayName { get; set; }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermApiManagementGatewayHostNameConfigurationDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The certificate_id attribute.
    /// </summary>
    [TerraformProperty("certificate_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CertificateId { get; }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [TerraformProperty("host_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> HostName { get; }

    /// <summary>
    /// The http2_enabled attribute.
    /// </summary>
    [TerraformProperty("http2_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Http2Enabled { get; }

    /// <summary>
    /// The request_client_certificate_enabled attribute.
    /// </summary>
    [TerraformProperty("request_client_certificate_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> RequestClientCertificateEnabled { get; }

    /// <summary>
    /// The tls10_enabled attribute.
    /// </summary>
    [TerraformProperty("tls10_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Tls10Enabled { get; }

    /// <summary>
    /// The tls11_enabled attribute.
    /// </summary>
    [TerraformProperty("tls11_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Tls11Enabled { get; }

}
