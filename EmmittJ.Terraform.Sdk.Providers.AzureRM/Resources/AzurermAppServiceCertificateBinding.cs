using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_app_service_certificate_binding resource.
/// </summary>
public class AzurermAppServiceCertificateBinding : TerraformResource
{
    public AzurermAppServiceCertificateBinding(string name) : base("azurerm_app_service_certificate_binding", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("app_service_name");
        this.DeclareOutput("hostname");
        this.DeclareOutput("thumbprint");
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
    /// The hostname_binding_id attribute.
    /// </summary>
    public string? HostnameBindingId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hostname_binding_id")?.Value;
        set => this.WithProperty("hostname_binding_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The ssl_state attribute.
    /// </summary>
    public string? SslState
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ssl_state")?.Value;
        set => this.WithProperty("ssl_state", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The app_service_name attribute.
    /// </summary>
    public TerraformExpression AppServiceName => this["app_service_name"];

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    public TerraformExpression Hostname => this["hostname"];

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformExpression Thumbprint => this["thumbprint"];

}
