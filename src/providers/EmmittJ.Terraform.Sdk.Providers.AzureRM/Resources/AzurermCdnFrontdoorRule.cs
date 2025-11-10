using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for actions in .
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorRuleActionsBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for conditions in .
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorRuleConditionsBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCdnFrontdoorRuleTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    [TerraformPropertyName("behavior_on_match")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BehaviorOnMatch { get; set; }

    /// <summary>
    /// The cdn_frontdoor_rule_set_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorRuleSetId is required")]
    [TerraformPropertyName("cdn_frontdoor_rule_set_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CdnFrontdoorRuleSetId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Order is required")]
    [TerraformPropertyName("order")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Order { get; set; }

    /// <summary>
    /// Block for actions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Actions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Actions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Actions block(s) allowed")]
    [TerraformPropertyName("actions")]
    public TerraformList<TerraformBlock<AzurermCdnFrontdoorRuleActionsBlock>>? Actions { get; set; } = new();

    /// <summary>
    /// Block for conditions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Conditions block(s) allowed")]
    [TerraformPropertyName("conditions")]
    public TerraformList<TerraformBlock<AzurermCdnFrontdoorRuleConditionsBlock>>? Conditions { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermCdnFrontdoorRuleTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The cdn_frontdoor_rule_set_name attribute.
    /// </summary>
    [TerraformPropertyName("cdn_frontdoor_rule_set_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CdnFrontdoorRuleSetName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cdn_frontdoor_rule_set_name");

}
