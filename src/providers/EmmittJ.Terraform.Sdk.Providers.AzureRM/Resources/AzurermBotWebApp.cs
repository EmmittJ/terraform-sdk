using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermBotWebAppTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_bot_web_app resource.
/// </summary>
public partial class AzurermBotWebApp : TerraformResource
{
    public AzurermBotWebApp(string name) : base("azurerm_bot_web_app", name)
    {
    }

    /// <summary>
    /// The developer_app_insights_api_key attribute.
    /// </summary>
    [TerraformProperty("developer_app_insights_api_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DeveloperAppInsightsApiKey { get; set; }

    /// <summary>
    /// The developer_app_insights_application_id attribute.
    /// </summary>
    [TerraformProperty("developer_app_insights_application_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DeveloperAppInsightsApplicationId { get; set; }

    /// <summary>
    /// The developer_app_insights_key attribute.
    /// </summary>
    [TerraformProperty("developer_app_insights_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DeveloperAppInsightsKey { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Endpoint { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The luis_app_ids attribute.
    /// </summary>
    [TerraformProperty("luis_app_ids")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? LuisAppIds { get; set; }

    /// <summary>
    /// The luis_key attribute.
    /// </summary>
    [TerraformProperty("luis_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? LuisKey { get; set; }

    /// <summary>
    /// The microsoft_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MicrosoftAppId is required")]
    [TerraformProperty("microsoft_app_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> MicrosoftAppId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [TerraformProperty("sku")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Sku { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermBotWebAppTimeoutsBlock>? Timeouts { get; set; }

}
