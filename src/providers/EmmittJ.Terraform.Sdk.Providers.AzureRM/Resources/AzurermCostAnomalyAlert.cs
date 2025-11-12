using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermCostAnomalyAlertTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_cost_anomaly_alert resource.
/// </summary>
public partial class AzurermCostAnomalyAlert : TerraformResource
{
    public AzurermCostAnomalyAlert(string name) : base("azurerm_cost_anomaly_alert", name)
    {
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The email_addresses attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailAddresses is required")]
    [TerraformProperty("email_addresses")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> EmailAddresses { get; set; }

    /// <summary>
    /// The email_subject attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailSubject is required")]
    [TerraformProperty("email_subject")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EmailSubject { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The message attribute.
    /// </summary>
    [TerraformProperty("message")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Message { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The notification_email attribute.
    /// </summary>
    [TerraformProperty("notification_email")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NotificationEmail { get; set; }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    [TerraformProperty("subscription_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SubscriptionId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermCostAnomalyAlertTimeoutsBlock Timeouts { get; set; } = new();

}
