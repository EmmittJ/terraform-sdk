using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for datadog_organization in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDatadogMonitorDatadogOrganizationBlock() : TerraformBlock("datadog_organization")
{
    /// <summary>
    /// The api_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiKey is required")]
    [TerraformProperty("api_key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ApiKey { get; set; }

    /// <summary>
    /// The application_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationKey is required")]
    [TerraformProperty("application_key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ApplicationKey { get; set; }

    /// <summary>
    /// The enterprise_app_id attribute.
    /// </summary>
    [TerraformProperty("enterprise_app_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EnterpriseAppId { get; set; }


    /// <summary>
    /// The linking_auth_code attribute.
    /// </summary>
    [TerraformProperty("linking_auth_code")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LinkingAuthCode { get; set; }

    /// <summary>
    /// The linking_client_id attribute.
    /// </summary>
    [TerraformProperty("linking_client_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LinkingClientId { get; set; }


    /// <summary>
    /// The redirect_uri attribute.
    /// </summary>
    [TerraformProperty("redirect_uri")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RedirectUri { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDatadogMonitorIdentityBlock() : TerraformBlock("identity")
{


    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDatadogMonitorTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Block type for user in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDatadogMonitorUserBlock() : TerraformBlock("user")
{
    /// <summary>
    /// The email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    [TerraformProperty("email")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Email { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    [TerraformProperty("phone_number")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PhoneNumber { get; set; }

}

/// <summary>
/// Manages a azurerm_datadog_monitor resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermDatadogMonitor : TerraformResource
{
    public AzurermDatadogMonitor(string name) : base("azurerm_datadog_monitor", name)
    {
    }

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
    /// The monitoring_enabled attribute.
    /// </summary>
    [TerraformProperty("monitoring_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? MonitoringEnabled { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    [TerraformProperty("sku_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SkuName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for datadog_organization.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatadogOrganization is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DatadogOrganization block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DatadogOrganization block(s) allowed")]
    [TerraformProperty("datadog_organization")]
    public required TerraformList<AzurermDatadogMonitorDatadogOrganizationBlock> DatadogOrganization { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<AzurermDatadogMonitorIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermDatadogMonitorTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for user.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "User is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 User block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 User block(s) allowed")]
    [TerraformProperty("user")]
    public required TerraformList<AzurermDatadogMonitorUserBlock> User { get; set; } = new();

    /// <summary>
    /// The marketplace_subscription_status attribute.
    /// </summary>
    [TerraformProperty("marketplace_subscription_status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MarketplaceSubscriptionStatus { get; }

}
