using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermBotChannelsRegistrationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

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
        SetOutput("cmk_key_vault_url");
        SetOutput("description");
        SetOutput("developer_app_insights_api_key");
        SetOutput("developer_app_insights_application_id");
        SetOutput("developer_app_insights_key");
        SetOutput("display_name");
        SetOutput("endpoint");
        SetOutput("icon_url");
        SetOutput("id");
        SetOutput("location");
        SetOutput("microsoft_app_id");
        SetOutput("name");
        SetOutput("public_network_access_enabled");
        SetOutput("resource_group_name");
        SetOutput("sku");
        SetOutput("streaming_endpoint_enabled");
        SetOutput("tags");
    }

    /// <summary>
    /// The cmk_key_vault_url attribute.
    /// </summary>
    public TerraformProperty<string> CmkKeyVaultUrl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cmk_key_vault_url");
        set => SetProperty("cmk_key_vault_url", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The developer_app_insights_api_key attribute.
    /// </summary>
    public TerraformProperty<string> DeveloperAppInsightsApiKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("developer_app_insights_api_key");
        set => SetProperty("developer_app_insights_api_key", value);
    }

    /// <summary>
    /// The developer_app_insights_application_id attribute.
    /// </summary>
    public TerraformProperty<string> DeveloperAppInsightsApplicationId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("developer_app_insights_application_id");
        set => SetProperty("developer_app_insights_application_id", value);
    }

    /// <summary>
    /// The developer_app_insights_key attribute.
    /// </summary>
    public TerraformProperty<string> DeveloperAppInsightsKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("developer_app_insights_key");
        set => SetProperty("developer_app_insights_key", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformProperty<string> Endpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("endpoint");
        set => SetProperty("endpoint", value);
    }

    /// <summary>
    /// The icon_url attribute.
    /// </summary>
    public TerraformProperty<string> IconUrl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("icon_url");
        set => SetProperty("icon_url", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The microsoft_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MicrosoftAppId is required")]
    public required TerraformProperty<string> MicrosoftAppId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("microsoft_app_id");
        set => SetProperty("microsoft_app_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> PublicNetworkAccessEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("public_network_access_enabled");
        set => SetProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformProperty<string> Sku
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sku");
        set => SetProperty("sku", value);
    }

    /// <summary>
    /// The streaming_endpoint_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> StreamingEndpointEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("streaming_endpoint_enabled");
        set => SetProperty("streaming_endpoint_enabled", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermBotChannelsRegistrationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
