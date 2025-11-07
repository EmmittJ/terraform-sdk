using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_billing_account_iam_policy.
/// </summary>
public class GoogleBillingAccountIamPolicyDataSource : TerraformDataSource
{
    public GoogleBillingAccountIamPolicyDataSource(string name) : base("google_billing_account_iam_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("etag");
        this.DeclareOutput("policy_data");
    }

    /// <summary>
    /// The billing_account_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? BillingAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("billing_account_id");
        set => this.WithProperty("billing_account_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    public TerraformExpression PolicyData => this["policy_data"];

}
