using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_healthcare_consent_store_iam_policy resource.
/// </summary>
public class GoogleHealthcareConsentStoreIamPolicy : TerraformResource
{
    public GoogleHealthcareConsentStoreIamPolicy(string name) : base("google_healthcare_consent_store_iam_policy", name)
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
    /// The policy_data attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PolicyData
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_data");
        set => this.WithProperty("policy_data", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
