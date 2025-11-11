using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSentinelDataConnectorOffice365TimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_sentinel_data_connector_office_365 resource.
/// </summary>
public partial class AzurermSentinelDataConnectorOffice365 : TerraformResource
{
    public AzurermSentinelDataConnectorOffice365(string name) : base("azurerm_sentinel_data_connector_office_365", name)
    {
    }

    /// <summary>
    /// The exchange_enabled attribute.
    /// </summary>
    [TerraformProperty("exchange_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ExchangeEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    [TerraformProperty("log_analytics_workspace_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> LogAnalyticsWorkspaceId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The sharepoint_enabled attribute.
    /// </summary>
    [TerraformProperty("sharepoint_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? SharepointEnabled { get; set; }

    /// <summary>
    /// The teams_enabled attribute.
    /// </summary>
    [TerraformProperty("teams_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? TeamsEnabled { get; set; }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformProperty("tenant_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> TenantId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermSentinelDataConnectorOffice365TimeoutsBlock>? Timeouts { get; set; }

}
