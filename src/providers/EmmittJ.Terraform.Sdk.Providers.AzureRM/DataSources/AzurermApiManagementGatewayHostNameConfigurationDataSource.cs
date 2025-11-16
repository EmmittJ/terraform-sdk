using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Represents a azurerm_api_management_gateway_host_name_configuration Terraform data source.
/// Retrieves information about a azurerm_api_management_gateway_host_name_configuration.
/// </summary>
public partial class AzurermApiManagementGatewayHostNameConfigurationDataSource(string name) : TerraformDataSource("azurerm_api_management_gateway_host_name_configuration", name)
{
    /// <summary>
    /// The api_management_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementId is required")]
    public required TerraformValue<string> ApiManagementId
    {
        get => new TerraformReference<string>(this, "api_management_id");
        set => SetArgument("api_management_id", value);
    }

    /// <summary>
    /// The gateway_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayName is required")]
    public required TerraformValue<string> GatewayName
    {
        get => new TerraformReference<string>(this, "gateway_name");
        set => SetArgument("gateway_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The certificate_id attribute.
    /// </summary>
    public TerraformValue<string> CertificateId
    {
        get => new TerraformReference<string>(this, "certificate_id");
    }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    public TerraformValue<string> HostName
    {
        get => new TerraformReference<string>(this, "host_name");
    }

    /// <summary>
    /// The http2_enabled attribute.
    /// </summary>
    public TerraformValue<bool> Http2Enabled
    {
        get => new TerraformReference<bool>(this, "http2_enabled");
    }

    /// <summary>
    /// The request_client_certificate_enabled attribute.
    /// </summary>
    public TerraformValue<bool> RequestClientCertificateEnabled
    {
        get => new TerraformReference<bool>(this, "request_client_certificate_enabled");
    }

    /// <summary>
    /// The tls10_enabled attribute.
    /// </summary>
    public TerraformValue<bool> Tls10Enabled
    {
        get => new TerraformReference<bool>(this, "tls10_enabled");
    }

    /// <summary>
    /// The tls11_enabled attribute.
    /// </summary>
    public TerraformValue<bool> Tls11Enabled
    {
        get => new TerraformReference<bool>(this, "tls11_enabled");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermApiManagementGatewayHostNameConfigurationDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermApiManagementGatewayHostNameConfigurationDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
