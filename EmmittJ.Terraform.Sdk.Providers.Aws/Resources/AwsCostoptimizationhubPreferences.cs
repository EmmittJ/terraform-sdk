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
        this.DeclareOutput("id");
    }

    /// <summary>
    /// The member_account_discount_visibility attribute.
    /// </summary>
    public string? MemberAccountDiscountVisibility
    {
        get => GetProperty<TerraformLiteralProperty<string>>("member_account_discount_visibility")?.Value;
        set => this.WithProperty("member_account_discount_visibility", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The savings_estimation_mode attribute.
    /// </summary>
    public string? SavingsEstimationMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("savings_estimation_mode")?.Value;
        set => this.WithProperty("savings_estimation_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
