using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_costoptimizationhub_preferences resource.
/// </summary>
public class AwsCostoptimizationhubPreferences : TerraformResource
{
    public AwsCostoptimizationhubPreferences(string name) : base("aws_costoptimizationhub_preferences", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("member_account_discount_visibility");
        SetOutput("savings_estimation_mode");
    }

    /// <summary>
    /// The member_account_discount_visibility attribute.
    /// </summary>
    public TerraformProperty<string> MemberAccountDiscountVisibility
    {
        get => GetRequiredOutput<TerraformProperty<string>>("member_account_discount_visibility");
        set => SetProperty("member_account_discount_visibility", value);
    }

    /// <summary>
    /// The savings_estimation_mode attribute.
    /// </summary>
    public TerraformProperty<string> SavingsEstimationMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("savings_estimation_mode");
        set => SetProperty("savings_estimation_mode", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
