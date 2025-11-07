using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_computeoptimizer_enrollment_status resource.
/// </summary>
public class AwsComputeoptimizerEnrollmentStatus : TerraformResource
{
    public AwsComputeoptimizerEnrollmentStatus(string name) : base("aws_computeoptimizer_enrollment_status", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
        this.DeclareOutput("number_of_member_accounts_opted_in");
    }

    /// <summary>
    /// The include_member_accounts attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? IncludeMemberAccounts
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("include_member_accounts");
        set => this.WithProperty("include_member_accounts", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Status
    {
        get => GetProperty<TerraformLiteralProperty<string>>("status");
        set => this.WithProperty("status", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The number_of_member_accounts_opted_in attribute.
    /// </summary>
    public TerraformExpression NumberOfMemberAccountsOptedIn => this["number_of_member_accounts_opted_in"];

}
