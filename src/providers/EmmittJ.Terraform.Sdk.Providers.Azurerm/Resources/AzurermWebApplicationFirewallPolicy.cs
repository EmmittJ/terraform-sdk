using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for custom_rules in AzurermWebApplicationFirewallPolicy.
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
        get => GetRequiredArgument<TerraformValue<string>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The group_rate_limit_by attribute.
    /// </summary>
    public TerraformValue<string>? GroupRateLimitBy
    {
        get => GetArgument<TerraformValue<string>>("group_rate_limit_by");
        set => SetArgument("group_rate_limit_by", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformValue<double> Priority
    {
        get => GetRequiredArgument<TerraformValue<double>>("priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The rate_limit_duration attribute.
    /// </summary>
    public TerraformValue<string>? RateLimitDuration
    {
        get => GetArgument<TerraformValue<string>>("rate_limit_duration");
        set => SetArgument("rate_limit_duration", value);
    }

    /// <summary>
    /// The rate_limit_threshold attribute.
    /// </summary>
    public TerraformValue<double>? RateLimitThreshold
    {
        get => GetArgument<TerraformValue<double>>("rate_limit_threshold");
        set => SetArgument("rate_limit_threshold", value);
    }

    /// <summary>
    /// The rule_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleType is required")]
    public required TerraformValue<string> RuleType
    {
        get => GetRequiredArgument<TerraformValue<string>>("rule_type");
        set => SetArgument("rule_type", value);
    }

    /// <summary>
    /// MatchConditions block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MatchConditions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MatchConditions block(s) required")]
    public required TerraformList<AzurermWebApplicationFirewallPolicyCustomRulesBlockMatchConditionsBlock> MatchConditions
    {
        get => GetRequiredArgument<TerraformList<AzurermWebApplicationFirewallPolicyCustomRulesBlockMatchConditionsBlock>>("match_conditions");
        set => SetArgument("match_conditions", value);
    }

}

/// <summary>
/// Block type for match_conditions in AzurermWebApplicationFirewallPolicyCustomRulesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWebApplicationFirewallPolicyCustomRulesBlockMatchConditionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "match_conditions";

    /// <summary>
    /// The match_values attribute.
    /// </summary>
    public TerraformList<string>? MatchValues
    {
        get => GetArgument<TerraformList<string>>("match_values");
        set => SetArgument("match_values", value);
    }

    /// <summary>
    /// The negation_condition attribute.
    /// </summary>
    public TerraformValue<bool>? NegationCondition
    {
        get => GetArgument<TerraformValue<bool>>("negation_condition");
        set => SetArgument("negation_condition", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The transforms attribute.
    /// </summary>
    public TerraformSet<string>? Transforms
    {
        get => GetArgument<TerraformSet<string>>("transforms");
        set => SetArgument("transforms", value);
    }

    /// <summary>
    /// MatchVariables block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MatchVariables is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MatchVariables block(s) required")]
    public required TerraformList<AzurermWebApplicationFirewallPolicyCustomRulesBlockMatchConditionsBlockMatchVariablesBlock> MatchVariables
    {
        get => GetRequiredArgument<TerraformList<AzurermWebApplicationFirewallPolicyCustomRulesBlockMatchConditionsBlockMatchVariablesBlock>>("match_variables");
        set => SetArgument("match_variables", value);
    }

}

/// <summary>
/// Block type for match_variables in AzurermWebApplicationFirewallPolicyCustomRulesBlockMatchConditionsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWebApplicationFirewallPolicyCustomRulesBlockMatchConditionsBlockMatchVariablesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "match_variables";

    /// <summary>
    /// The selector attribute.
    /// </summary>
    public TerraformValue<string>? Selector
    {
        get => GetArgument<TerraformValue<string>>("selector");
        set => SetArgument("selector", value);
    }

    /// <summary>
    /// The variable_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VariableName is required")]
    public required TerraformValue<string> VariableName
    {
        get => GetRequiredArgument<TerraformValue<string>>("variable_name");
        set => SetArgument("variable_name", value);
    }

}


/// <summary>
/// Block type for managed_rules in AzurermWebApplicationFirewallPolicy.
/// Nesting mode: list
/// </summary>
public class AzurermWebApplicationFirewallPolicyManagedRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "managed_rules";

    /// <summary>
    /// Exclusion block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermWebApplicationFirewallPolicyManagedRulesBlockExclusionBlock>? Exclusion
    {
        get => GetArgument<TerraformList<AzurermWebApplicationFirewallPolicyManagedRulesBlockExclusionBlock>>("exclusion");
        set => SetArgument("exclusion", value);
    }

    /// <summary>
    /// ManagedRuleSet block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedRuleSet is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ManagedRuleSet block(s) required")]
    public required TerraformList<AzurermWebApplicationFirewallPolicyManagedRulesBlockManagedRuleSetBlock> ManagedRuleSet
    {
        get => GetRequiredArgument<TerraformList<AzurermWebApplicationFirewallPolicyManagedRulesBlockManagedRuleSetBlock>>("managed_rule_set");
        set => SetArgument("managed_rule_set", value);
    }

}

/// <summary>
/// Block type for exclusion in AzurermWebApplicationFirewallPolicyManagedRulesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWebApplicationFirewallPolicyManagedRulesBlockExclusionBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("match_variable");
        set => SetArgument("match_variable", value);
    }

    /// <summary>
    /// The selector attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Selector is required")]
    public required TerraformValue<string> Selector
    {
        get => GetRequiredArgument<TerraformValue<string>>("selector");
        set => SetArgument("selector", value);
    }

    /// <summary>
    /// The selector_match_operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SelectorMatchOperator is required")]
    public required TerraformValue<string> SelectorMatchOperator
    {
        get => GetRequiredArgument<TerraformValue<string>>("selector_match_operator");
        set => SetArgument("selector_match_operator", value);
    }

    /// <summary>
    /// ExcludedRuleSet block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExcludedRuleSet block(s) allowed")]
    public TerraformList<AzurermWebApplicationFirewallPolicyManagedRulesBlockExclusionBlockExcludedRuleSetBlock>? ExcludedRuleSet
    {
        get => GetArgument<TerraformList<AzurermWebApplicationFirewallPolicyManagedRulesBlockExclusionBlockExcludedRuleSetBlock>>("excluded_rule_set");
        set => SetArgument("excluded_rule_set", value);
    }

}

