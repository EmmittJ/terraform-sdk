using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_web_pubsub_hub resource.
/// </summary>
public class AzurermWebPubsubHub : TerraformResource
{
    public AzurermWebPubsubHub(string name) : base("azurerm_web_pubsub_hub", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The anonymous_connections_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? AnonymousConnectionsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("anonymous_connections_enabled");
        set => this.WithProperty("anonymous_connections_enabled", value);
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
    /// The web_pubsub_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? WebPubsubId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("web_pubsub_id");
        set => this.WithProperty("web_pubsub_id", value);
    }

}
