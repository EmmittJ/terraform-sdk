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
    public TerraformLiteralProperty<string>? DomainName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_name");
        set => this.WithProperty("domain_name", value);
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
    /// The signalr_custom_certificate_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SignalrCustomCertificateId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("signalr_custom_certificate_id");
        set => this.WithProperty("signalr_custom_certificate_id", value);
    }

    /// <summary>
    /// The signalr_service_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SignalrServiceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("signalr_service_id");
        set => this.WithProperty("signalr_service_id", value);
    }

}
