using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementGatewayHostNameConfigurationDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_api_management_gateway_host_name_configuration.
/// </summary>
public class AzurermApiManagementGatewayHostNameConfigurationDataSource : TerraformDataSource
{
    public AzurermApiManagementGatewayHostNameConfigurationDataSource(string name) : base("azurerm_api_management_gateway_host_name_configuration", name)
    {
    }

    /// <summary>
    /// The api_management_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementId is required")]
    [TerraformPropertyName("api_management_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ApiManagementId { get; set; }

    /// <summary>
    /// The gateway_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayName is required")]
    [TerraformPropertyName("gateway_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> GatewayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermApiManagementGatewayHostNameConfigurationDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The certificate_id attribute.
    /// </summary>
    [TerraformPropertyName("certificate_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CertificateId => new TerraformReference(this, "certificate_id");

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [TerraformPropertyName("host_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> HostName => new TerraformReference(this, "host_name");

    /// <summary>
    /// The http2_enabled attribute.
    /// </summary>
    [TerraformPropertyName("http2_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Http2Enabled => new TerraformReference(this, "http2_enabled");

    /// <summary>
    /// The request_client_certificate_enabled attribute.
    /// </summary>
    [TerraformPropertyName("request_client_certificate_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> RequestClientCertificateEnabled => new TerraformReference(this, "request_client_certificate_enabled");

    /// <summary>
    /// The tls10_enabled attribute.
    /// </summary>
    [TerraformPropertyName("tls10_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Tls10Enabled => new TerraformReference(this, "tls10_enabled");

    /// <summary>
    /// The tls11_enabled attribute.
    /// </summary>
    [TerraformPropertyName("tls11_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Tls11Enabled => new TerraformReference(this, "tls11_enabled");

}
