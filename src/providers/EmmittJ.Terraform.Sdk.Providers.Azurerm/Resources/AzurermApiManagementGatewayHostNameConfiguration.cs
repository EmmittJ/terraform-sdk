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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<string>(this, "api_management_id");
        set => SetArgument("api_management_id", value);
    }

    /// <summary>
    /// The certificate_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateId is required")]
    public required TerraformValue<string> CertificateId
    {
        get => new TerraformReference<string>(this, "certificate_id");
        set => SetArgument("certificate_id", value);
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
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    public required TerraformValue<string> HostName
    {
        get => new TerraformReference<string>(this, "host_name");
        set => SetArgument("host_name", value);
    }

    /// <summary>
    /// The http2_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Http2Enabled
    {
        get => new TerraformReference<bool>(this, "http2_enabled");
        set => SetArgument("http2_enabled", value);
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
    /// The request_client_certificate_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? RequestClientCertificateEnabled
    {
        get => new TerraformReference<bool>(this, "request_client_certificate_enabled");
        set => SetArgument("request_client_certificate_enabled", value);
    }

    /// <summary>
    /// The tls10_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Tls10Enabled
    {
        get => new TerraformReference<bool>(this, "tls10_enabled");
        set => SetArgument("tls10_enabled", value);
    }

    /// <summary>
    /// The tls11_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Tls11Enabled
    {
        get => new TerraformReference<bool>(this, "tls11_enabled");
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
