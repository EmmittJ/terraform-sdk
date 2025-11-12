using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDatadogMonitorSsoConfigurationTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_datadog_monitor_sso_configuration resource.
/// </summary>
public partial class AzurermDatadogMonitorSsoConfiguration : TerraformResource
{
    public AzurermDatadogMonitorSsoConfiguration(string name) : base("azurerm_datadog_monitor_sso_configuration", name)
    {
    }

    /// <summary>
    /// The datadog_monitor_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatadogMonitorId is required")]
    [TerraformProperty("datadog_monitor_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DatadogMonitorId { get; set; }

    /// <summary>
    /// The enterprise_application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnterpriseApplicationId is required")]
    [TerraformProperty("enterprise_application_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EnterpriseApplicationId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The single_sign_on attribute.
    /// </summary>
    [TerraformProperty("single_sign_on")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SingleSignOn { get; set; }

    /// <summary>
    /// The single_sign_on_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("single_sign_on_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SingleSignOnEnabled { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermDatadogMonitorSsoConfigurationTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The login_url attribute.
    /// </summary>
    [TerraformProperty("login_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LoginUrl { get; }

}
