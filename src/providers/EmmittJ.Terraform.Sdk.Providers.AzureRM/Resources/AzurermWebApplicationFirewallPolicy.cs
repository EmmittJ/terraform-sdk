using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for custom_rules in .
/// Nesting mode: list
/// </summary>
public partial class AzurermWebApplicationFirewallPolicyCustomRulesBlock() : TerraformBlock("custom_rules")
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [TerraformProperty("action")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Action { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The group_rate_limit_by attribute.
    /// </summary>
    [TerraformProperty("group_rate_limit_by")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? GroupRateLimitBy { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    [TerraformProperty("priority")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Priority { get; set; }

    /// <summary>
    /// The rate_limit_duration attribute.
    /// </summary>
    [TerraformProperty("rate_limit_duration")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RateLimitDuration { get; set; }

    /// <summary>
    /// The rate_limit_threshold attribute.
    /// </summary>
    [TerraformProperty("rate_limit_threshold")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? RateLimitThreshold { get; set; }

    /// <summary>
    /// The rule_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleType is required")]
    [TerraformProperty("rule_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RuleType { get; set; }

}

/// <summary>
/// Block type for managed_rules in .
/// Nesting mode: list
/// </summary>
public partial class AzurermWebApplicationFirewallPolicyManagedRulesBlock() : TerraformBlock("managed_rules")
{
}

/// <summary>
/// Block type for policy_settings in .
/// Nesting mode: list
/// </summary>
public partial class AzurermWebApplicationFirewallPolicyPolicySettingsBlock() : TerraformBlock("policy_settings")
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The file_upload_enforcement attribute.
    /// </summary>
    [TerraformProperty("file_upload_enforcement")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> FileUploadEnforcement { get; set; }

    /// <summary>
    /// The file_upload_limit_in_mb attribute.
    /// </summary>
    [TerraformProperty("file_upload_limit_in_mb")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? FileUploadLimitInMb { get; set; }

    /// <summary>
    /// The js_challenge_cookie_expiration_in_minutes attribute.
    /// </summary>
    [TerraformProperty("js_challenge_cookie_expiration_in_minutes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? JsChallengeCookieExpirationInMinutes { get; set; }

    /// <summary>
    /// The max_request_body_size_in_kb attribute.
    /// </summary>
    [TerraformProperty("max_request_body_size_in_kb")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxRequestBodySizeInKb { get; set; }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformProperty("mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Mode { get; set; }

    /// <summary>
    /// The request_body_check attribute.
    /// </summary>
    [TerraformProperty("request_body_check")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RequestBodyCheck { get; set; }

    /// <summary>
    /// The request_body_enforcement attribute.
    /// </summary>
    [TerraformProperty("request_body_enforcement")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RequestBodyEnforcement { get; set; }

    /// <summary>
    /// The request_body_inspect_limit_in_kb attribute.
    /// </summary>
    [TerraformProperty("request_body_inspect_limit_in_kb")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? RequestBodyInspectLimitInKb { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermWebApplicationFirewallPolicyTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_web_application_firewall_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermWebApplicationFirewallPolicy : TerraformResource
{
    public AzurermWebApplicationFirewallPolicy(string name) : base("azurerm_web_application_firewall_policy", name)
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
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for custom_rules.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("custom_rules")]
    public TerraformList<AzurermWebApplicationFirewallPolicyCustomRulesBlock> CustomRules { get; set; } = new();

    /// <summary>
    /// Block for managed_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedRules is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ManagedRules block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagedRules block(s) allowed")]
    [TerraformProperty("managed_rules")]
    public required TerraformList<AzurermWebApplicationFirewallPolicyManagedRulesBlock> ManagedRules { get; set; } = new();

    /// <summary>
    /// Block for policy_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PolicySettings block(s) allowed")]
    [TerraformProperty("policy_settings")]
    public TerraformList<AzurermWebApplicationFirewallPolicyPolicySettingsBlock> PolicySettings { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermWebApplicationFirewallPolicyTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The http_listener_ids attribute.
    /// </summary>
    [TerraformProperty("http_listener_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> HttpListenerIds { get; }

    /// <summary>
    /// The path_based_rule_ids attribute.
    /// </summary>
    [TerraformProperty("path_based_rule_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> PathBasedRuleIds { get; }

}
