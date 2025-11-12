using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSentinelAlertRuleMsSecurityIncidentTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_sentinel_alert_rule_ms_security_incident resource.
/// </summary>
public partial class AzurermSentinelAlertRuleMsSecurityIncident : TerraformResource
{
    public AzurermSentinelAlertRuleMsSecurityIncident(string name) : base("azurerm_sentinel_alert_rule_ms_security_incident", name)
    {
    }

    /// <summary>
    /// The alert_rule_template_guid attribute.
    /// </summary>
    [TerraformProperty("alert_rule_template_guid")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AlertRuleTemplateGuid { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The display_name_exclude_filter attribute.
    /// </summary>
    [TerraformProperty("display_name_exclude_filter")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? DisplayNameExcludeFilter { get; set; }

    /// <summary>
    /// The display_name_filter attribute.
    /// </summary>
    [TerraformProperty("display_name_filter")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? DisplayNameFilter { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The product_filter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProductFilter is required")]
    [TerraformProperty("product_filter")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ProductFilter { get; set; }

    /// <summary>
    /// The severity_filter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SeverityFilter is required")]
    [TerraformProperty("severity_filter")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> SeverityFilter { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermSentinelAlertRuleMsSecurityIncidentTimeoutsBlock Timeouts { get; set; } = new();

}
