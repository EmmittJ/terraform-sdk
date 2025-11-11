using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_costoptimizationhub_preferences resource.
/// </summary>
public partial class AwsCostoptimizationhubPreferences : TerraformResource
{
    public AwsCostoptimizationhubPreferences(string name) : base("aws_costoptimizationhub_preferences", name)
    {
    }

    /// <summary>
    /// The member_account_discount_visibility attribute.
    /// </summary>
    [TerraformProperty("member_account_discount_visibility")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> MemberAccountDiscountVisibility { get; set; }

    /// <summary>
    /// The savings_estimation_mode attribute.
    /// </summary>
    [TerraformProperty("savings_estimation_mode")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> SavingsEstimationMode { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

}
