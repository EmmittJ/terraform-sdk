using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for custom_rules in .
/// Nesting mode: list
/// </summary>
public class AzurermWebApplicationFirewallPolicyCustomRulesBlock
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [TerraformPropertyName("action")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Action { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The group_rate_limit_by attribute.
    /// </summary>
    [TerraformPropertyName("group_rate_limit_by")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? GroupRateLimitBy { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    [TerraformPropertyName("priority")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Priority { get; set; }

    /// <summary>
    /// The rate_limit_duration attribute.
    /// </summary>
    [TerraformPropertyName("rate_limit_duration")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RateLimitDuration { get; set; }

    /// <summary>
    /// The rate_limit_threshold attribute.
    /// </summary>
    [TerraformPropertyName("rate_limit_threshold")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? RateLimitThreshold { get; set; }

    /// <summary>
    /// The rule_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleType is required")]
    [TerraformPropertyName("rule_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RuleType { get; set; }

}

/// <summary>
/// Block type for managed_rules in .
/// Nesting mode: list
/// </summary>
public class AzurermWebApplicationFirewallPolicyManagedRulesBlock
{
}

/// <summary>
/// Block type for policy_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermWebApplicationFirewallPolicyPolicySettingsBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The file_upload_enforcement attribute.
    /// </summary>
    [TerraformPropertyName("file_upload_enforcement")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> FileUploadEnforcement { get; set; } = default!;

    /// <summary>
    /// The file_upload_limit_in_mb attribute.
    /// </summary>
    [TerraformPropertyName("file_upload_limit_in_mb")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? FileUploadLimitInMb { get; set; }

    /// <summary>
    /// The js_challenge_cookie_expiration_in_minutes attribute.
    /// </summary>
    [TerraformPropertyName("js_challenge_cookie_expiration_in_minutes")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? JsChallengeCookieExpirationInMinutes { get; set; }

    /// <summary>
    /// The max_request_body_size_in_kb attribute.
    /// </summary>
    [TerraformPropertyName("max_request_body_size_in_kb")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxRequestBodySizeInKb { get; set; }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformPropertyName("mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Mode { get; set; }

    /// <summary>
    /// The request_body_check attribute.
    /// </summary>
    [TerraformPropertyName("request_body_check")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RequestBodyCheck { get; set; }

    /// <summary>
    /// The request_body_enforcement attribute.
    /// </summary>
    [TerraformPropertyName("request_body_enforcement")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RequestBodyEnforcement { get; set; }

    /// <summary>
    /// The request_body_inspect_limit_in_kb attribute.
    /// </summary>
    [TerraformPropertyName("request_body_inspect_limit_in_kb")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? RequestBodyInspectLimitInKb { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermWebApplicationFirewallPolicyTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_web_application_firewall_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermWebApplicationFirewallPolicy : TerraformResource
{
    public AzurermWebApplicationFirewallPolicy(string name) : base("azurerm_web_application_firewall_policy", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for custom_rules.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("custom_rules")]
    public TerraformList<TerraformBlock<AzurermWebApplicationFirewallPolicyCustomRulesBlock>>? CustomRules { get; set; }

    /// <summary>
    /// Block for managed_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedRules is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ManagedRules block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagedRules block(s) allowed")]
    [TerraformPropertyName("managed_rules")]
    public TerraformList<TerraformBlock<AzurermWebApplicationFirewallPolicyManagedRulesBlock>>? ManagedRules { get; set; }

    /// <summary>
    /// Block for policy_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PolicySettings block(s) allowed")]
    [TerraformPropertyName("policy_settings")]
    public TerraformList<TerraformBlock<AzurermWebApplicationFirewallPolicyPolicySettingsBlock>>? PolicySettings { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermWebApplicationFirewallPolicyTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The http_listener_ids attribute.
    /// </summary>
    [TerraformPropertyName("http_listener_ids")]
    // Output-only attribute - read-only reference
    public TerraformList<string> HttpListenerIds => new TerraformReference(this, "http_listener_ids");

    /// <summary>
    /// The path_based_rule_ids attribute.
    /// </summary>
    [TerraformPropertyName("path_based_rule_ids")]
    // Output-only attribute - read-only reference
    public TerraformList<string> PathBasedRuleIds => new TerraformReference(this, "path_based_rule_ids");

}
