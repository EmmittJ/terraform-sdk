using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermApiManagementGatewayHostNameConfigurationDataSource.
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
        get => GetArgument<TerraformValue<string>>("read");
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
        get => GetRequiredArgument<TerraformValue<string>>("api_management_id");
        set => SetArgument("api_management_id", value);
    }

    /// <summary>
    /// The gateway_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayName is required")]
    public required TerraformValue<string> GatewayName
    {
        get => GetRequiredArgument<TerraformValue<string>>("gateway_name");
        set => SetArgument("gateway_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The certificate_id attribute.
    /// </summary>
    public TerraformValue<string> CertificateId
        => AsReference("certificate_id");

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    public TerraformValue<string> HostName
        => AsReference("host_name");

    /// <summary>
    /// The http2_enabled attribute.
    /// </summary>
    public TerraformValue<bool> Http2Enabled
        => AsReference("http2_enabled");

    /// <summary>
    /// The request_client_certificate_enabled attribute.
    /// </summary>
    public TerraformValue<bool> RequestClientCertificateEnabled
        => AsReference("request_client_certificate_enabled");

    /// <summary>
    /// The tls10_enabled attribute.
    /// </summary>
    public TerraformValue<bool> Tls10Enabled
        => AsReference("tls10_enabled");

    /// <summary>
    /// The tls11_enabled attribute.
    /// </summary>
    public TerraformValue<bool> Tls11Enabled
        => AsReference("tls11_enabled");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermApiManagementGatewayHostNameConfigurationDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermApiManagementGatewayHostNameConfigurationDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
