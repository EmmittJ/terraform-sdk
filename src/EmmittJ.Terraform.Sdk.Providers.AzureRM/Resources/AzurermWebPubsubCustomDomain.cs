using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_web_pubsub_custom_domain resource.
/// </summary>
public class AzurermWebPubsubCustomDomain : TerraformResource
{
    public AzurermWebPubsubCustomDomain(string name) : base("azurerm_web_pubsub_custom_domain", name)
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
    /// The web_pubsub_custom_certificate_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? WebPubsubCustomCertificateId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("web_pubsub_custom_certificate_id");
        set => this.WithProperty("web_pubsub_custom_certificate_id", value);
    }

    /// <summary>
    /// The web_pubsub_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? WebPubsubId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("web_pubsub_id");
        set => this.WithProperty("web_pubsub_id", value);
    }

}
