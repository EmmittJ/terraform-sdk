using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_api_management_gateway_host_name_configuration resource.
/// </summary>
public class AzurermApiManagementGatewayHostNameConfiguration : TerraformResource
{
    public AzurermApiManagementGatewayHostNameConfiguration(string name) : base("azurerm_api_management_gateway_host_name_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The api_management_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ApiManagementId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_management_id");
        set => this.WithProperty("api_management_id", value);
    }

    /// <summary>
    /// The certificate_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CertificateId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_id");
        set => this.WithProperty("certificate_id", value);
    }

    /// <summary>
    /// The gateway_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? GatewayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gateway_name");
        set => this.WithProperty("gateway_name", value);
    }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? HostName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("host_name");
        set => this.WithProperty("host_name", value);
    }

    /// <summary>
    /// The http2_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Http2Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("http2_enabled");
        set => this.WithProperty("http2_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The request_client_certificate_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? RequestClientCertificateEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("request_client_certificate_enabled");
        set => this.WithProperty("request_client_certificate_enabled", value);
    }

    /// <summary>
    /// The tls10_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Tls10Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("tls10_enabled");
        set => this.WithProperty("tls10_enabled", value);
    }

    /// <summary>
    /// The tls11_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Tls11Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("tls11_enabled");
        set => this.WithProperty("tls11_enabled", value);
    }

}
