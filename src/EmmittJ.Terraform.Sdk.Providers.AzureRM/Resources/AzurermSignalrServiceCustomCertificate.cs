using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_signalr_service_custom_certificate resource.
/// </summary>
public class AzurermSignalrServiceCustomCertificate : TerraformResource
{
    public AzurermSignalrServiceCustomCertificate(string name) : base("azurerm_signalr_service_custom_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("certificate_version");
    }

    /// <summary>
    /// The custom_certificate_id attribute.
    /// </summary>
    public TerraformProperty<string>? CustomCertificateId
    {
        get => GetProperty<TerraformProperty<string>>("custom_certificate_id");
        set => this.WithProperty("custom_certificate_id", value);
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
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The signalr_service_id attribute.
    /// </summary>
    public TerraformProperty<string>? SignalrServiceId
    {
        get => GetProperty<TerraformProperty<string>>("signalr_service_id");
        set => this.WithProperty("signalr_service_id", value);
    }

    /// <summary>
    /// The certificate_version attribute.
    /// </summary>
    public TerraformExpression CertificateVersion => this["certificate_version"];

}
