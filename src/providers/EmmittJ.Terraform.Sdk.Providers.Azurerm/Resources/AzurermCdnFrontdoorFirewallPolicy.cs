using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for custom_rule in AzurermCdnFrontdoorFirewallPolicy.
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
    public required TerraformValue<string> Action
    {
        get => new TerraformReference<string>(this, "action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
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
    /// The priority attribute.
    /// </summary>
    public TerraformValue<double>? Priority
    {
        get => new TerraformReference<double>(this, "priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The rate_limit_duration_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? RateLimitDurationInMinutes
    {
        get => new TerraformReference<double>(this, "rate_limit_duration_in_minutes");
        set => SetArgument("rate_limit_duration_in_minutes", value);
    }

    /// <summary>
    /// The rate_limit_threshold attribute.
    /// </summary>
    public TerraformValue<double>? RateLimitThreshold
    {
        get => new TerraformReference<double>(this, "rate_limit_threshold");
        set => SetArgument("rate_limit_threshold", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// MatchCondition block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 MatchCondition block(s) allowed")]
    public TerraformList<AzurermCdnFrontdoorFirewallPolicyCustomRuleBlockMatchConditionBlock>? MatchCondition
    {
        get => GetArgument<TerraformList<AzurermCdnFrontdoorFirewallPolicyCustomRuleBlockMatchConditionBlock>>("match_condition");
        set => SetArgument("match_condition", value);
    }

}

/// <summary>
/// Block type for match_condition in AzurermCdnFrontdoorFirewallPolicyCustomRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorFirewallPolicyCustomRuleBlockMatchConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "match_condition";

    /// <summary>
    /// The match_values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MatchValues is required")]
    public TerraformList<string>? MatchValues
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "match_values").ResolveNodes(ctx));
        set => SetArgument("match_values", value);
    }

    /// <summary>
    /// The match_variable attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MatchVariable is required")]
    public required TerraformValue<string> MatchVariable
    {
        get => new TerraformReference<string>(this, "match_variable");
        set => SetArgument("match_variable", value);
    }

    /// <summary>
    /// The negation_condition attribute.
    /// </summary>
    public TerraformValue<bool>? NegationCondition
    {
        get => new TerraformReference<bool>(this, "negation_condition");
        set => SetArgument("negation_condition", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => new TerraformReference<string>(this, "operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The selector attribute.
    /// </summary>
    public TerraformValue<string>? Selector
    {
        get => new TerraformReference<string>(this, "selector");
        set => SetArgument("selector", value);
    }

    /// <summary>
    /// The transforms attribute.
    /// </summary>
    public TerraformList<string>? Transforms
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "transforms").ResolveNodes(ctx));
        set => SetArgument("transforms", value);
    }

}


/// <summary>
/// Block type for log_scrubbing in AzurermCdnFrontdoorFirewallPolicy.
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
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// ScrubbingRule block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScrubbingRule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ScrubbingRule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 ScrubbingRule block(s) allowed")]
    public required TerraformList<AzurermCdnFrontdoorFirewallPolicyLogScrubbingBlockScrubbingRuleBlock> ScrubbingRule
    {
        get => GetRequiredArgument<TerraformList<AzurermCdnFrontdoorFirewallPolicyLogScrubbingBlockScrubbingRuleBlock>>("scrubbing_rule");
        set => SetArgument("scrubbing_rule", value);
    }

}

