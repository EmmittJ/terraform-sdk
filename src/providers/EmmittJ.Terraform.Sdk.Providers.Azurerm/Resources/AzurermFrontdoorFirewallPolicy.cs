using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for custom_rule in AzurermFrontdoorFirewallPolicy.
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorFirewallPolicyCustomRuleBlock : TerraformBlock
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformValue<double>? Priority
    {
        get => GetArgument<TerraformValue<double>>("priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The rate_limit_duration_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? RateLimitDurationInMinutes
    {
        get => GetArgument<TerraformValue<double>>("rate_limit_duration_in_minutes");
        set => SetArgument("rate_limit_duration_in_minutes", value);
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
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// MatchCondition block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 MatchCondition block(s) allowed")]
    public TerraformList<AzurermFrontdoorFirewallPolicyCustomRuleBlockMatchConditionBlock>? MatchCondition
    {
        get => GetArgument<TerraformList<AzurermFrontdoorFirewallPolicyCustomRuleBlockMatchConditionBlock>>("match_condition");
        set => SetArgument("match_condition", value);
    }

}

/// <summary>
/// Block type for match_condition in AzurermFrontdoorFirewallPolicyCustomRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorFirewallPolicyCustomRuleBlockMatchConditionBlock : TerraformBlock
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
        get => GetArgument<TerraformList<string>>("match_values");
        set => SetArgument("match_values", value);
    }

    /// <summary>
    /// The match_variable attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MatchVariable is required")]
    public required TerraformValue<string> MatchVariable
    {
        get => GetArgument<TerraformValue<string>>("match_variable");
        set => SetArgument("match_variable", value);
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
        get => GetArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The selector attribute.
    /// </summary>
    public TerraformValue<string>? Selector
    {
        get => GetArgument<TerraformValue<string>>("selector");
        set => SetArgument("selector", value);
    }

    /// <summary>
    /// The transforms attribute.
    /// </summary>
    public TerraformList<string>? Transforms
    {
        get => GetArgument<TerraformList<string>>("transforms");
        set => SetArgument("transforms", value);
    }

}


/// <summary>
/// Block type for managed_rule in AzurermFrontdoorFirewallPolicy.
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorFirewallPolicyManagedRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "managed_rule";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
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
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// Exclusion block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 Exclusion block(s) allowed")]
    public TerraformList<AzurermFrontdoorFirewallPolicyManagedRuleBlockExclusionBlock>? Exclusion
    {
        get => GetArgument<TerraformList<AzurermFrontdoorFirewallPolicyManagedRuleBlockExclusionBlock>>("exclusion");
        set => SetArgument("exclusion", value);
    }

    /// <summary>
    /// OverrideAttribute block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 OverrideAttribute block(s) allowed")]
    public TerraformList<AzurermFrontdoorFirewallPolicyManagedRuleBlockOverrideAttributeBlock>? OverrideAttribute
    {
        get => GetArgument<TerraformList<AzurermFrontdoorFirewallPolicyManagedRuleBlockOverrideAttributeBlock>>("override");
        set => SetArgument("override", value);
    }

}

/// <summary>
/// Block type for exclusion in AzurermFrontdoorFirewallPolicyManagedRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorFirewallPolicyManagedRuleBlockExclusionBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("match_variable");
        set => SetArgument("match_variable", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => GetArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The selector attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Selector is required")]
    public required TerraformValue<string> Selector
    {
        get => GetArgument<TerraformValue<string>>("selector");
        set => SetArgument("selector", value);
    }

}

/// <summary>
/// Block type for override in AzurermFrontdoorFirewallPolicyManagedRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorFirewallPolicyManagedRuleBlockOverrideAttributeBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("rule_group_name");
        set => SetArgument("rule_group_name", value);
    }

    /// <summary>
    /// Exclusion block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 Exclusion block(s) allowed")]
    public TerraformList<AzurermFrontdoorFirewallPolicyManagedRuleBlockOverrideAttributeBlockExclusionBlock>? Exclusion
    {
        get => GetArgument<TerraformList<AzurermFrontdoorFirewallPolicyManagedRuleBlockOverrideAttributeBlockExclusionBlock>>("exclusion");
        set => SetArgument("exclusion", value);
    }

    /// <summary>
    /// Rule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1000, ErrorMessage = "Maximum 1000 Rule block(s) allowed")]
    public TerraformList<AzurermFrontdoorFirewallPolicyManagedRuleBlockOverrideAttributeBlockRuleBlock>? Rule
    {
        get => GetArgument<TerraformList<AzurermFrontdoorFirewallPolicyManagedRuleBlockOverrideAttributeBlockRuleBlock>>("rule");
        set => SetArgument("rule", value);
    }

}

