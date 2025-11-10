using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for custom_rules in .
/// Nesting mode: list
/// </summary>
public class AzurermWebApplicationFirewallPolicyCustomRulesBlock : TerraformBlock
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformProperty<string> Action
    {
        get => GetRequiredProperty<TerraformProperty<string>>("action");
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
    /// The group_rate_limit_by attribute.
    /// </summary>
    public TerraformProperty<string>? GroupRateLimitBy
    {
        get => GetProperty<TerraformProperty<string>>("group_rate_limit_by");
        set => WithProperty("group_rate_limit_by", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformProperty<double> Priority
    {
        get => GetRequiredProperty<TerraformProperty<double>>("priority");
        set => WithProperty("priority", value);
    }

    /// <summary>
    /// The rate_limit_duration attribute.
    /// </summary>
    public TerraformProperty<string>? RateLimitDuration
    {
        get => GetProperty<TerraformProperty<string>>("rate_limit_duration");
        set => WithProperty("rate_limit_duration", value);
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
    /// The rule_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleType is required")]
    public required TerraformProperty<string> RuleType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("rule_type");
        set => WithProperty("rule_type", value);
    }

}

/// <summary>
/// Block type for managed_rules in .
/// Nesting mode: list
/// </summary>
public class AzurermWebApplicationFirewallPolicyManagedRulesBlock : TerraformBlock
{
}

/// <summary>
/// Block type for policy_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermWebApplicationFirewallPolicyPolicySettingsBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The file_upload_enforcement attribute.
    /// </summary>
    public TerraformProperty<bool>? FileUploadEnforcement
    {
        get => GetProperty<TerraformProperty<bool>>("file_upload_enforcement");
        set => WithProperty("file_upload_enforcement", value);
    }

    /// <summary>
    /// The file_upload_limit_in_mb attribute.
    /// </summary>
    public TerraformProperty<double>? FileUploadLimitInMb
    {
        get => GetProperty<TerraformProperty<double>>("file_upload_limit_in_mb");
        set => WithProperty("file_upload_limit_in_mb", value);
    }

    /// <summary>
    /// The js_challenge_cookie_expiration_in_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? JsChallengeCookieExpirationInMinutes
    {
        get => GetProperty<TerraformProperty<double>>("js_challenge_cookie_expiration_in_minutes");
        set => WithProperty("js_challenge_cookie_expiration_in_minutes", value);
    }

    /// <summary>
    /// The max_request_body_size_in_kb attribute.
    /// </summary>
    public TerraformProperty<double>? MaxRequestBodySizeInKb
    {
        get => GetProperty<TerraformProperty<double>>("max_request_body_size_in_kb");
        set => WithProperty("max_request_body_size_in_kb", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformProperty<string>? Mode
    {
        get => GetProperty<TerraformProperty<string>>("mode");
        set => WithProperty("mode", value);
    }

    /// <summary>
    /// The request_body_check attribute.
    /// </summary>
    public TerraformProperty<bool>? RequestBodyCheck
    {
        get => GetProperty<TerraformProperty<bool>>("request_body_check");
        set => WithProperty("request_body_check", value);
    }

    /// <summary>
    /// The request_body_enforcement attribute.
    /// </summary>
    public TerraformProperty<bool>? RequestBodyEnforcement
    {
        get => GetProperty<TerraformProperty<bool>>("request_body_enforcement");
        set => WithProperty("request_body_enforcement", value);
    }

    /// <summary>
    /// The request_body_inspect_limit_in_kb attribute.
    /// </summary>
    public TerraformProperty<double>? RequestBodyInspectLimitInKb
    {
        get => GetProperty<TerraformProperty<double>>("request_body_inspect_limit_in_kb");
        set => WithProperty("request_body_inspect_limit_in_kb", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermWebApplicationFirewallPolicyTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_web_application_firewall_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermWebApplicationFirewallPolicy : TerraformResource
{
    public AzurermWebApplicationFirewallPolicy(string name) : base("azurerm_web_application_firewall_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutputttp_listener_ids");
        this.WithOutputath_based_rule_ids");
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
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
    /// Block for custom_rules.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermWebApplicationFirewallPolicyCustomRulesBlock>? CustomRules
    {
        get => GetProperty<List<AzurermWebApplicationFirewallPolicyCustomRulesBlock>>("custom_rules");
        set => this.WithProperty("custom_rules", value);
    }

    /// <summary>
    /// Block for managed_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ManagedRules block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagedRules block(s) allowed")]
    public List<AzurermWebApplicationFirewallPolicyManagedRulesBlock>? ManagedRules
    {
        get => GetProperty<List<AzurermWebApplicationFirewallPolicyManagedRulesBlock>>("managed_rules");
        set => this.WithProperty("managed_rules", value);
    }

    /// <summary>
    /// Block for policy_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PolicySettings block(s) allowed")]
    public List<AzurermWebApplicationFirewallPolicyPolicySettingsBlock>? PolicySettings
    {
        get => GetProperty<List<AzurermWebApplicationFirewallPolicyPolicySettingsBlock>>("policy_settings");
        set => this.WithProperty("policy_settings", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermWebApplicationFirewallPolicyTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermWebApplicationFirewallPolicyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The http_listener_ids attribute.
    /// </summary>
    public TerraformExpression HttpListenerIds => this["http_listener_ids"];

    /// <summary>
    /// The path_based_rule_ids attribute.
    /// </summary>
    public TerraformExpression PathBasedRuleIds => this["path_based_rule_ids"];

}
