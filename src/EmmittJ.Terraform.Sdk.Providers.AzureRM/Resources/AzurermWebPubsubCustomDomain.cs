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
    public TerraformProperty<string>? DomainName
    {
        get => GetProperty<TerraformProperty<string>>("domain_name");
        set => this.WithProperty("domain_name", value);
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
    /// The web_pubsub_custom_certificate_id attribute.
    /// </summary>
    public TerraformProperty<string>? WebPubsubCustomCertificateId
    {
        get => GetProperty<TerraformProperty<string>>("web_pubsub_custom_certificate_id");
        set => this.WithProperty("web_pubsub_custom_certificate_id", value);
    }

    /// <summary>
    /// The web_pubsub_id attribute.
    /// </summary>
    public TerraformProperty<string>? WebPubsubId
    {
        get => GetProperty<TerraformProperty<string>>("web_pubsub_id");
        set => this.WithProperty("web_pubsub_id", value);
    }

}
