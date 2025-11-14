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
/// Block type for actions in .
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorRuleActionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "actions";

}

/// <summary>
/// Block type for conditions in .
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorRuleConditionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "conditions";

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCdnFrontdoorRuleTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_cdn_frontdoor_rule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermCdnFrontdoorRule : TerraformResource
{
    public AzurermCdnFrontdoorRule(string name) : base("azurerm_cdn_frontdoor_rule", name)
    {
    }

    /// <summary>
    /// The behavior_on_match attribute.
    /// </summary>
    [TerraformArgument("behavior_on_match")]
    public TerraformValue<string>? BehaviorOnMatch
    {
        get => new TerraformReference<string>(this, "behavior_on_match");
        set => SetArgument("behavior_on_match", value);
    }

    /// <summary>
    /// The cdn_frontdoor_rule_set_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorRuleSetId is required")]
    [TerraformArgument("cdn_frontdoor_rule_set_id")]
    public required TerraformValue<string> CdnFrontdoorRuleSetId
    {
        get => new TerraformReference<string>(this, "cdn_frontdoor_rule_set_id");
        set => SetArgument("cdn_frontdoor_rule_set_id", value);
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
    /// The order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Order is required")]
    [TerraformArgument("order")]
    public required TerraformValue<double> Order
    {
        get => new TerraformReference<double>(this, "order");
        set => SetArgument("order", value);
    }

    /// <summary>
    /// Block for actions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Actions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Actions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Actions block(s) allowed")]
    [TerraformArgument("actions")]
    public required TerraformList<AzurermCdnFrontdoorRuleActionsBlock> Actions { get; set; } = new();

    /// <summary>
    /// Block for conditions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Conditions block(s) allowed")]
    [TerraformArgument("conditions")]
    public TerraformList<AzurermCdnFrontdoorRuleConditionsBlock> Conditions { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermCdnFrontdoorRuleTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The cdn_frontdoor_rule_set_name attribute.
    /// </summary>
    [TerraformArgument("cdn_frontdoor_rule_set_name")]
    public TerraformValue<string> CdnFrontdoorRuleSetName
    {
        get => new TerraformReference<string>(this, "cdn_frontdoor_rule_set_name");
    }

}
