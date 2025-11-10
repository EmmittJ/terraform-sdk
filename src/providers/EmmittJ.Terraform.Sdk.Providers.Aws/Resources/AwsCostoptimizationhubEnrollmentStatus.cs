using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_costoptimizationhub_enrollment_status resource.
/// </summary>
public class AwsCostoptimizationhubEnrollmentStatus : TerraformResource
{
    public AwsCostoptimizationhubEnrollmentStatus(string name) : base("aws_costoptimizationhub_enrollment_status", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("id");
        this.WithOutput("status");
    }

    /// <summary>
    /// The include_member_accounts attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeMemberAccounts
    {
        get => GetProperty<TerraformProperty<bool>>("include_member_accounts");
        set => this.WithProperty("include_member_accounts", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
