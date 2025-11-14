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
/// Block type for custom_rules in .
/// Nesting mode: list
/// </summary>
public class AzurermWebApplicationFirewallPolicyCustomRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_rules";

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
    /// The group_rate_limit_by attribute.
    /// </summary>
    [TerraformArgument("group_rate_limit_by")]
    public TerraformValue<string>? GroupRateLimitBy
    {
        get => new TerraformReference<string>(this, "group_rate_limit_by");
        set => SetArgument("group_rate_limit_by", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformArgument("name")]
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    [TerraformArgument("priority")]
    public required TerraformValue<double> Priority
    {
        get => new TerraformReference<double>(this, "priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The rate_limit_duration attribute.
    /// </summary>
    [TerraformArgument("rate_limit_duration")]
    public TerraformValue<string>? RateLimitDuration
    {
        get => new TerraformReference<string>(this, "rate_limit_duration");
        set => SetArgument("rate_limit_duration", value);
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
    /// The rule_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleType is required")]
    [TerraformArgument("rule_type")]
    public required TerraformValue<string> RuleType
    {
        get => new TerraformReference<string>(this, "rule_type");
        set => SetArgument("rule_type", value);
    }

}

/// <summary>
/// Block type for managed_rules in .
/// Nesting mode: list
/// </summary>
public class AzurermWebApplicationFirewallPolicyManagedRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "managed_rules";

}

/// <summary>
/// Block type for policy_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermWebApplicationFirewallPolicyPolicySettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "policy_settings";

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
    /// The file_upload_enforcement attribute.
    /// </summary>
    [TerraformArgument("file_upload_enforcement")]
    public TerraformValue<bool> FileUploadEnforcement
    {
        get => new TerraformReference<bool>(this, "file_upload_enforcement");
        set => SetArgument("file_upload_enforcement", value);
    }

    /// <summary>
    /// The file_upload_limit_in_mb attribute.
    /// </summary>
    [TerraformArgument("file_upload_limit_in_mb")]
    public TerraformValue<double>? FileUploadLimitInMb
    {
        get => new TerraformReference<double>(this, "file_upload_limit_in_mb");
        set => SetArgument("file_upload_limit_in_mb", value);
    }

    /// <summary>
    /// The js_challenge_cookie_expiration_in_minutes attribute.
    /// </summary>
    [TerraformArgument("js_challenge_cookie_expiration_in_minutes")]
    public TerraformValue<double>? JsChallengeCookieExpirationInMinutes
    {
        get => new TerraformReference<double>(this, "js_challenge_cookie_expiration_in_minutes");
        set => SetArgument("js_challenge_cookie_expiration_in_minutes", value);
    }

    /// <summary>
    /// The max_request_body_size_in_kb attribute.
    /// </summary>
    [TerraformArgument("max_request_body_size_in_kb")]
    public TerraformValue<double>? MaxRequestBodySizeInKb
    {
        get => new TerraformReference<double>(this, "max_request_body_size_in_kb");
        set => SetArgument("max_request_body_size_in_kb", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformArgument("mode")]
    public TerraformValue<string>? Mode
    {
        get => new TerraformReference<string>(this, "mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The request_body_check attribute.
    /// </summary>
    [TerraformArgument("request_body_check")]
    public TerraformValue<bool>? RequestBodyCheck
    {
        get => new TerraformReference<bool>(this, "request_body_check");
        set => SetArgument("request_body_check", value);
    }

    /// <summary>
    /// The request_body_enforcement attribute.
    /// </summary>
    [TerraformArgument("request_body_enforcement")]
    public TerraformValue<bool>? RequestBodyEnforcement
    {
        get => new TerraformReference<bool>(this, "request_body_enforcement");
        set => SetArgument("request_body_enforcement", value);
    }

    /// <summary>
    /// The request_body_inspect_limit_in_kb attribute.
    /// </summary>
    [TerraformArgument("request_body_inspect_limit_in_kb")]
    public TerraformValue<double>? RequestBodyInspectLimitInKb
    {
        get => new TerraformReference<double>(this, "request_body_inspect_limit_in_kb");
        set => SetArgument("request_body_inspect_limit_in_kb", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermWebApplicationFirewallPolicyTimeoutsBlock : TerraformBlock
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
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for custom_rules.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("custom_rules")]
    public TerraformList<AzurermWebApplicationFirewallPolicyCustomRulesBlock> CustomRules { get; set; } = new();

    /// <summary>
    /// Block for managed_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedRules is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ManagedRules block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagedRules block(s) allowed")]
    [TerraformArgument("managed_rules")]
    public required TerraformList<AzurermWebApplicationFirewallPolicyManagedRulesBlock> ManagedRules { get; set; } = new();

    /// <summary>
    /// Block for policy_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PolicySettings block(s) allowed")]
    [TerraformArgument("policy_settings")]
    public TerraformList<AzurermWebApplicationFirewallPolicyPolicySettingsBlock> PolicySettings { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermWebApplicationFirewallPolicyTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The http_listener_ids attribute.
    /// </summary>
    [TerraformArgument("http_listener_ids")]
    public TerraformList<string> HttpListenerIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "http_listener_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The path_based_rule_ids attribute.
    /// </summary>
    [TerraformArgument("path_based_rule_ids")]
    public TerraformList<string> PathBasedRuleIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "path_based_rule_ids").ResolveNodes(ctx));
    }

}
