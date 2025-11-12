using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for site in .
/// Nesting mode: set
/// </summary>
public partial class AzurermBotChannelDirectlineSiteBlock() : TerraformBlock("site")
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The endpoint_parameters_enabled attribute.
    /// </summary>
    [TerraformProperty("endpoint_parameters_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EndpointParametersEnabled { get; set; }

    /// <summary>
    /// The enhanced_authentication_enabled attribute.
    /// </summary>
    [TerraformProperty("enhanced_authentication_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnhancedAuthenticationEnabled { get; set; }




    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The storage_enabled attribute.
    /// </summary>
    [TerraformProperty("storage_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? StorageEnabled { get; set; }

    /// <summary>
    /// The trusted_origins attribute.
    /// </summary>
    [TerraformProperty("trusted_origins")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? TrustedOrigins { get; set; }

    /// <summary>
    /// The user_upload_enabled attribute.
    /// </summary>
    [TerraformProperty("user_upload_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? UserUploadEnabled { get; set; }

    /// <summary>
    /// The v1_allowed attribute.
    /// </summary>
    [TerraformProperty("v1_allowed")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? V1Allowed { get; set; }

    /// <summary>
    /// The v3_allowed attribute.
    /// </summary>
    [TerraformProperty("v3_allowed")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? V3Allowed { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermBotChannelDirectlineTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_bot_channel_directline resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermBotChannelDirectline : TerraformResource
{
    public AzurermBotChannelDirectline(string name) : base("azurerm_bot_channel_directline", name)
    {
    }

    /// <summary>
    /// The bot_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BotName is required")]
    [TerraformProperty("bot_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BotName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for site.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Site is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Site block(s) required")]
    [TerraformProperty("site")]
    public required TerraformSet<AzurermBotChannelDirectlineSiteBlock> Site { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermBotChannelDirectlineTimeoutsBlock Timeouts { get; set; } = new();

}
