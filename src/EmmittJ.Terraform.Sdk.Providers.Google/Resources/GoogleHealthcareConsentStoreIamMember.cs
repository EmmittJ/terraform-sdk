using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_healthcare_consent_store_iam_member resource.
/// </summary>
public class GoogleHealthcareConsentStoreIamMember : TerraformResource
{
    public GoogleHealthcareConsentStoreIamMember(string name) : base("google_healthcare_consent_store_iam_member", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("etag");
    }

    /// <summary>
    /// The consent_store_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ConsentStoreId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("consent_store_id");
        set => this.WithProperty("consent_store_id", value);
    }

    /// <summary>
    /// The dataset attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Dataset
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dataset");
        set => this.WithProperty("dataset", value);
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
    /// The member attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Member
    {
        get => GetProperty<TerraformLiteralProperty<string>>("member");
        set => this.WithProperty("member", value);
    }

    /// <summary>
    /// The role attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Role
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role");
        set => this.WithProperty("role", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