/// <summary>
/// Block type for excluded_rule_set in AzurermWebApplicationFirewallPolicyManagedRulesBlockExclusionBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWebApplicationFirewallPolicyManagedRulesBlockExclusionBlockExcludedRuleSetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "excluded_rule_set";

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// RuleGroup block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermWebApplicationFirewallPolicyManagedRulesBlockExclusionBlockExcludedRuleSetBlockRuleGroupBlock>? RuleGroup
    {
        get => GetArgument<TerraformList<AzurermWebApplicationFirewallPolicyManagedRulesBlockExclusionBlockExcludedRuleSetBlockRuleGroupBlock>>("rule_group");
        set => SetArgument("rule_group", value);
    }

}

/// <summary>
/// Block type for rule_group in AzurermWebApplicationFirewallPolicyManagedRulesBlockExclusionBlockExcludedRuleSetBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWebApplicationFirewallPolicyManagedRulesBlockExclusionBlockExcludedRuleSetBlockRuleGroupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rule_group";

    /// <summary>
    /// The excluded_rules attribute.
    /// </summary>
    public TerraformList<string>? ExcludedRules
    {
        get => GetArgument<TerraformList<string>>("excluded_rules");
        set => SetArgument("excluded_rules", value);
    }

    /// <summary>
    /// The rule_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleGroupName is required")]
    public required TerraformValue<string> RuleGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("rule_group_name");
        set => SetArgument("rule_group_name", value);
    }

}

