using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_web_pubsub_network_acl resource.
/// </summary>
public class AzurermWebPubsubNetworkAcl : TerraformResource
{
    public AzurermWebPubsubNetworkAcl(string name) : base("azurerm_web_pubsub_network_acl", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    public string? DefaultAction
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_action")?.Value;
        set => this.WithProperty("default_action", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The web_pubsub_id attribute.
    /// </summary>
    public string? WebPubsubId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("web_pubsub_id")?.Value;
        set => this.WithProperty("web_pubsub_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
