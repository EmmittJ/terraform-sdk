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
    public required TerraformProperty<TerraformProperty<string>> CostCategoryArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The default_value attribute.
    /// </summary>
    [TerraformPropertyName("default_value")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultValue => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_value");

    /// <summary>
    /// The effective_end attribute.
    /// </summary>
    [TerraformPropertyName("effective_end")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EffectiveEnd => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "effective_end");

    /// <summary>
    /// The effective_start attribute.
    /// </summary>
    [TerraformPropertyName("effective_start")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EffectiveStart => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "effective_start");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The rule attribute.
    /// </summary>
    [TerraformPropertyName("rule")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> Rule => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "rule");

    /// <summary>
    /// The rule_version attribute.
    /// </summary>
    [TerraformPropertyName("rule_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RuleVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "rule_version");

    /// <summary>
    /// The split_charge_rule attribute.
    /// </summary>
    [TerraformPropertyName("split_charge_rule")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> SplitChargeRule => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "split_charge_rule");

}
