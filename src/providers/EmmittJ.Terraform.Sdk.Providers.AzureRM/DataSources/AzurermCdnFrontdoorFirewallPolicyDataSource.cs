using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCdnFrontdoorFirewallPolicyDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_cdn_frontdoor_firewall_policy.
/// </summary>
public class AzurermCdnFrontdoorFirewallPolicyDataSource : TerraformDataSource
{
    public AzurermCdnFrontdoorFirewallPolicyDataSource(string name) : base("azurerm_cdn_frontdoor_firewall_policy", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermCdnFrontdoorFirewallPolicyDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The captcha_cookie_expiration_in_minutes attribute.
    /// </summary>
    [TerraformPropertyName("captcha_cookie_expiration_in_minutes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> CaptchaCookieExpirationInMinutes => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "captcha_cookie_expiration_in_minutes");

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Enabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enabled");

    /// <summary>
    /// The frontend_endpoint_ids attribute.
    /// </summary>
    [TerraformPropertyName("frontend_endpoint_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> FrontendEndpointIds => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "frontend_endpoint_ids");

    /// <summary>
    /// The js_challenge_cookie_expiration_in_minutes attribute.
    /// </summary>
    [TerraformPropertyName("js_challenge_cookie_expiration_in_minutes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> JsChallengeCookieExpirationInMinutes => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "js_challenge_cookie_expiration_in_minutes");

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformPropertyName("mode")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Mode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "mode");

    /// <summary>
    /// The redirect_url attribute.
    /// </summary>
    [TerraformPropertyName("redirect_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RedirectUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "redirect_url");

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformPropertyName("sku_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SkuName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sku_name");

}
