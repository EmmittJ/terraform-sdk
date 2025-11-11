using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermBotChannelMsTeamsTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_bot_channel_ms_teams resource.
/// </summary>
public partial class AzurermBotChannelMsTeams : TerraformResource
{
    public AzurermBotChannelMsTeams(string name) : base("azurerm_bot_channel_ms_teams", name)
    {
    }

    /// <summary>
    /// The bot_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BotName is required")]
    [TerraformProperty("bot_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> BotName { get; set; }

    /// <summary>
    /// The calling_enabled attribute.
    /// </summary>
    [TerraformProperty("calling_enabled")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> CallingEnabled { get; set; }

    /// <summary>
    /// The calling_web_hook attribute.
    /// </summary>
    [TerraformProperty("calling_web_hook")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> CallingWebHook { get; set; }

    /// <summary>
    /// The deployment_environment attribute.
    /// </summary>
    [TerraformProperty("deployment_environment")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DeploymentEnvironment { get; set; }

    /// <summary>
    /// The enable_calling attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("enable_calling")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> EnableCalling { get; set; }

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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermBotChannelMsTeamsTimeoutsBlock>? Timeouts { get; set; }

}
