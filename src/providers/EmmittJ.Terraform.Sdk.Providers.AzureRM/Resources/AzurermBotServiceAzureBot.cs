using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermBotServiceAzureBotTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_bot_service_azure_bot resource.
/// </summary>
public partial class AzurermBotServiceAzureBot : TerraformResource
{
    public AzurermBotServiceAzureBot(string name) : base("azurerm_bot_service_azure_bot", name)
    {
    }

    /// <summary>
    /// The cmk_key_vault_key_url attribute.
    /// </summary>
    [TerraformProperty("cmk_key_vault_key_url")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CmkKeyVaultKeyUrl { get; set; }

    /// <summary>
    /// The developer_app_insights_api_key attribute.
    /// </summary>
    [TerraformProperty("developer_app_insights_api_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeveloperAppInsightsApiKey { get; set; }

    /// <summary>
    /// The developer_app_insights_application_id attribute.
    /// </summary>
    [TerraformProperty("developer_app_insights_application_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeveloperAppInsightsApplicationId { get; set; }

    /// <summary>
    /// The developer_app_insights_key attribute.
    /// </summary>
    [TerraformProperty("developer_app_insights_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeveloperAppInsightsKey { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Endpoint { get; set; }

    /// <summary>
    /// The icon_url attribute.
    /// </summary>
    [TerraformProperty("icon_url")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IconUrl { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The local_authentication_enabled attribute.
    /// </summary>
    [TerraformProperty("local_authentication_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? LocalAuthenticationEnabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The luis_app_ids attribute.
    /// </summary>
    [TerraformProperty("luis_app_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? LuisAppIds { get; set; }

    /// <summary>
    /// The luis_key attribute.
    /// </summary>
    [TerraformProperty("luis_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LuisKey { get; set; }

    /// <summary>
    /// The microsoft_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MicrosoftAppId is required")]
    [TerraformProperty("microsoft_app_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MicrosoftAppId { get; set; }

    /// <summary>
    /// The microsoft_app_msi_id attribute.
    /// </summary>
    [TerraformProperty("microsoft_app_msi_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MicrosoftAppMsiId { get; set; }

    /// <summary>
    /// The microsoft_app_tenant_id attribute.
    /// </summary>
    [TerraformProperty("microsoft_app_tenant_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MicrosoftAppTenantId { get; set; }

    /// <summary>
    /// The microsoft_app_type attribute.
    /// </summary>
    [TerraformProperty("microsoft_app_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MicrosoftAppType { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformProperty("public_network_access_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [TerraformProperty("sku")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Sku { get; set; }

    /// <summary>
    /// The streaming_endpoint_enabled attribute.
    /// </summary>
    [TerraformProperty("streaming_endpoint_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? StreamingEndpointEnabled { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermBotServiceAzureBotTimeoutsBlock Timeouts { get; set; } = new();

}
