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
    public bool? AnonymousConnectionsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("anonymous_connections_enabled")?.Value;
        set => this.WithProperty("anonymous_connections_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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

}
