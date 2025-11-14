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
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementGatewayHostNameConfigurationDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

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
    [TerraformArgument("api_management_id")]
    public required TerraformValue<string> ApiManagementId
    {
        get => new TerraformReference<string>(this, "api_management_id");
        set => SetArgument("api_management_id", value);
    }

    /// <summary>
    /// The gateway_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayName is required")]
    [TerraformArgument("gateway_name")]
    public required TerraformValue<string> GatewayName
    {
        get => new TerraformReference<string>(this, "gateway_name");
        set => SetArgument("gateway_name", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermApiManagementGatewayHostNameConfigurationDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The certificate_id attribute.
    /// </summary>
    [TerraformArgument("certificate_id")]
    public TerraformValue<string> CertificateId
    {
        get => new TerraformReference<string>(this, "certificate_id");
    }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [TerraformArgument("host_name")]
    public TerraformValue<string> HostName
    {
        get => new TerraformReference<string>(this, "host_name");
    }

    /// <summary>
    /// The http2_enabled attribute.
    /// </summary>
    [TerraformArgument("http2_enabled")]
    public TerraformValue<bool> Http2Enabled
    {
        get => new TerraformReference<bool>(this, "http2_enabled");
    }

    /// <summary>
    /// The request_client_certificate_enabled attribute.
    /// </summary>
    [TerraformArgument("request_client_certificate_enabled")]
    public TerraformValue<bool> RequestClientCertificateEnabled
    {
        get => new TerraformReference<bool>(this, "request_client_certificate_enabled");
    }

    /// <summary>
    /// The tls10_enabled attribute.
    /// </summary>
    [TerraformArgument("tls10_enabled")]
    public TerraformValue<bool> Tls10Enabled
    {
        get => new TerraformReference<bool>(this, "tls10_enabled");
    }

    /// <summary>
    /// The tls11_enabled attribute.
    /// </summary>
    [TerraformArgument("tls11_enabled")]
    public TerraformValue<bool> Tls11Enabled
    {
        get => new TerraformReference<bool>(this, "tls11_enabled");
    }

}
