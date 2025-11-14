using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCdnFrontdoorFirewallPolicyDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

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
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermCdnFrontdoorFirewallPolicyDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The captcha_cookie_expiration_in_minutes attribute.
    /// </summary>
    [TerraformArgument("captcha_cookie_expiration_in_minutes")]
    public TerraformValue<double> CaptchaCookieExpirationInMinutes
    {
        get => new TerraformReference<double>(this, "captcha_cookie_expiration_in_minutes");
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformArgument("enabled")]
    public TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
    }

    /// <summary>
    /// The frontend_endpoint_ids attribute.
    /// </summary>
    [TerraformArgument("frontend_endpoint_ids")]
    public TerraformList<string> FrontendEndpointIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "frontend_endpoint_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The js_challenge_cookie_expiration_in_minutes attribute.
    /// </summary>
    [TerraformArgument("js_challenge_cookie_expiration_in_minutes")]
    public TerraformValue<double> JsChallengeCookieExpirationInMinutes
    {
        get => new TerraformReference<double>(this, "js_challenge_cookie_expiration_in_minutes");
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformArgument("mode")]
    public TerraformValue<string> Mode
    {
        get => new TerraformReference<string>(this, "mode");
    }

    /// <summary>
    /// The redirect_url attribute.
    /// </summary>
    [TerraformArgument("redirect_url")]
    public TerraformValue<string> RedirectUrl
    {
        get => new TerraformReference<string>(this, "redirect_url");
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformArgument("sku_name")]
    public TerraformValue<string> SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
    }

}
