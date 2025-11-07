using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_service_account_iam_policy resource.
/// </summary>
public class GoogleServiceAccountIamPolicy : TerraformResource
{
    public GoogleServiceAccountIamPolicy(string name) : base("google_service_account_iam_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("etag");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    public TerraformProperty<string>? PolicyData
    {
        get => GetProperty<TerraformProperty<string>>("policy_data");
        set => this.WithProperty("policy_data", value);
    }

    /// <summary>
    /// The service_account_id attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceAccountId
    {
        get => GetProperty<TerraformProperty<string>>("service_account_id");
        set => this.WithProperty("service_account_id", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
