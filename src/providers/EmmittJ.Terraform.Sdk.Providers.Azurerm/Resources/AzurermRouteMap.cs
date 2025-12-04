using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for rule in AzurermRouteMap.
/// Nesting mode: list
/// </summary>
public class AzurermRouteMapRuleBlock : TerraformBlock
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
    /// The next_step_if_matched attribute.
    /// </summary>
    public TerraformValue<string>? NextStepIfMatched
    {
        get => GetArgument<TerraformValue<string>>("next_step_if_matched");
        set => SetArgument("next_step_if_matched", value);
    }

    /// <summary>
    /// Action block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermRouteMapRuleBlockActionBlock>? Action
    {
        get => GetArgument<TerraformList<AzurermRouteMapRuleBlockActionBlock>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// MatchCriterion block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermRouteMapRuleBlockMatchCriterionBlock>? MatchCriterion
    {
        get => GetArgument<TerraformList<AzurermRouteMapRuleBlockMatchCriterionBlock>>("match_criterion");
        set => SetArgument("match_criterion", value);
    }

}

/// <summary>
/// Block type for action in AzurermRouteMapRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermRouteMapRuleBlockActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action";

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
    /// Parameter block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermRouteMapRuleBlockActionBlockParameterBlock>? Parameter
    {
        get => GetArgument<TerraformList<AzurermRouteMapRuleBlockActionBlockParameterBlock>>("parameter");
        set => SetArgument("parameter", value);
    }

}

/// <summary>
/// Block type for parameter in AzurermRouteMapRuleBlockActionBlock.
/// Nesting mode: list
/// </summary>
public class AzurermRouteMapRuleBlockActionBlockParameterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parameter";

    /// <summary>
    /// The as_path attribute.
    /// </summary>
    public TerraformList<string>? AsPath
    {
        get => GetArgument<TerraformList<string>>("as_path");
        set => SetArgument("as_path", value);
    }

    /// <summary>
    /// The community attribute.
    /// </summary>
    public TerraformList<string>? Community
    {
        get => GetArgument<TerraformList<string>>("community");
        set => SetArgument("community", value);
    }

    /// <summary>
    /// The route_prefix attribute.
    /// </summary>
    public TerraformList<string>? RoutePrefix
    {
        get => GetArgument<TerraformList<string>>("route_prefix");
        set => SetArgument("route_prefix", value);
    }

}

/// <summary>
/// Block type for match_criterion in AzurermRouteMapRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermRouteMapRuleBlockMatchCriterionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "match_criterion";

    /// <summary>
    /// The as_path attribute.
    /// </summary>
    public TerraformList<string>? AsPath
    {
        get => GetArgument<TerraformList<string>>("as_path");
        set => SetArgument("as_path", value);
    }

    /// <summary>
    /// The community attribute.
    /// </summary>
    public TerraformList<string>? Community
    {
        get => GetArgument<TerraformList<string>>("community");
        set => SetArgument("community", value);
    }

    /// <summary>
    /// The match_condition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MatchCondition is required")]
    public required TerraformValue<string> MatchCondition
    {
        get => GetArgument<TerraformValue<string>>("match_condition");
        set => SetArgument("match_condition", value);
    }

    /// <summary>
    /// The route_prefix attribute.
    /// </summary>
    public TerraformList<string>? RoutePrefix
    {
        get => GetArgument<TerraformList<string>>("route_prefix");
        set => SetArgument("route_prefix", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermRouteMap.
/// Nesting mode: single
/// </summary>
public class AzurermRouteMapTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_route_map Terraform resource.
/// Manages a azurerm_route_map resource.
/// </summary>
public partial class AzurermRouteMap(string name) : TerraformResource("azurerm_route_map", name)
{
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
    /// The virtual_hub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualHubId is required")]
    public required TerraformValue<string> VirtualHubId
    {
        get => GetArgument<TerraformValue<string>>("virtual_hub_id");
        set => SetArgument("virtual_hub_id", value);
    }

    /// <summary>
    /// Rule block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermRouteMapRuleBlock>? Rule
    {
        get => GetArgument<TerraformList<AzurermRouteMapRuleBlock>>("rule");
        set => SetArgument("rule", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermRouteMapTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermRouteMapTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
