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
    public string? CustomCertificateId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_certificate_id")?.Value;
        set => this.WithProperty("custom_certificate_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The signalr_service_id attribute.
    /// </summary>
    public string? SignalrServiceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("signalr_service_id")?.Value;
        set => this.WithProperty("signalr_service_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The certificate_version attribute.
    /// </summary>
    public TerraformExpression CertificateVersion => this["certificate_version"];

}
