using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for custom_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorFirewallPolicyCustomRuleBlock : TerraformBlock
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformProperty<string> Action
    {
        get => GetProperty<TerraformProperty<string>>("action");
        set => WithProperty("action", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformProperty<double>? Priority
    {
        get => GetProperty<TerraformProperty<double>>("priority");
        set => WithProperty("priority", value);
    }

    /// <summary>
    /// The rate_limit_duration_in_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? RateLimitDurationInMinutes
    {
        get => GetProperty<TerraformProperty<double>>("rate_limit_duration_in_minutes");
        set => WithProperty("rate_limit_duration_in_minutes", value);
    }

    /// <summary>
    /// The rate_limit_threshold attribute.
    /// </summary>
    public TerraformProperty<double>? RateLimitThreshold
    {
        get => GetProperty<TerraformProperty<double>>("rate_limit_threshold");
        set => WithProperty("rate_limit_threshold", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for log_scrubbing in .
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorFirewallPolicyLogScrubbingBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

}

/// <summary>
/// Block type for managed_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorFirewallPolicyManagedRuleBlock : TerraformBlock
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformProperty<string> Action
    {
        get => GetProperty<TerraformProperty<string>>("action");
        set => WithProperty("action", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformProperty<string> Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => WithProperty("version", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCdnFrontdoorFirewallPolicyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_cdn_frontdoor_firewall_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermCdnFrontdoorFirewallPolicy : TerraformResource
{
    public AzurermCdnFrontdoorFirewallPolicy(string name) : base("azurerm_cdn_frontdoor_firewall_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("frontend_endpoint_ids");
    }

    /// <summary>
    /// The captcha_cookie_expiration_in_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? CaptchaCookieExpirationInMinutes
    {
        get => GetProperty<TerraformProperty<double>>("captcha_cookie_expiration_in_minutes");
        set => this.WithProperty("captcha_cookie_expiration_in_minutes", value);
    }

    /// <summary>
    /// The custom_block_response_body attribute.
    /// </summary>
    public TerraformProperty<string>? CustomBlockResponseBody
    {
        get => GetProperty<TerraformProperty<string>>("custom_block_response_body");
        set => this.WithProperty("custom_block_response_body", value);
    }

    /// <summary>
    /// The custom_block_response_status_code attribute.
    /// </summary>
    public TerraformProperty<double>? CustomBlockResponseStatusCode
    {
        get => GetProperty<TerraformProperty<double>>("custom_block_response_status_code");
        set => this.WithProperty("custom_block_response_status_code", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The js_challenge_cookie_expiration_in_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? JsChallengeCookieExpirationInMinutes
    {
        get => GetProperty<TerraformProperty<double>>("js_challenge_cookie_expiration_in_minutes");
        set => this.WithProperty("js_challenge_cookie_expiration_in_minutes", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformProperty<string> Mode
    {
        get => GetProperty<TerraformProperty<string>>("mode");
        set => this.WithProperty("mode", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The redirect_url attribute.
    /// </summary>
    public TerraformProperty<string>? RedirectUrl
    {
        get => GetProperty<TerraformProperty<string>>("redirect_url");
        set => this.WithProperty("redirect_url", value);
    }

    /// <summary>
    /// The request_body_check_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? RequestBodyCheckEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("request_body_check_enabled");
        set => this.WithProperty("request_body_check_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    public required TerraformProperty<string> SkuName
    {
        get => GetProperty<TerraformProperty<string>>("sku_name");
        set => this.WithProperty("sku_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for custom_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 CustomRule block(s) allowed")]
    public List<AzurermCdnFrontdoorFirewallPolicyCustomRuleBlock>? CustomRule
    {
        get => GetProperty<List<AzurermCdnFrontdoorFirewallPolicyCustomRuleBlock>>("custom_rule");
        set => this.WithProperty("custom_rule", value);
    }

    /// <summary>
    /// Block for log_scrubbing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogScrubbing block(s) allowed")]
    public List<AzurermCdnFrontdoorFirewallPolicyLogScrubbingBlock>? LogScrubbing
    {
        get => GetProperty<List<AzurermCdnFrontdoorFirewallPolicyLogScrubbingBlock>>("log_scrubbing");
        set => this.WithProperty("log_scrubbing", value);
    }

    /// <summary>
    /// Block for managed_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 ManagedRule block(s) allowed")]
    public List<AzurermCdnFrontdoorFirewallPolicyManagedRuleBlock>? ManagedRule
    {
        get => GetProperty<List<AzurermCdnFrontdoorFirewallPolicyManagedRuleBlock>>("managed_rule");
        set => this.WithProperty("managed_rule", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermCdnFrontdoorFirewallPolicyTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermCdnFrontdoorFirewallPolicyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The frontend_endpoint_ids attribute.
    /// </summary>
    public TerraformExpression FrontendEndpointIds => this["frontend_endpoint_ids"];

}
