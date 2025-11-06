using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_bot_web_app resource.
/// </summary>
public class AzurermBotWebApp : TerraformResource
{
    public AzurermBotWebApp(string name) : base("azurerm_bot_web_app", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

}