/// <summary>
/// Block type for scrubbing_rule in AzurermCdnFrontdoorFirewallPolicyLogScrubbingBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorFirewallPolicyLogScrubbingBlockScrubbingRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scrubbing_rule";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The match_variable attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MatchVariable is required")]
    public required TerraformValue<string> MatchVariable
    {
        get => new TerraformReference<string>(this, "match_variable");
        set => SetArgument("match_variable", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    public TerraformValue<string>? OperatorAttribute
    {
        get => new TerraformReference<string>(this, "operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The selector attribute.
    /// </summary>
    public TerraformValue<string>? Selector
    {
        get => new TerraformReference<string>(this, "selector");
        set => SetArgument("selector", value);
    }

}


/// <summary>
/// Block type for managed_rule in AzurermCdnFrontdoorFirewallPolicy.
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
    public required TerraformValue<string> Action
    {
        get => new TerraformReference<string>(this, "action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// Exclusion block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 Exclusion block(s) allowed")]
    public TerraformList<AzurermCdnFrontdoorFirewallPolicyManagedRuleBlockExclusionBlock>? Exclusion
    {
        get => GetArgument<TerraformList<AzurermCdnFrontdoorFirewallPolicyManagedRuleBlockExclusionBlock>>("exclusion");
        set => SetArgument("exclusion", value);
    }

    /// <summary>
    /// OverrideAttribute block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 OverrideAttribute block(s) allowed")]
    public TerraformList<AzurermCdnFrontdoorFirewallPolicyManagedRuleBlockOverrideAttributeBlock>? OverrideAttribute
    {
        get => GetArgument<TerraformList<AzurermCdnFrontdoorFirewallPolicyManagedRuleBlockOverrideAttributeBlock>>("override");
        set => SetArgument("override", value);
    }

}

/// <summary>
/// Block type for exclusion in AzurermCdnFrontdoorFirewallPolicyManagedRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorFirewallPolicyManagedRuleBlockExclusionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "exclusion";

    /// <summary>
    /// The match_variable attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MatchVariable is required")]
    public required TerraformValue<string> MatchVariable
    {
        get => new TerraformReference<string>(this, "match_variable");
        set => SetArgument("match_variable", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => new TerraformReference<string>(this, "operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The selector attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Selector is required")]
    public required TerraformValue<string> Selector
    {
        get => new TerraformReference<string>(this, "selector");
        set => SetArgument("selector", value);
    }

}

/// <summary>
/// Block type for override in AzurermCdnFrontdoorFirewallPolicyManagedRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorFirewallPolicyManagedRuleBlockOverrideAttributeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "override";

    /// <summary>
    /// The rule_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleGroupName is required")]
    public required TerraformValue<string> RuleGroupName
    {
        get => new TerraformReference<string>(this, "rule_group_name");
        set => SetArgument("rule_group_name", value);
    }

    /// <summary>
    /// Exclusion block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 Exclusion block(s) allowed")]
    public TerraformList<AzurermCdnFrontdoorFirewallPolicyManagedRuleBlockOverrideAttributeBlockExclusionBlock>? Exclusion
    {
        get => GetArgument<TerraformList<AzurermCdnFrontdoorFirewallPolicyManagedRuleBlockOverrideAttributeBlockExclusionBlock>>("exclusion");
        set => SetArgument("exclusion", value);
    }

    /// <summary>
    /// Rule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1000, ErrorMessage = "Maximum 1000 Rule block(s) allowed")]
    public TerraformList<AzurermCdnFrontdoorFirewallPolicyManagedRuleBlockOverrideAttributeBlockRuleBlock>? Rule
    {
        get => GetArgument<TerraformList<AzurermCdnFrontdoorFirewallPolicyManagedRuleBlockOverrideAttributeBlockRuleBlock>>("rule");
        set => SetArgument("rule", value);
    }

}

/// <summary>
/// Block type for exclusion in AzurermCdnFrontdoorFirewallPolicyManagedRuleBlockOverrideAttributeBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorFirewallPolicyManagedRuleBlockOverrideAttributeBlockExclusionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "exclusion";

    /// <summary>
    /// The match_variable attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MatchVariable is required")]
    public required TerraformValue<string> MatchVariable
    {
        get => new TerraformReference<string>(this, "match_variable");
        set => SetArgument("match_variable", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => new TerraformReference<string>(this, "operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The selector attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Selector is required")]
    public required TerraformValue<string> Selector
    {
        get => new TerraformReference<string>(this, "selector");
        set => SetArgument("selector", value);
    }

}

/// <summary>
/// Block type for rule in AzurermCdnFrontdoorFirewallPolicyManagedRuleBlockOverrideAttributeBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorFirewallPolicyManagedRuleBlockOverrideAttributeBlockRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rule";

    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformValue<string> Action
    {
        get => new TerraformReference<string>(this, "action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The rule_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleId is required")]
    public required TerraformValue<string> RuleId
    {
        get => new TerraformReference<string>(this, "rule_id");
        set => SetArgument("rule_id", value);
    }

    /// <summary>
    /// Exclusion block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 Exclusion block(s) allowed")]
    public TerraformList<AzurermCdnFrontdoorFirewallPolicyManagedRuleBlockOverrideAttributeBlockRuleBlockExclusionBlock>? Exclusion
    {
        get => GetArgument<TerraformList<AzurermCdnFrontdoorFirewallPolicyManagedRuleBlockOverrideAttributeBlockRuleBlockExclusionBlock>>("exclusion");
        set => SetArgument("exclusion", value);
    }

}

