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
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
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
        this.DeclareOutput("certificate_id");
        this.DeclareOutput("host_name");
        this.DeclareOutput("http2_enabled");
        this.DeclareOutput("request_client_certificate_enabled");
        this.DeclareOutput("tls10_enabled");
        this.DeclareOutput("tls11_enabled");
    }

    /// <summary>
    /// The api_management_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementId is required")]
    public required TerraformProperty<string> ApiManagementId
    {
        get => GetProperty<TerraformProperty<string>>("api_management_id");
        set => this.WithProperty("api_management_id", value);
    }

    /// <summary>
    /// The gateway_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayName is required")]
    public required TerraformProperty<string> GatewayName
    {
        get => GetProperty<TerraformProperty<string>>("gateway_name");
        set => this.WithProperty("gateway_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermApiManagementGatewayHostNameConfigurationDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermApiManagementGatewayHostNameConfigurationDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
