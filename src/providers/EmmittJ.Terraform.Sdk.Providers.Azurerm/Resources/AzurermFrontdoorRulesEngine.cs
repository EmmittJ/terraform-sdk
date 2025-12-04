using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for rule in AzurermFrontdoorRulesEngine.
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorRulesEngineRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rule";

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformValue<double> Priority
    {
        get => GetArgument<TerraformValue<double>>("priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// Action block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Action block(s) allowed")]
    public TerraformList<AzurermFrontdoorRulesEngineRuleBlockActionBlock>? Action
    {
        get => GetArgument<TerraformList<AzurermFrontdoorRulesEngineRuleBlockActionBlock>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// MatchCondition block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 MatchCondition block(s) allowed")]
    public TerraformList<AzurermFrontdoorRulesEngineRuleBlockMatchConditionBlock>? MatchCondition
    {
        get => GetArgument<TerraformList<AzurermFrontdoorRulesEngineRuleBlockMatchConditionBlock>>("match_condition");
        set => SetArgument("match_condition", value);
    }

}

/// <summary>
/// Block type for action in AzurermFrontdoorRulesEngineRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorRulesEngineRuleBlockActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action";

    /// <summary>
    /// RequestHeader block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 RequestHeader block(s) allowed")]
    public TerraformList<AzurermFrontdoorRulesEngineRuleBlockActionBlockRequestHeaderBlock>? RequestHeader
    {
        get => GetArgument<TerraformList<AzurermFrontdoorRulesEngineRuleBlockActionBlockRequestHeaderBlock>>("request_header");
        set => SetArgument("request_header", value);
    }

    /// <summary>
    /// ResponseHeader block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 ResponseHeader block(s) allowed")]
    public TerraformList<AzurermFrontdoorRulesEngineRuleBlockActionBlockResponseHeaderBlock>? ResponseHeader
    {
        get => GetArgument<TerraformList<AzurermFrontdoorRulesEngineRuleBlockActionBlockResponseHeaderBlock>>("response_header");
        set => SetArgument("response_header", value);
    }

}

/// <summary>
/// Block type for request_header in AzurermFrontdoorRulesEngineRuleBlockActionBlock.
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorRulesEngineRuleBlockActionBlockRequestHeaderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_header";

    /// <summary>
    /// The header_action_type attribute.
    /// </summary>
    public TerraformValue<string>? HeaderActionType
    {
        get => GetArgument<TerraformValue<string>>("header_action_type");
        set => SetArgument("header_action_type", value);
    }

    /// <summary>
    /// The header_name attribute.
    /// </summary>
    public TerraformValue<string>? HeaderName
    {
        get => GetArgument<TerraformValue<string>>("header_name");
        set => SetArgument("header_name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for response_header in AzurermFrontdoorRulesEngineRuleBlockActionBlock.
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorRulesEngineRuleBlockActionBlockResponseHeaderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "response_header";

    /// <summary>
    /// The header_action_type attribute.
    /// </summary>
    public TerraformValue<string>? HeaderActionType
    {
        get => GetArgument<TerraformValue<string>>("header_action_type");
        set => SetArgument("header_action_type", value);
    }

    /// <summary>
    /// The header_name attribute.
    /// </summary>
    public TerraformValue<string>? HeaderName
    {
        get => GetArgument<TerraformValue<string>>("header_name");
        set => SetArgument("header_name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for match_condition in AzurermFrontdoorRulesEngineRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorRulesEngineRuleBlockMatchConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "match_condition";

    /// <summary>
    /// The negate_condition attribute.
    /// </summary>
    public TerraformValue<bool>? NegateCondition
    {
        get => GetArgument<TerraformValue<bool>>("negate_condition");
        set => SetArgument("negate_condition", value);
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
    /// The transform attribute.
    /// </summary>
    public TerraformList<string>? Transform
    {
        get => GetArgument<TerraformList<string>>("transform");
        set => SetArgument("transform", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformList<string>? Value
    {
        get => GetArgument<TerraformList<string>>("value");
        set => SetArgument("value", value);
    }

    /// <summary>
    /// The variable attribute.
    /// </summary>
    public TerraformValue<string>? Variable
    {
        get => GetArgument<TerraformValue<string>>("variable");
        set => SetArgument("variable", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermFrontdoorRulesEngine.
/// Nesting mode: single
/// </summary>
public class AzurermFrontdoorRulesEngineTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_frontdoor_rules_engine Terraform resource.
/// Manages a azurerm_frontdoor_rules_engine resource.
/// </summary>
public partial class AzurermFrontdoorRulesEngine(string name) : TerraformResource("azurerm_frontdoor_rules_engine", name)
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The frontdoor_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontdoorName is required")]
    public required TerraformValue<string> FrontdoorName
    {
        get => GetArgument<TerraformValue<string>>("frontdoor_name");
        set => SetArgument("frontdoor_name", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// Rule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 Rule block(s) allowed")]
    public TerraformList<AzurermFrontdoorRulesEngineRuleBlock>? Rule
    {
        get => GetArgument<TerraformList<AzurermFrontdoorRulesEngineRuleBlock>>("rule");
        set => SetArgument("rule", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermFrontdoorRulesEngineTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermFrontdoorRulesEngineTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
