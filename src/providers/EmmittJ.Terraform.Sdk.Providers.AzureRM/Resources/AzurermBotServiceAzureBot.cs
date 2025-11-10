using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermBotServiceAzureBotTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_bot_service_azure_bot resource.
/// </summary>
public class AzurermBotServiceAzureBot : TerraformResource
{
    public AzurermBotServiceAzureBot(string name) : base("azurerm_bot_service_azure_bot", name)
    {
    }

    /// <summary>
    /// The cmk_key_vault_key_url attribute.
    /// </summary>
    [TerraformPropertyName("cmk_key_vault_key_url")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CmkKeyVaultKeyUrl { get; set; }

    /// <summary>
    /// The developer_app_insights_api_key attribute.
    /// </summary>
    [TerraformPropertyName("developer_app_insights_api_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DeveloperAppInsightsApiKey { get; set; }

    /// <summary>
    /// The developer_app_insights_application_id attribute.
    /// </summary>
    [TerraformPropertyName("developer_app_insights_application_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DeveloperAppInsightsApplicationId { get; set; }

    /// <summary>
    /// The developer_app_insights_key attribute.
    /// </summary>
    [TerraformPropertyName("developer_app_insights_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DeveloperAppInsightsKey { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DisplayName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Endpoint { get; set; }

    /// <summary>
    /// The icon_url attribute.
    /// </summary>
    [TerraformPropertyName("icon_url")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IconUrl { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The local_authentication_enabled attribute.
    /// </summary>
    [TerraformPropertyName("local_authentication_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? LocalAuthenticationEnabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The luis_app_ids attribute.
    /// </summary>
    [TerraformPropertyName("luis_app_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? LuisAppIds { get; set; }

    /// <summary>
    /// The luis_key attribute.
    /// </summary>
    [TerraformPropertyName("luis_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LuisKey { get; set; }

    /// <summary>
    /// The microsoft_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MicrosoftAppId is required")]
    [TerraformPropertyName("microsoft_app_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> MicrosoftAppId { get; set; }

    /// <summary>
    /// The microsoft_app_msi_id attribute.
    /// </summary>
    [TerraformPropertyName("microsoft_app_msi_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MicrosoftAppMsiId { get; set; }

    /// <summary>
    /// The microsoft_app_tenant_id attribute.
    /// </summary>
    [TerraformPropertyName("microsoft_app_tenant_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MicrosoftAppTenantId { get; set; }

    /// <summary>
    /// The microsoft_app_type attribute.
    /// </summary>
    [TerraformPropertyName("microsoft_app_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MicrosoftAppType { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("public_network_access_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [TerraformPropertyName("sku")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Sku { get; set; }

    /// <summary>
    /// The streaming_endpoint_enabled attribute.
    /// </summary>
    [TerraformPropertyName("streaming_endpoint_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? StreamingEndpointEnabled { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermBotServiceAzureBotTimeoutsBlock>? Timeouts { get; set; } = new();

}
