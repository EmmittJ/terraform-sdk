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
    public string? ApiManagementId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_management_id")?.Value;
        set => this.WithProperty("api_management_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The certificate_id attribute.
    /// </summary>
    public string? CertificateId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_id")?.Value;
        set => this.WithProperty("certificate_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The gateway_name attribute.
    /// </summary>
    public string? GatewayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gateway_name")?.Value;
        set => this.WithProperty("gateway_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    public string? HostName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("host_name")?.Value;
        set => this.WithProperty("host_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The http2_enabled attribute.
    /// </summary>
    public bool? Http2Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("http2_enabled")?.Value;
        set => this.WithProperty("http2_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The request_client_certificate_enabled attribute.
    /// </summary>
    public bool? RequestClientCertificateEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("request_client_certificate_enabled")?.Value;
        set => this.WithProperty("request_client_certificate_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The tls10_enabled attribute.
    /// </summary>
    public bool? Tls10Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("tls10_enabled")?.Value;
        set => this.WithProperty("tls10_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The tls11_enabled attribute.
    /// </summary>
    public bool? Tls11Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("tls11_enabled")?.Value;
        set => this.WithProperty("tls11_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

}
