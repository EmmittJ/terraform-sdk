using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_bot_connection resource.
/// </summary>
public class AzurermBotConnection : TerraformResource
{
    public AzurermBotConnection(string name) : base("azurerm_bot_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The bot_name attribute.
    /// </summary>
    public string? BotName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bot_name")?.Value;
        set => this.WithProperty("bot_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public string? ClientId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_id")?.Value;
        set => this.WithProperty("client_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    public string? ClientSecret
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_secret")?.Value;
        set => this.WithProperty("client_secret", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, string>? Parameters
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("parameters")?.Value;
        set => this.WithProperty("parameters", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The scopes attribute.
    /// </summary>
    public string? Scopes
    {
        get => GetProperty<TerraformLiteralProperty<string>>("scopes")?.Value;
        set => this.WithProperty("scopes", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service_provider_name attribute.
    /// </summary>
    public string? ServiceProviderName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_provider_name")?.Value;
        set => this.WithProperty("service_provider_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
