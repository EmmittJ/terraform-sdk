using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_healthcare_consent_store_iam_binding resource.
/// </summary>
public class GoogleHealthcareConsentStoreIamBinding : TerraformResource
{
    public GoogleHealthcareConsentStoreIamBinding(string name) : base("google_healthcare_consent_store_iam_binding", name)
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
    public string? ConsentStoreId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("consent_store_id")?.Value;
        set => this.WithProperty("consent_store_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The dataset attribute.
    /// </summary>
    public string? Dataset
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dataset")?.Value;
        set => this.WithProperty("dataset", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The members attribute.
    /// </summary>
    public HashSet<string>? Members
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("members")?.Value;
        set => this.WithProperty("members", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
