using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_bot_channels_registration resource.
/// </summary>
public class AzurermBotChannelsRegistration : TerraformResource
{
    public AzurermBotChannelsRegistration(string name) : base("azurerm_bot_channels_registration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The cmk_key_vault_url attribute.
    /// </summary>
    public TerraformProperty<string>? CmkKeyVaultUrl
    {
        get => GetProperty<TerraformProperty<string>>("cmk_key_vault_url");
        set => this.WithProperty("cmk_key_vault_url", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The developer_app_insights_api_key attribute.
    /// </summary>
    public TerraformProperty<string>? DeveloperAppInsightsApiKey
    {
        get => GetProperty<TerraformProperty<string>>("developer_app_insights_api_key");
        set => this.WithProperty("developer_app_insights_api_key", value);
    }

    /// <summary>
    /// The developer_app_insights_application_id attribute.
    /// </summary>
    public TerraformProperty<string>? DeveloperAppInsightsApplicationId
    {
        get => GetProperty<TerraformProperty<string>>("developer_app_insights_application_id");
        set => this.WithProperty("developer_app_insights_application_id", value);
    }

    /// <summary>
    /// The developer_app_insights_key attribute.
    /// </summary>
    public TerraformProperty<string>? DeveloperAppInsightsKey
    {
        get => GetProperty<TerraformProperty<string>>("developer_app_insights_key");
        set => this.WithProperty("developer_app_insights_key", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformProperty<string>? Endpoint
    {
        get => GetProperty<TerraformProperty<string>>("endpoint");
        set => this.WithProperty("endpoint", value);
    }

    /// <summary>
    /// The icon_url attribute.
    /// </summary>
    public TerraformProperty<string>? IconUrl
    {
        get => GetProperty<TerraformProperty<string>>("icon_url");
        set => this.WithProperty("icon_url", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The microsoft_app_id attribute.
    /// </summary>
    public TerraformProperty<string>? MicrosoftAppId
    {
        get => GetProperty<TerraformProperty<string>>("microsoft_app_id");
        set => this.WithProperty("microsoft_app_id", value);
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
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_network_access_enabled");
        set => this.WithProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformProperty<string>? Sku
    {
        get => GetProperty<TerraformProperty<string>>("sku");
        set => this.WithProperty("sku", value);
    }

    /// <summary>
    /// The streaming_endpoint_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? StreamingEndpointEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("streaming_endpoint_enabled");
        set => this.WithProperty("streaming_endpoint_enabled", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

}