/// <summary>
/// Block type for managed_rule_set in AzurermWebApplicationFirewallPolicyManagedRulesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWebApplicationFirewallPolicyManagedRulesBlockManagedRuleSetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "managed_rule_set";

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformValue<string> Version
    {
        get => GetRequiredArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// RuleGroupOverride block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermWebApplicationFirewallPolicyManagedRulesBlockManagedRuleSetBlockRuleGroupOverrideBlock>? RuleGroupOverride
    {
        get => GetArgument<TerraformList<AzurermWebApplicationFirewallPolicyManagedRulesBlockManagedRuleSetBlockRuleGroupOverrideBlock>>("rule_group_override");
        set => SetArgument("rule_group_override", value);
    }

}

/// <summary>
/// Block type for rule_group_override in AzurermWebApplicationFirewallPolicyManagedRulesBlockManagedRuleSetBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWebApplicationFirewallPolicyManagedRulesBlockManagedRuleSetBlockRuleGroupOverrideBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rule_group_override";

    /// <summary>
    /// The rule_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleGroupName is required")]
    public required TerraformValue<string> RuleGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("rule_group_name");
        set => SetArgument("rule_group_name", value);
    }

    /// <summary>
    /// Rule block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermWebApplicationFirewallPolicyManagedRulesBlockManagedRuleSetBlockRuleGroupOverrideBlockRuleBlock>? Rule
    {
        get => GetArgument<TerraformList<AzurermWebApplicationFirewallPolicyManagedRulesBlockManagedRuleSetBlockRuleGroupOverrideBlockRuleBlock>>("rule");
        set => SetArgument("rule", value);
    }

}

/// <summary>
/// Block type for rule in AzurermWebApplicationFirewallPolicyManagedRulesBlockManagedRuleSetBlockRuleGroupOverrideBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWebApplicationFirewallPolicyManagedRulesBlockManagedRuleSetBlockRuleGroupOverrideBlockRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rule";

    /// <summary>
    /// The action attribute.
    /// </summary>
    public TerraformValue<string>? Action
    {
        get => GetArgument<TerraformValue<string>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetRequiredArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

}


