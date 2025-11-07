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
    public TerraformProperty<string>? CertificateId
    {
        get => GetProperty<TerraformProperty<string>>("certificate_id");
        set => this.WithProperty("certificate_id", value);
    }

    /// <summary>
    /// The hostname_binding_id attribute.
    /// </summary>
    public TerraformProperty<string>? HostnameBindingId
    {
        get => GetProperty<TerraformProperty<string>>("hostname_binding_id");
        set => this.WithProperty("hostname_binding_id", value);
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
    /// The ssl_state attribute.
    /// </summary>
    public TerraformProperty<string>? SslState
    {
        get => GetProperty<TerraformProperty<string>>("ssl_state");
        set => this.WithProperty("ssl_state", value);
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
