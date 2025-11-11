using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ce_cost_category.
/// </summary>
public partial class AwsCeCostCategoryDataSource : TerraformDataSource
{
    public AwsCeCostCategoryDataSource(string name) : base("aws_ce_cost_category", name)
    {
    }

    /// <summary>
    /// The cost_category_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CostCategoryArn is required")]
    [TerraformProperty("cost_category_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CostCategoryArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The default_value attribute.
    /// </summary>
    [TerraformProperty("default_value")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DefaultValue { get; }

    /// <summary>
    /// The effective_end attribute.
    /// </summary>
    [TerraformProperty("effective_end")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EffectiveEnd { get; }

    /// <summary>
    /// The effective_start attribute.
    /// </summary>
    [TerraformProperty("effective_start")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EffectiveStart { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The rule attribute.
    /// </summary>
    [TerraformProperty("rule")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> Rule { get; }

    /// <summary>
    /// The rule_version attribute.
    /// </summary>
    [TerraformProperty("rule_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RuleVersion { get; }

    /// <summary>
    /// The split_charge_rule attribute.
    /// </summary>
    [TerraformProperty("split_charge_rule")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> SplitChargeRule { get; }

}
