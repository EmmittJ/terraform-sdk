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
        set => SetProperty("action", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The group_rate_limit_by attribute.
    /// </summary>
    public TerraformProperty<string>? GroupRateLimitBy
    {
        set => SetProperty("group_rate_limit_by", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformProperty<double> Priority
    {
        set => SetProperty("priority", value);
    }

    /// <summary>
    /// The rate_limit_duration attribute.
    /// </summary>
    public TerraformProperty<string>? RateLimitDuration
    {
        set => SetProperty("rate_limit_duration", value);
    }

    /// <summary>
    /// The rate_limit_threshold attribute.
    /// </summary>
    public TerraformProperty<double>? RateLimitThreshold
    {
        set => SetProperty("rate_limit_threshold", value);
    }

    /// <summary>
    /// The rule_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleType is required")]
    public required TerraformProperty<string> RuleType
    {
        set => SetProperty("rule_type", value);
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
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The file_upload_enforcement attribute.
    /// </summary>
    public TerraformProperty<bool>? FileUploadEnforcement
    {
        set => SetProperty("file_upload_enforcement", value);
    }

    /// <summary>
    /// The file_upload_limit_in_mb attribute.
    /// </summary>
    public TerraformProperty<double>? FileUploadLimitInMb
    {
        set => SetProperty("file_upload_limit_in_mb", value);
    }

    /// <summary>
    /// The js_challenge_cookie_expiration_in_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? JsChallengeCookieExpirationInMinutes
    {
        set => SetProperty("js_challenge_cookie_expiration_in_minutes", value);
    }

    /// <summary>
    /// The max_request_body_size_in_kb attribute.
    /// </summary>
    public TerraformProperty<double>? MaxRequestBodySizeInKb
    {
        set => SetProperty("max_request_body_size_in_kb", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformProperty<string>? Mode
    {
        set => SetProperty("mode", value);
    }

    /// <summary>
    /// The request_body_check attribute.
    /// </summary>
    public TerraformProperty<bool>? RequestBodyCheck
    {
        set => SetProperty("request_body_check", value);
    }

    /// <summary>
    /// The request_body_enforcement attribute.
    /// </summary>
    public TerraformProperty<bool>? RequestBodyEnforcement
    {
        set => SetProperty("request_body_enforcement", value);
    }

    /// <summary>
    /// The request_body_inspect_limit_in_kb attribute.
    /// </summary>
    public TerraformProperty<double>? RequestBodyInspectLimitInKb
    {
        set => SetProperty("request_body_inspect_limit_in_kb", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("http_listener_ids");
        SetOutput("path_based_rule_ids");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("tags");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for custom_rules.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermWebApplicationFirewallPolicyCustomRulesBlock>? CustomRules
    {
        set => SetProperty("custom_rules", value);
    }

    /// <summary>
    /// Block for managed_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedRules is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ManagedRules block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagedRules block(s) allowed")]
    public List<AzurermWebApplicationFirewallPolicyManagedRulesBlock>? ManagedRules
    {
        set => SetProperty("managed_rules", value);
    }

    /// <summary>
    /// Block for policy_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PolicySettings block(s) allowed")]
    public List<AzurermWebApplicationFirewallPolicyPolicySettingsBlock>? PolicySettings
    {
        set => SetProperty("policy_settings", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermWebApplicationFirewallPolicyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
