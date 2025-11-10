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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MemberAccountDiscountVisibility { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "member_account_discount_visibility");

    /// <summary>
    /// The savings_estimation_mode attribute.
    /// </summary>
    [TerraformPropertyName("savings_estimation_mode")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SavingsEstimationMode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "savings_estimation_mode");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

}
