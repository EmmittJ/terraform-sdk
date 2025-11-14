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
/// Block type for custom_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorFirewallPolicyCustomRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_rule";

    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [TerraformArgument("action")]
    public required TerraformValue<string> Action
    {
        get => new TerraformReference<string>(this, "action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformArgument("enabled")]
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
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
    /// The priority attribute.
    /// </summary>
    [TerraformArgument("priority")]
    public TerraformValue<double>? Priority
    {
        get => new TerraformReference<double>(this, "priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The rate_limit_duration_in_minutes attribute.
    /// </summary>
    [TerraformArgument("rate_limit_duration_in_minutes")]
    public TerraformValue<double>? RateLimitDurationInMinutes
    {
        get => new TerraformReference<double>(this, "rate_limit_duration_in_minutes");
        set => SetArgument("rate_limit_duration_in_minutes", value);
    }

    /// <summary>
    /// The rate_limit_threshold attribute.
    /// </summary>
    [TerraformArgument("rate_limit_threshold")]
    public TerraformValue<double>? RateLimitThreshold
    {
        get => new TerraformReference<double>(this, "rate_limit_threshold");
        set => SetArgument("rate_limit_threshold", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for log_scrubbing in .
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorFirewallPolicyLogScrubbingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "log_scrubbing";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformArgument("enabled")]
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for managed_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorFirewallPolicyManagedRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "managed_rule";

    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [TerraformArgument("action")]
    public required TerraformValue<string> Action
    {
        get => new TerraformReference<string>(this, "action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformArgument("version")]
    public required TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCdnFrontdoorFirewallPolicyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
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
    }

    /// <summary>
    /// The captcha_cookie_expiration_in_minutes attribute.
    /// </summary>
    [TerraformArgument("captcha_cookie_expiration_in_minutes")]
    public TerraformValue<double> CaptchaCookieExpirationInMinutes
    {
        get => new TerraformReference<double>(this, "captcha_cookie_expiration_in_minutes");
        set => SetArgument("captcha_cookie_expiration_in_minutes", value);
    }

    /// <summary>
    /// The custom_block_response_body attribute.
    /// </summary>
    [TerraformArgument("custom_block_response_body")]
    public TerraformValue<string>? CustomBlockResponseBody
    {
        get => new TerraformReference<string>(this, "custom_block_response_body");
        set => SetArgument("custom_block_response_body", value);
    }

    /// <summary>
    /// The custom_block_response_status_code attribute.
    /// </summary>
    [TerraformArgument("custom_block_response_status_code")]
    public TerraformValue<double>? CustomBlockResponseStatusCode
    {
        get => new TerraformReference<double>(this, "custom_block_response_status_code");
        set => SetArgument("custom_block_response_status_code", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformArgument("enabled")]
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
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
    /// The js_challenge_cookie_expiration_in_minutes attribute.
    /// </summary>
    [TerraformArgument("js_challenge_cookie_expiration_in_minutes")]
    public TerraformValue<double> JsChallengeCookieExpirationInMinutes
    {
        get => new TerraformReference<double>(this, "js_challenge_cookie_expiration_in_minutes");
        set => SetArgument("js_challenge_cookie_expiration_in_minutes", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    [TerraformArgument("mode")]
    public required TerraformValue<string> Mode
    {
        get => new TerraformReference<string>(this, "mode");
        set => SetArgument("mode", value);
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
    /// The redirect_url attribute.
    /// </summary>
    [TerraformArgument("redirect_url")]
    public TerraformValue<string>? RedirectUrl
    {
        get => new TerraformReference<string>(this, "redirect_url");
        set => SetArgument("redirect_url", value);
    }

    /// <summary>
    /// The request_body_check_enabled attribute.
    /// </summary>
    [TerraformArgument("request_body_check_enabled")]
    public TerraformValue<bool>? RequestBodyCheckEnabled
    {
        get => new TerraformReference<bool>(this, "request_body_check_enabled");
        set => SetArgument("request_body_check_enabled", value);
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
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    [TerraformArgument("sku_name")]
    public required TerraformValue<string> SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
        set => SetArgument("sku_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for custom_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 CustomRule block(s) allowed")]
    [TerraformArgument("custom_rule")]
    public TerraformList<AzurermCdnFrontdoorFirewallPolicyCustomRuleBlock> CustomRule { get; set; } = new();

    /// <summary>
    /// Block for log_scrubbing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogScrubbing block(s) allowed")]
    [TerraformArgument("log_scrubbing")]
    public TerraformList<AzurermCdnFrontdoorFirewallPolicyLogScrubbingBlock> LogScrubbing { get; set; } = new();

    /// <summary>
    /// Block for managed_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 ManagedRule block(s) allowed")]
    [TerraformArgument("managed_rule")]
    public TerraformList<AzurermCdnFrontdoorFirewallPolicyManagedRuleBlock> ManagedRule { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermCdnFrontdoorFirewallPolicyTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The frontend_endpoint_ids attribute.
    /// </summary>
    [TerraformArgument("frontend_endpoint_ids")]
    public TerraformList<string> FrontendEndpointIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "frontend_endpoint_ids").ResolveNodes(ctx));
    }

}
