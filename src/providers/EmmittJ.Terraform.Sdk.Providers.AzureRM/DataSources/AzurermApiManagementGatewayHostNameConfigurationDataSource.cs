using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementGatewayHostNameConfigurationDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_api_management_gateway_host_name_configuration.
/// </summary>
public class AzurermApiManagementGatewayHostNameConfigurationDataSource : TerraformDataSource
{
    public AzurermApiManagementGatewayHostNameConfigurationDataSource(string name) : base("azurerm_api_management_gateway_host_name_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("certificate_id");
        SetOutput("host_name");
        SetOutput("http2_enabled");
        SetOutput("request_client_certificate_enabled");
        SetOutput("tls10_enabled");
        SetOutput("tls11_enabled");
        SetOutput("api_management_id");
        SetOutput("gateway_name");
        SetOutput("id");
        SetOutput("name");
    }

    /// <summary>
    /// The api_management_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementId is required")]
    public required TerraformProperty<string> ApiManagementId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("api_management_id");
        set => SetProperty("api_management_id", value);
    }

    /// <summary>
    /// The gateway_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayName is required")]
    public required TerraformProperty<string> GatewayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("gateway_name");
        set => SetProperty("gateway_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermApiManagementGatewayHostNameConfigurationDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The certificate_id attribute.
    /// </summary>
    public TerraformExpression CertificateId => this["certificate_id"];

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    public TerraformExpression HostName => this["host_name"];

    /// <summary>
    /// The http2_enabled attribute.
    /// </summary>
    public TerraformExpression Http2Enabled => this["http2_enabled"];

    /// <summary>
    /// The request_client_certificate_enabled attribute.
    /// </summary>
    public TerraformExpression RequestClientCertificateEnabled => this["request_client_certificate_enabled"];

    /// <summary>
    /// The tls10_enabled attribute.
    /// </summary>
    public TerraformExpression Tls10Enabled => this["tls10_enabled"];

    /// <summary>
    /// The tls11_enabled attribute.
    /// </summary>
    public TerraformExpression Tls11Enabled => this["tls11_enabled"];

}
