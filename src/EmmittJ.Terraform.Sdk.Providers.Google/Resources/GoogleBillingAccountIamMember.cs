using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_billing_account_iam_member resource.
/// </summary>
public class GoogleBillingAccountIamMember : TerraformResource
{
    public GoogleBillingAccountIamMember(string name) : base("google_billing_account_iam_member", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("etag");
    }

    /// <summary>
    /// The billing_account_id attribute.
    /// </summary>
    public string? BillingAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("billing_account_id")?.Value;
        set => this.WithProperty("billing_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The member attribute.
    /// </summary>
    public string? Member
    {
        get => GetProperty<TerraformLiteralProperty<string>>("member")?.Value;
        set => this.WithProperty("member", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The role attribute.
    /// </summary>
    public string? Role
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role")?.Value;
        set => this.WithProperty("role", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
