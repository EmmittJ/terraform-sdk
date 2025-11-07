using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_service_account_iam_binding resource.
/// </summary>
public class GoogleServiceAccountIamBinding : TerraformResource
{
    public GoogleServiceAccountIamBinding(string name) : base("google_service_account_iam_binding", name)
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
    /// The members attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Members
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("members");
        set => this.WithProperty("members", value);
    }

    /// <summary>
    /// The role attribute.
    /// </summary>
    public TerraformProperty<string>? Role
    {
        get => GetProperty<TerraformProperty<string>>("role");
        set => this.WithProperty("role", value);
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
