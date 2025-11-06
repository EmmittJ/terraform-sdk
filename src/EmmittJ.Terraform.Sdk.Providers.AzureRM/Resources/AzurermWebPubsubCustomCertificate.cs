using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_web_pubsub_custom_certificate resource.
/// </summary>
public class AzurermWebPubsubCustomCertificate : TerraformResource
{
    public AzurermWebPubsubCustomCertificate(string name) : base("azurerm_web_pubsub_custom_certificate", name)
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
    /// The web_pubsub_id attribute.
    /// </summary>
    public string? WebPubsubId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("web_pubsub_id")?.Value;
        set => this.WithProperty("web_pubsub_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The certificate_version attribute.
    /// </summary>
    public TerraformExpression CertificateVersion => this["certificate_version"];

}
