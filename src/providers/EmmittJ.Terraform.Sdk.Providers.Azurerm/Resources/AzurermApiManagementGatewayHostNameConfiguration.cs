using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermApiManagementGatewayHostNameConfiguration.
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementGatewayHostNameConfigurationTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_api_management_gateway_host_name_configuration Terraform resource.
/// Manages a azurerm_api_management_gateway_host_name_configuration resource.
/// </summary>
public partial class AzurermApiManagementGatewayHostNameConfiguration(string name) : TerraformResource("azurerm_api_management_gateway_host_name_configuration", name)
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
    /// The certificate_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateId is required")]
    public required TerraformValue<string> CertificateId
    {
        get => GetRequiredArgument<TerraformValue<string>>("certificate_id");
        set => SetArgument("certificate_id", value);
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
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    public required TerraformValue<string> HostName
    {
        get => GetRequiredArgument<TerraformValue<string>>("host_name");
        set => SetArgument("host_name", value);
    }

    /// <summary>
    /// The http2_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Http2Enabled
    {
        get => GetArgument<TerraformValue<bool>>("http2_enabled");
        set => SetArgument("http2_enabled", value);
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
    /// The request_client_certificate_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? RequestClientCertificateEnabled
    {
        get => GetArgument<TerraformValue<bool>>("request_client_certificate_enabled");
        set => SetArgument("request_client_certificate_enabled", value);
    }

    /// <summary>
    /// The tls10_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Tls10Enabled
    {
        get => GetArgument<TerraformValue<bool>>("tls10_enabled");
        set => SetArgument("tls10_enabled", value);
    }

    /// <summary>
    /// The tls11_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Tls11Enabled
    {
        get => GetArgument<TerraformValue<bool>>("tls11_enabled");
        set => SetArgument("tls11_enabled", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermApiManagementGatewayHostNameConfigurationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermApiManagementGatewayHostNameConfigurationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
