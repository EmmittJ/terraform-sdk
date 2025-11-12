using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for rule in .
/// Nesting mode: list
/// </summary>
public partial class AwsCeCostCategoryRuleBlock() : TerraformBlock("rule")
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Type { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformProperty("value")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Value { get; set; }

}

/// <summary>
/// Block type for split_charge_rule in .
/// Nesting mode: set
/// </summary>
public partial class AwsCeCostCategorySplitChargeRuleBlock() : TerraformBlock("split_charge_rule")
{
    /// <summary>
    /// The method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Method is required")]
    [TerraformProperty("method")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Method { get; set; }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [TerraformProperty("source")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Source { get; set; }

    /// <summary>
    /// The targets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Targets is required")]
    [TerraformProperty("targets")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Targets { get; set; }

}

/// <summary>
/// Manages a aws_ce_cost_category resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsCeCostCategory : TerraformResource
{
    public AwsCeCostCategory(string name) : base("aws_ce_cost_category", name)
    {
    }

    /// <summary>
    /// The default_value attribute.
    /// </summary>
    [TerraformProperty("default_value")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DefaultValue { get; set; }

    /// <summary>
    /// The effective_start attribute.
    /// </summary>
    [TerraformProperty("effective_start")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> EffectiveStart { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The rule_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleVersion is required")]
    [TerraformProperty("rule_version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RuleVersion { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rule block(s) required")]
    [TerraformProperty("rule")]
    public required TerraformList<AwsCeCostCategoryRuleBlock> Rule { get; set; } = new();

    /// <summary>
    /// Block for split_charge_rule.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("split_charge_rule")]
    public TerraformSet<AwsCeCostCategorySplitChargeRuleBlock> SplitChargeRule { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The effective_end attribute.
    /// </summary>
    [TerraformProperty("effective_end")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EffectiveEnd { get; }

}
