using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_costoptimizationhub_preferences resource.
/// </summary>
public class AwsCostoptimizationhubPreferences : TerraformResource
{
    public AwsCostoptimizationhubPreferences(string name) : base("aws_costoptimizationhub_preferences", name)
    {
    }

    /// <summary>
    /// The member_account_discount_visibility attribute.
    /// </summary>
    [TerraformPropertyName("member_account_discount_visibility")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> MemberAccountDiscountVisibility { get; set; } = default!;

    /// <summary>
    /// The savings_estimation_mode attribute.
    /// </summary>
    [TerraformPropertyName("savings_estimation_mode")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SavingsEstimationMode { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

}
