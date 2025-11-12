using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermCdnFrontdoorFirewallPolicyDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_cdn_frontdoor_firewall_policy.
/// </summary>
public partial class AzurermCdnFrontdoorFirewallPolicyDataSource : TerraformDataSource
{
    public AzurermCdnFrontdoorFirewallPolicyDataSource(string name) : base("azurerm_cdn_frontdoor_firewall_policy", name)
    {
    }

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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermCdnFrontdoorFirewallPolicyDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The captcha_cookie_expiration_in_minutes attribute.
    /// </summary>
    [TerraformProperty("captcha_cookie_expiration_in_minutes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> CaptchaCookieExpirationInMinutes { get; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Enabled { get; }

    /// <summary>
    /// The frontend_endpoint_ids attribute.
    /// </summary>
    [TerraformProperty("frontend_endpoint_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> FrontendEndpointIds { get; }

    /// <summary>
    /// The js_challenge_cookie_expiration_in_minutes attribute.
    /// </summary>
    [TerraformProperty("js_challenge_cookie_expiration_in_minutes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> JsChallengeCookieExpirationInMinutes { get; }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformProperty("mode")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Mode { get; }

    /// <summary>
    /// The redirect_url attribute.
    /// </summary>
    [TerraformProperty("redirect_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RedirectUrl { get; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformProperty("sku_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SkuName { get; }

}
