using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ce_cost_category.
/// </summary>
public class AwsCeCostCategoryDataSource : TerraformDataSource
{
    public AwsCeCostCategoryDataSource(string name) : base("aws_ce_cost_category", name)
    {
    }

    /// <summary>
    /// The cost_category_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CostCategoryArn is required")]
    [TerraformPropertyName("cost_category_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CostCategoryArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The default_value attribute.
    /// </summary>
    [TerraformPropertyName("default_value")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DefaultValue => new TerraformReference(this, "default_value");

    /// <summary>
    /// The effective_end attribute.
    /// </summary>
    [TerraformPropertyName("effective_end")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EffectiveEnd => new TerraformReference(this, "effective_end");

    /// <summary>
    /// The effective_start attribute.
    /// </summary>
    [TerraformPropertyName("effective_start")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EffectiveStart => new TerraformReference(this, "effective_start");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The rule attribute.
    /// </summary>
    [TerraformPropertyName("rule")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> Rule => new TerraformReference(this, "rule");

    /// <summary>
    /// The rule_version attribute.
    /// </summary>
    [TerraformPropertyName("rule_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RuleVersion => new TerraformReference(this, "rule_version");

    /// <summary>
    /// The split_charge_rule attribute.
    /// </summary>
    [TerraformPropertyName("split_charge_rule")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> SplitChargeRule => new TerraformReference(this, "split_charge_rule");

}
