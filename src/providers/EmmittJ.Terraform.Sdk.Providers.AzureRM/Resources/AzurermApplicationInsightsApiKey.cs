using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermApplicationInsightsApiKeyTimeoutsBlock : TerraformBlockBase
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

}

/// <summary>
/// Manages a azurerm_application_insights_api_key resource.
/// </summary>
public partial class AzurermApplicationInsightsApiKey : TerraformResource
{
    public AzurermApplicationInsightsApiKey(string name) : base("azurerm_application_insights_api_key", name)
    {
    }

    /// <summary>
    /// The application_insights_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationInsightsId is required")]
    [TerraformProperty("application_insights_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ApplicationInsightsId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The read_permissions attribute.
    /// </summary>
    [TerraformProperty("read_permissions")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? ReadPermissions { get; set; }

    /// <summary>
    /// The write_permissions attribute.
    /// </summary>
    [TerraformProperty("write_permissions")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? WritePermissions { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermApplicationInsightsApiKeyTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The api_key attribute.
    /// </summary>
    [TerraformProperty("api_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ApiKey { get; }

}
