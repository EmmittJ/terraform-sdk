using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for actions in .
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorRuleActionsBlock : TerraformBlock
{
}

/// <summary>
/// Block type for conditions in .
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorRuleConditionsBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCdnFrontdoorRuleTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_cdn_frontdoor_rule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermCdnFrontdoorRule : TerraformResource
{
    public AzurermCdnFrontdoorRule(string name) : base("azurerm_cdn_frontdoor_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("cdn_frontdoor_rule_set_name");
        SetOutput("behavior_on_match");
        SetOutput("cdn_frontdoor_rule_set_id");
        SetOutput("id");
        SetOutput("name");
        SetOutput("order");
    }

    /// <summary>
    /// The behavior_on_match attribute.
    /// </summary>
    public TerraformProperty<string> BehaviorOnMatch
    {
        get => GetRequiredOutput<TerraformProperty<string>>("behavior_on_match");
        set => SetProperty("behavior_on_match", value);
    }

    /// <summary>
    /// The cdn_frontdoor_rule_set_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorRuleSetId is required")]
    public required TerraformProperty<string> CdnFrontdoorRuleSetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cdn_frontdoor_rule_set_id");
        set => SetProperty("cdn_frontdoor_rule_set_id", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Order is required")]
    public required TerraformProperty<double> Order
    {
        get => GetRequiredOutput<TerraformProperty<double>>("order");
        set => SetProperty("order", value);
    }

    /// <summary>
    /// Block for actions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Actions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Actions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Actions block(s) allowed")]
    public List<AzurermCdnFrontdoorRuleActionsBlock>? Actions
    {
        set => SetProperty("actions", value);
    }

    /// <summary>
    /// Block for conditions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Conditions block(s) allowed")]
    public List<AzurermCdnFrontdoorRuleConditionsBlock>? Conditions
    {
        set => SetProperty("conditions", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermCdnFrontdoorRuleTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The cdn_frontdoor_rule_set_name attribute.
    /// </summary>
    public TerraformExpression CdnFrontdoorRuleSetName => this["cdn_frontdoor_rule_set_name"];

}
