using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_signalr_service_custom_domain resource.
/// </summary>
public class AzurermSignalrServiceCustomDomain : TerraformResource
{
    public AzurermSignalrServiceCustomDomain(string name) : base("azurerm_signalr_service_custom_domain", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public string? DomainName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_name")?.Value;
        set => this.WithProperty("domain_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The signalr_custom_certificate_id attribute.
    /// </summary>
    public string? SignalrCustomCertificateId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("signalr_custom_certificate_id")?.Value;
        set => this.WithProperty("signalr_custom_certificate_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The signalr_service_id attribute.
    /// </summary>
    public string? SignalrServiceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("signalr_service_id")?.Value;
        set => this.WithProperty("signalr_service_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
