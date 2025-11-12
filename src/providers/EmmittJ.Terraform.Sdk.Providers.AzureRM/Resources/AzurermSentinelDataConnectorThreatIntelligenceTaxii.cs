using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSentinelDataConnectorThreatIntelligenceTaxiiTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_sentinel_data_connector_threat_intelligence_taxii resource.
/// </summary>
public partial class AzurermSentinelDataConnectorThreatIntelligenceTaxii : TerraformResource
{
    public AzurermSentinelDataConnectorThreatIntelligenceTaxii(string name) : base("azurerm_sentinel_data_connector_threat_intelligence_taxii", name)
    {
    }

    /// <summary>
    /// The api_root_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiRootUrl is required")]
    [TerraformProperty("api_root_url")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ApiRootUrl { get; set; }

    /// <summary>
    /// The collection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollectionId is required")]
    [TerraformProperty("collection_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CollectionId { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    [TerraformProperty("log_analytics_workspace_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LogAnalyticsWorkspaceId { get; set; }

    /// <summary>
    /// The lookback_date attribute.
    /// </summary>
    [TerraformProperty("lookback_date")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LookbackDate { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformProperty("password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Password { get; set; }

    /// <summary>
    /// The polling_frequency attribute.
    /// </summary>
    [TerraformProperty("polling_frequency")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PollingFrequency { get; set; }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformProperty("tenant_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> TenantId { get; set; }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [TerraformProperty("user_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UserName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermSentinelDataConnectorThreatIntelligenceTaxiiTimeoutsBlock Timeouts { get; set; } = new();

}