/// <summary>
/// Block type for policy_settings in AzurermWebApplicationFirewallPolicy.
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
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The file_upload_enforcement attribute.
    /// </summary>
    public TerraformValue<bool> FileUploadEnforcement
    {
        get => GetArgument<TerraformValue<bool>>("file_upload_enforcement") ?? CreateReference("file_upload_enforcement");
        set => SetArgument("file_upload_enforcement", value);
    }

    /// <summary>
    /// The file_upload_limit_in_mb attribute.
    /// </summary>
    public TerraformValue<double>? FileUploadLimitInMb
    {
        get => GetArgument<TerraformValue<double>>("file_upload_limit_in_mb");
        set => SetArgument("file_upload_limit_in_mb", value);
    }

    /// <summary>
    /// The js_challenge_cookie_expiration_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? JsChallengeCookieExpirationInMinutes
    {
        get => GetArgument<TerraformValue<double>>("js_challenge_cookie_expiration_in_minutes");
        set => SetArgument("js_challenge_cookie_expiration_in_minutes", value);
    }

    /// <summary>
    /// The max_request_body_size_in_kb attribute.
    /// </summary>
    public TerraformValue<double>? MaxRequestBodySizeInKb
    {
        get => GetArgument<TerraformValue<double>>("max_request_body_size_in_kb");
        set => SetArgument("max_request_body_size_in_kb", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformValue<string>? Mode
    {
        get => GetArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The request_body_check attribute.
    /// </summary>
    public TerraformValue<bool>? RequestBodyCheck
    {
        get => GetArgument<TerraformValue<bool>>("request_body_check");
        set => SetArgument("request_body_check", value);
    }

    /// <summary>
    /// The request_body_enforcement attribute.
    /// </summary>
    public TerraformValue<bool>? RequestBodyEnforcement
    {
        get => GetArgument<TerraformValue<bool>>("request_body_enforcement");
        set => SetArgument("request_body_enforcement", value);
    }

    /// <summary>
    /// The request_body_inspect_limit_in_kb attribute.
    /// </summary>
    public TerraformValue<double>? RequestBodyInspectLimitInKb
    {
        get => GetArgument<TerraformValue<double>>("request_body_inspect_limit_in_kb");
        set => SetArgument("request_body_inspect_limit_in_kb", value);
    }

    /// <summary>
    /// LogScrubbing block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogScrubbing block(s) allowed")]
    public TerraformList<AzurermWebApplicationFirewallPolicyPolicySettingsBlockLogScrubbingBlock>? LogScrubbing
    {
        get => GetArgument<TerraformList<AzurermWebApplicationFirewallPolicyPolicySettingsBlockLogScrubbingBlock>>("log_scrubbing");
        set => SetArgument("log_scrubbing", value);
    }

}

/// <summary>
/// Block type for log_scrubbing in AzurermWebApplicationFirewallPolicyPolicySettingsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWebApplicationFirewallPolicyPolicySettingsBlockLogScrubbingBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// Rule block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermWebApplicationFirewallPolicyPolicySettingsBlockLogScrubbingBlockRuleBlock>? Rule
    {
        get => GetArgument<TerraformList<AzurermWebApplicationFirewallPolicyPolicySettingsBlockLogScrubbingBlockRuleBlock>>("rule");
        set => SetArgument("rule", value);
    }

}

/// <summary>
/// Block type for rule in AzurermWebApplicationFirewallPolicyPolicySettingsBlockLogScrubbingBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWebApplicationFirewallPolicyPolicySettingsBlockLogScrubbingBlockRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rule";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The match_variable attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MatchVariable is required")]
    public required TerraformValue<string> MatchVariable
    {
        get => GetRequiredArgument<TerraformValue<string>>("match_variable");
        set => SetArgument("match_variable", value);
    }

    /// <summary>
    /// When matchVariable is a collection, operator used to specify which elements in the collection this rule applies to.
    /// </summary>
    public TerraformValue<string>? Selector
    {
        get => GetArgument<TerraformValue<string>>("selector");
        set => SetArgument("selector", value);
    }

    /// <summary>
    /// The selector_match_operator attribute.
    /// </summary>
    public TerraformValue<string>? SelectorMatchOperator
    {
        get => GetArgument<TerraformValue<string>>("selector_match_operator");
        set => SetArgument("selector_match_operator", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermWebApplicationFirewallPolicy.
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The http_listener_ids attribute.
    /// </summary>
    public TerraformList<string> HttpListenerIds
        => CreateReference("http_listener_ids");

    /// <summary>
    /// The path_based_rule_ids attribute.
    /// </summary>
    public TerraformList<string> PathBasedRuleIds
        => CreateReference("path_based_rule_ids");

    /// <summary>
    /// CustomRules block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermWebApplicationFirewallPolicyCustomRulesBlock>? CustomRules
    {
        get => GetArgument<TerraformList<AzurermWebApplicationFirewallPolicyCustomRulesBlock>>("custom_rules");
        set => SetArgument("custom_rules", value);
    }

    /// <summary>
    /// ManagedRules block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedRules is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ManagedRules block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagedRules block(s) allowed")]
    public required TerraformList<AzurermWebApplicationFirewallPolicyManagedRulesBlock> ManagedRules
    {
        get => GetRequiredArgument<TerraformList<AzurermWebApplicationFirewallPolicyManagedRulesBlock>>("managed_rules");
        set => SetArgument("managed_rules", value);
    }

    /// <summary>
    /// PolicySettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PolicySettings block(s) allowed")]
    public TerraformList<AzurermWebApplicationFirewallPolicyPolicySettingsBlock>? PolicySettings
    {
        get => GetArgument<TerraformList<AzurermWebApplicationFirewallPolicyPolicySettingsBlock>>("policy_settings");
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
