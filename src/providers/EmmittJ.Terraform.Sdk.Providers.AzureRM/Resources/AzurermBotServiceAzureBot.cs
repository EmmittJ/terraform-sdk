using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermBotServiceAzureBotTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

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
    public TerraformValue<string>? CmkKeyVaultKeyUrl { get; set; }

    /// <summary>
    /// The developer_app_insights_api_key attribute.
    /// </summary>
    [TerraformPropertyName("developer_app_insights_api_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DeveloperAppInsightsApiKey { get; set; }

    /// <summary>
    /// The developer_app_insights_application_id attribute.
    /// </summary>
    [TerraformPropertyName("developer_app_insights_application_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DeveloperAppInsightsApplicationId { get; set; }

    /// <summary>
    /// The developer_app_insights_key attribute.
    /// </summary>
    [TerraformPropertyName("developer_app_insights_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DeveloperAppInsightsKey { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DisplayName { get; set; } = default!;

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Endpoint { get; set; }

    /// <summary>
    /// The icon_url attribute.
    /// </summary>
    [TerraformPropertyName("icon_url")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? IconUrl { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The local_authentication_enabled attribute.
    /// </summary>
    [TerraformPropertyName("local_authentication_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? LocalAuthenticationEnabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The luis_app_ids attribute.
    /// </summary>
    [TerraformPropertyName("luis_app_ids")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? LuisAppIds { get; set; }

    /// <summary>
    /// The luis_key attribute.
    /// </summary>
    [TerraformPropertyName("luis_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LuisKey { get; set; }

    /// <summary>
    /// The microsoft_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MicrosoftAppId is required")]
    [TerraformPropertyName("microsoft_app_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> MicrosoftAppId { get; set; }

    /// <summary>
    /// The microsoft_app_msi_id attribute.
    /// </summary>
    [TerraformPropertyName("microsoft_app_msi_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MicrosoftAppMsiId { get; set; }

    /// <summary>
    /// The microsoft_app_tenant_id attribute.
    /// </summary>
    [TerraformPropertyName("microsoft_app_tenant_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MicrosoftAppTenantId { get; set; }

    /// <summary>
    /// The microsoft_app_type attribute.
    /// </summary>
    [TerraformPropertyName("microsoft_app_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MicrosoftAppType { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("public_network_access_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [TerraformPropertyName("sku")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Sku { get; set; }

    /// <summary>
    /// The streaming_endpoint_enabled attribute.
    /// </summary>
    [TerraformPropertyName("streaming_endpoint_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? StreamingEndpointEnabled { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermBotServiceAzureBotTimeoutsBlock>? Timeouts { get; set; }

}
