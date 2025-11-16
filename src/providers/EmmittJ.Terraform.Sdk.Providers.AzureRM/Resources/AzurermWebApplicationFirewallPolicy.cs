using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    /// The group_rate_limit_by attribute.
    /// </summary>
    public TerraformValue<string>? GroupRateLimitBy
    {
        get => new TerraformReference<string>(this, "group_rate_limit_by");
        set => SetArgument("group_rate_limit_by", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformValue<double> Priority
    {
        get => new TerraformReference<double>(this, "priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The rate_limit_duration attribute.
    /// </summary>
    public TerraformValue<string>? RateLimitDuration
    {
        get => new TerraformReference<string>(this, "rate_limit_duration");
        set => SetArgument("rate_limit_duration", value);
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
    /// The rule_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleType is required")]
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
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The file_upload_enforcement attribute.
    /// </summary>
    public TerraformValue<bool> FileUploadEnforcement
    {
        get => new TerraformReference<bool>(this, "file_upload_enforcement");
        set => SetArgument("file_upload_enforcement", value);
    }

    /// <summary>
    /// The file_upload_limit_in_mb attribute.
    /// </summary>
    public TerraformValue<double>? FileUploadLimitInMb
    {
        get => new TerraformReference<double>(this, "file_upload_limit_in_mb");
        set => SetArgument("file_upload_limit_in_mb", value);
    }

    /// <summary>
    /// The js_challenge_cookie_expiration_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? JsChallengeCookieExpirationInMinutes
    {
        get => new TerraformReference<double>(this, "js_challenge_cookie_expiration_in_minutes");
        set => SetArgument("js_challenge_cookie_expiration_in_minutes", value);
    }

    /// <summary>
    /// The max_request_body_size_in_kb attribute.
    /// </summary>
    public TerraformValue<double>? MaxRequestBodySizeInKb
    {
        get => new TerraformReference<double>(this, "max_request_body_size_in_kb");
        set => SetArgument("max_request_body_size_in_kb", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformValue<string>? Mode
    {
        get => new TerraformReference<string>(this, "mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The request_body_check attribute.
    /// </summary>
    public TerraformValue<bool>? RequestBodyCheck
    {
        get => new TerraformReference<bool>(this, "request_body_check");
        set => SetArgument("request_body_check", value);
    }

    /// <summary>
    /// The request_body_enforcement attribute.
    /// </summary>
    public TerraformValue<bool>? RequestBodyEnforcement
    {
        get => new TerraformReference<bool>(this, "request_body_enforcement");
        set => SetArgument("request_body_enforcement", value);
    }

    /// <summary>
    /// The request_body_inspect_limit_in_kb attribute.
    /// </summary>
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
/// Represents a azurerm_web_application_firewall_policy Terraform resource.
/// Manages a azurerm_web_application_firewall_policy resource.
/// </summary>
public partial class AzurermWebApplicationFirewallPolicy(string name) : TerraformResource("azurerm_web_application_firewall_policy", name)
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// CustomRules block (nesting mode: list).
    /// </summary>
    public AzurermWebApplicationFirewallPolicyCustomRulesBlock? CustomRules
    {
        get => GetArgument<AzurermWebApplicationFirewallPolicyCustomRulesBlock>("custom_rules");
        set => SetArgument("custom_rules", value);
    }

    /// <summary>
    /// ManagedRules block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedRules is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ManagedRules block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagedRules block(s) allowed")]
    public required AzurermWebApplicationFirewallPolicyManagedRulesBlock ManagedRules
    {
        get => GetRequiredArgument<AzurermWebApplicationFirewallPolicyManagedRulesBlock>("managed_rules");
        set => SetArgument("managed_rules", value);
    }

    /// <summary>
    /// PolicySettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PolicySettings block(s) allowed")]
    public AzurermWebApplicationFirewallPolicyPolicySettingsBlock? PolicySettings
    {
        get => GetArgument<AzurermWebApplicationFirewallPolicyPolicySettingsBlock>("policy_settings");
        set => SetArgument("policy_settings", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermWebApplicationFirewallPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermWebApplicationFirewallPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
