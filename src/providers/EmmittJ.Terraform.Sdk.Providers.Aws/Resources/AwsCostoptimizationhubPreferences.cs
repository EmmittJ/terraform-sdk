using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_costoptimizationhub_preferences Terraform resource.
/// Manages a aws_costoptimizationhub_preferences resource.
/// </summary>
public partial class AwsCostoptimizationhubPreferences(string name) : TerraformResource("aws_costoptimizationhub_preferences", name)
{
    /// <summary>
    /// The member_account_discount_visibility attribute.
    /// </summary>
    public TerraformValue<string> MemberAccountDiscountVisibility
    {
        get => GetArgument<TerraformValue<string>>("member_account_discount_visibility") ?? AsReference("member_account_discount_visibility");
        set => SetArgument("member_account_discount_visibility", value);
    }

    /// <summary>
    /// The savings_estimation_mode attribute.
    /// </summary>
    public TerraformValue<string> SavingsEstimationMode
    {
        get => GetArgument<TerraformValue<string>>("savings_estimation_mode") ?? AsReference("savings_estimation_mode");
        set => SetArgument("savings_estimation_mode", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

}