/// <summary>
/// Block type for exclusion in AzurermFrontdoorFirewallPolicyManagedRuleBlockOverrideAttributeBlock.
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorFirewallPolicyManagedRuleBlockOverrideAttributeBlockExclusionBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("match_variable");
        set => SetArgument("match_variable", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => GetArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The selector attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Selector is required")]
    public required TerraformValue<string> Selector
    {
        get => GetArgument<TerraformValue<string>>("selector");
        set => SetArgument("selector", value);
    }

}

/// <summary>
/// Block type for rule in AzurermFrontdoorFirewallPolicyManagedRuleBlockOverrideAttributeBlock.
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorFirewallPolicyManagedRuleBlockOverrideAttributeBlockRuleBlock : TerraformBlock
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
    /// The rule_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleId is required")]
    public required TerraformValue<string> RuleId
    {
        get => GetArgument<TerraformValue<string>>("rule_id");
        set => SetArgument("rule_id", value);
    }

    /// <summary>
    /// Exclusion block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 Exclusion block(s) allowed")]
    public TerraformList<AzurermFrontdoorFirewallPolicyManagedRuleBlockOverrideAttributeBlockRuleBlockExclusionBlock>? Exclusion
    {
        get => GetArgument<TerraformList<AzurermFrontdoorFirewallPolicyManagedRuleBlockOverrideAttributeBlockRuleBlockExclusionBlock>>("exclusion");
        set => SetArgument("exclusion", value);
    }

}

/// <summary>
/// Block type for exclusion in AzurermFrontdoorFirewallPolicyManagedRuleBlockOverrideAttributeBlockRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorFirewallPolicyManagedRuleBlockOverrideAttributeBlockRuleBlockExclusionBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("match_variable");
        set => SetArgument("match_variable", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => GetArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The selector attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Selector is required")]
    public required TerraformValue<string> Selector
    {
        get => GetArgument<TerraformValue<string>>("selector");
        set => SetArgument("selector", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermFrontdoorFirewallPolicy.
/// Nesting mode: single
/// </summary>
public class AzurermFrontdoorFirewallPolicyTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_frontdoor_firewall_policy Terraform resource.
/// Manages a azurerm_frontdoor_firewall_policy resource.
/// </summary>
public partial class AzurermFrontdoorFirewallPolicy(string name) : TerraformResource("azurerm_frontdoor_firewall_policy", name)
{
    /// <summary>
    /// The custom_block_response_body attribute.
    /// </summary>
    public TerraformValue<string>? CustomBlockResponseBody
    {
        get => GetArgument<TerraformValue<string>>("custom_block_response_body");
        set => SetArgument("custom_block_response_body", value);
    }

    /// <summary>
    /// The custom_block_response_status_code attribute.
    /// </summary>
    public TerraformValue<double>? CustomBlockResponseStatusCode
    {
        get => GetArgument<TerraformValue<double>>("custom_block_response_status_code");
        set => SetArgument("custom_block_response_status_code", value);
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
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The redirect_url attribute.
    /// </summary>
    public TerraformValue<string>? RedirectUrl
    {
        get => GetArgument<TerraformValue<string>>("redirect_url");
        set => SetArgument("redirect_url", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
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
    /// The frontend_endpoint_ids attribute.
    /// </summary>
    public TerraformList<string> FrontendEndpointIds
        => AsReference("frontend_endpoint_ids");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// CustomRule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 CustomRule block(s) allowed")]
    public TerraformList<AzurermFrontdoorFirewallPolicyCustomRuleBlock>? CustomRule
    {
        get => GetArgument<TerraformList<AzurermFrontdoorFirewallPolicyCustomRuleBlock>>("custom_rule");
        set => SetArgument("custom_rule", value);
    }

    /// <summary>
    /// ManagedRule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 ManagedRule block(s) allowed")]
    public TerraformList<AzurermFrontdoorFirewallPolicyManagedRuleBlock>? ManagedRule
    {
        get => GetArgument<TerraformList<AzurermFrontdoorFirewallPolicyManagedRuleBlock>>("managed_rule");
        set => SetArgument("managed_rule", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermFrontdoorFirewallPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermFrontdoorFirewallPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
