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
    public TerraformProperty<bool>? AnonymousConnectionsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("anonymous_connections_enabled");
        set => this.WithProperty("anonymous_connections_enabled", value);
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

}
