using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_bot_service_azure_bot resource.
/// </summary>
public class AzurermBotServiceAzureBot : TerraformResource
{
    public AzurermBotServiceAzureBot(string name) : base("azurerm_bot_service_azure_bot", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The cmk_key_vault_key_url attribute.
    /// </summary>
    public string? CmkKeyVaultKeyUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cmk_key_vault_key_url")?.Value;
        set => this.WithProperty("cmk_key_vault_key_url", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The developer_app_insights_api_key attribute.
    /// </summary>
    public string? DeveloperAppInsightsApiKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("developer_app_insights_api_key")?.Value;
        set => this.WithProperty("developer_app_insights_api_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The developer_app_insights_application_id attribute.
    /// </summary>
    public string? DeveloperAppInsightsApplicationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("developer_app_insights_application_id")?.Value;
        set => this.WithProperty("developer_app_insights_application_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The developer_app_insights_key attribute.
    /// </summary>
    public string? DeveloperAppInsightsKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("developer_app_insights_key")?.Value;
        set => this.WithProperty("developer_app_insights_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public string? Endpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("endpoint")?.Value;
        set => this.WithProperty("endpoint", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The icon_url attribute.
    /// </summary>
    public string? IconUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("icon_url")?.Value;
        set => this.WithProperty("icon_url", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The local_authentication_enabled attribute.
    /// </summary>
    public bool? LocalAuthenticationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("local_authentication_enabled")?.Value;
        set => this.WithProperty("local_authentication_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The luis_app_ids attribute.
    /// </summary>
    public List<string>? LuisAppIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("luis_app_ids")?.Value;
        set => this.WithProperty("luis_app_ids", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The luis_key attribute.
    /// </summary>
    public string? LuisKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("luis_key")?.Value;
        set => this.WithProperty("luis_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The microsoft_app_id attribute.
    /// </summary>
    public string? MicrosoftAppId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("microsoft_app_id")?.Value;
        set => this.WithProperty("microsoft_app_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The microsoft_app_msi_id attribute.
    /// </summary>
    public string? MicrosoftAppMsiId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("microsoft_app_msi_id")?.Value;
        set => this.WithProperty("microsoft_app_msi_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The microsoft_app_tenant_id attribute.
    /// </summary>
    public string? MicrosoftAppTenantId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("microsoft_app_tenant_id")?.Value;
        set => this.WithProperty("microsoft_app_tenant_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The microsoft_app_type attribute.
    /// </summary>
    public string? MicrosoftAppType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("microsoft_app_type")?.Value;
        set => this.WithProperty("microsoft_app_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The public_network_access_enabled attribute.
    /// </summary>
    public bool? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("public_network_access_enabled")?.Value;
        set => this.WithProperty("public_network_access_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The sku attribute.
    /// </summary>
    public string? Sku
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku")?.Value;
        set => this.WithProperty("sku", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The streaming_endpoint_enabled attribute.
    /// </summary>
    public bool? StreamingEndpointEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("streaming_endpoint_enabled")?.Value;
        set => this.WithProperty("streaming_endpoint_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

}
