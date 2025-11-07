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
    /// The web_pubsub_id attribute.
    /// </summary>
    public TerraformProperty<string>? WebPubsubId
    {
        get => GetProperty<TerraformProperty<string>>("web_pubsub_id");
        set => this.WithProperty("web_pubsub_id", value);
    }

    /// <summary>
    /// The certificate_version attribute.
    /// </summary>
    public TerraformExpression CertificateVersion => this["certificate_version"];

}