/// <summary>
/// Block type for exclusion in AzurermCdnFrontdoorFirewallPolicyManagedRuleBlockOverrideAttributeBlockRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorFirewallPolicyManagedRuleBlockOverrideAttributeBlockRuleBlockExclusionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "exclusion";

    /// <summary>
    /// The match_variable attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MatchVariable is required")]
    public required TerraformValue<string> MatchVariable
    {
        get => new TerraformReference<string>(this, "match_variable");
        set => SetArgument("match_variable", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => new TerraformReference<string>(this, "operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The selector attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Selector is required")]
    public required TerraformValue<string> Selector
    {
        get => new TerraformReference<string>(this, "selector");
        set => SetArgument("selector", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermCdnFrontdoorFirewallPolicy.
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
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_cdn_frontdoor_firewall_policy Terraform resource.
/// Manages a azurerm_cdn_frontdoor_firewall_policy resource.
/// </summary>
public partial class AzurermCdnFrontdoorFirewallPolicy(string name) : TerraformResource("azurerm_cdn_frontdoor_firewall_policy", name)
{
    /// <summary>
    /// The captcha_cookie_expiration_in_minutes attribute.
    /// </summary>
    public TerraformValue<double> CaptchaCookieExpirationInMinutes
    {
        get => new TerraformReference<double>(this, "captcha_cookie_expiration_in_minutes");
        set => SetArgument("captcha_cookie_expiration_in_minutes", value);
    }

    /// <summary>
    /// The custom_block_response_body attribute.
    /// </summary>
    public TerraformValue<string>? CustomBlockResponseBody
    {
        get => new TerraformReference<string>(this, "custom_block_response_body");
        set => SetArgument("custom_block_response_body", value);
    }

    /// <summary>
    /// The custom_block_response_status_code attribute.
    /// </summary>
    public TerraformValue<double>? CustomBlockResponseStatusCode
    {
        get => new TerraformReference<double>(this, "custom_block_response_status_code");
        set => SetArgument("custom_block_response_status_code", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The js_challenge_cookie_expiration_in_minutes attribute.
    /// </summary>
    public TerraformValue<double> JsChallengeCookieExpirationInMinutes
    {
        get => new TerraformReference<double>(this, "js_challenge_cookie_expiration_in_minutes");
        set => SetArgument("js_challenge_cookie_expiration_in_minutes", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformValue<string> Mode
    {
        get => new TerraformReference<string>(this, "mode");
        set => SetArgument("mode", value);
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
    /// The redirect_url attribute.
    /// </summary>
    public TerraformValue<string>? RedirectUrl
    {
        get => new TerraformReference<string>(this, "redirect_url");
        set => SetArgument("redirect_url", value);
    }

    /// <summary>
    /// The request_body_check_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? RequestBodyCheckEnabled
    {
        get => new TerraformReference<bool>(this, "request_body_check_enabled");
        set => SetArgument("request_body_check_enabled", value);
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
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    public required TerraformValue<string> SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
        set => SetArgument("sku_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The frontend_endpoint_ids attribute.
    /// </summary>
    public TerraformList<string> FrontendEndpointIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "frontend_endpoint_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// CustomRule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 CustomRule block(s) allowed")]
    public TerraformList<AzurermCdnFrontdoorFirewallPolicyCustomRuleBlock>? CustomRule
    {
        get => GetArgument<TerraformList<AzurermCdnFrontdoorFirewallPolicyCustomRuleBlock>>("custom_rule");
        set => SetArgument("custom_rule", value);
    }

    /// <summary>
    /// LogScrubbing block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogScrubbing block(s) allowed")]
    public TerraformList<AzurermCdnFrontdoorFirewallPolicyLogScrubbingBlock>? LogScrubbing
    {
        get => GetArgument<TerraformList<AzurermCdnFrontdoorFirewallPolicyLogScrubbingBlock>>("log_scrubbing");
        set => SetArgument("log_scrubbing", value);
    }

    /// <summary>
    /// ManagedRule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 ManagedRule block(s) allowed")]
    public TerraformList<AzurermCdnFrontdoorFirewallPolicyManagedRuleBlock>? ManagedRule
    {
        get => GetArgument<TerraformList<AzurermCdnFrontdoorFirewallPolicyManagedRuleBlock>>("managed_rule");
        set => SetArgument("managed_rule", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermCdnFrontdoorFirewallPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermCdnFrontdoorFirewallPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
