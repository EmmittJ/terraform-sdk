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
        this.WithOutput("cdn_frontdoor_rule_set_name");
    }

    /// <summary>
    /// The behavior_on_match attribute.
    /// </summary>
    public TerraformProperty<string>? BehaviorOnMatch
    {
        get => GetProperty<TerraformProperty<string>>("behavior_on_match");
        set => this.WithProperty("behavior_on_match", value);
    }

    /// <summary>
    /// The cdn_frontdoor_rule_set_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorRuleSetId is required")]
    public required TerraformProperty<string> CdnFrontdoorRuleSetId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("cdn_frontdoor_rule_set_id");
        set => this.WithProperty("cdn_frontdoor_rule_set_id", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Order is required")]
    public required TerraformProperty<double> Order
    {
        get => GetRequiredProperty<TerraformProperty<double>>("order");
        set => this.WithProperty("order", value);
    }

    /// <summary>
    /// Block for actions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Actions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Actions block(s) allowed")]
    public List<AzurermCdnFrontdoorRuleActionsBlock>? Actions
    {
        get => GetProperty<List<AzurermCdnFrontdoorRuleActionsBlock>>("actions");
        set => this.WithProperty("actions", value);
    }

    /// <summary>
    /// Block for conditions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Conditions block(s) allowed")]
    public List<AzurermCdnFrontdoorRuleConditionsBlock>? Conditions
    {
        get => GetProperty<List<AzurermCdnFrontdoorRuleConditionsBlock>>("conditions");
        set => this.WithProperty("conditions", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermCdnFrontdoorRuleTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermCdnFrontdoorRuleTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The cdn_frontdoor_rule_set_name attribute.
    /// </summary>
    public TerraformExpression CdnFrontdoorRuleSetName => this["cdn_frontdoor_rule_set_name"];

}
