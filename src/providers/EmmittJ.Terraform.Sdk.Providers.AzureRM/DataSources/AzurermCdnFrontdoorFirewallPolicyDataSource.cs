using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Represents a azurerm_cdn_frontdoor_firewall_policy Terraform data source.
/// Retrieves information about a azurerm_cdn_frontdoor_firewall_policy.
/// </summary>
public partial class AzurermCdnFrontdoorFirewallPolicyDataSource(string name) : TerraformDataSource("azurerm_cdn_frontdoor_firewall_policy", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The captcha_cookie_expiration_in_minutes attribute.
    /// </summary>
    public TerraformValue<double> CaptchaCookieExpirationInMinutes
    {
        get => new TerraformReference<double>(this, "captcha_cookie_expiration_in_minutes");
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
    }

    /// <summary>
    /// The frontend_endpoint_ids attribute.
    /// </summary>
    public TerraformList<string> FrontendEndpointIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "frontend_endpoint_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The js_challenge_cookie_expiration_in_minutes attribute.
    /// </summary>
    public TerraformValue<double> JsChallengeCookieExpirationInMinutes
    {
        get => new TerraformReference<double>(this, "js_challenge_cookie_expiration_in_minutes");
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformValue<string> Mode
    {
        get => new TerraformReference<string>(this, "mode");
    }

    /// <summary>
    /// The redirect_url attribute.
    /// </summary>
    public TerraformValue<string> RedirectUrl
    {
        get => new TerraformReference<string>(this, "redirect_url");
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformValue<string> SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermCdnFrontdoorFirewallPolicyDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermCdnFrontdoorFirewallPolicyDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
